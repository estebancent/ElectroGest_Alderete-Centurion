using ClosedXML.Excel;
using ElectroGest.Datas;
using ElectroGest.Models;
using ElectroGest.Utils;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroGest.Forms
{
    public partial class GestionUsuarios : Form
    {
        private int _usuarioSeleccionadoId = 0;
        private RepositoriosUsuarios _repo;

        public GestionUsuarios()
        {
            InitializeComponent();
            _repo = new RepositoriosUsuarios();
            dgvUsuarios.AutoGenerateColumns = true; // esto permite que se generen las columnas automáticamente
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarRoles();
            LimpiarCampos();
            dgvUsuarios.ClearSelection();

        }
        private void dgvUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvUsuarios.ClearSelection();
        }


        // Cargar lista de usuarios en el DataGridView
        private void CargarUsuarios()
        {
            // Pedimos los usuarios directamente desde el repositorio
            var lista = _repo.ObtenerUsuarios()
               .Select(u => new
               {
                   u.Id,
                   Nombre = u.IdNavigation != null ? u.IdNavigation.Nombre : "(Sin nombre)",
                   Dni = u.IdNavigation != null && u.IdNavigation.Dni.HasValue
                    ? u.IdNavigation.Dni.Value.ToString()
                    : "",   //  Mostrar el DNI si existe, sino vacío
                   Email = u.IdNavigation != null ? u.IdNavigation.Email : "",
                   Telefono = u.IdNavigation != null ? u.IdNavigation.Telefono : "",
                   Tipo = u.IdNavigation != null ? u.IdNavigation.Tipo : "N/A",
                   Rol = u.Rol != null ? u.Rol.Nombre : "N/A",
                   RolId = u.RolId,
                   Activo = u.Activo ?? false,

                   // Mostrar fechas
                   FechaCreacion = u.FechaCreacion.HasValue
                            ? u.FechaCreacion.Value.ToString("dd/MM/yyyy HH:mm")
                            : "No registrada",

                   FechaModificacion = u.FechaModificacion.HasValue
                            ? u.FechaModificacion.Value.ToString("dd/MM/yyyy HH:mm")
                            : "No modificado"
               })
                    .ToList();


            // Auto-generar columnas
            dgvUsuarios.AutoGenerateColumns = true;

            // Asignar la lista al DataSource
            dgvUsuarios.DataSource = lista;

            // Ocultar columna RolId (solo se usa para ComboBox)
            if (dgvUsuarios.Columns["RolId"] != null)
                dgvUsuarios.Columns["RolId"].Visible = false;

            // Refrescar para asegurar que se renderice
            dgvUsuarios.Refresh();

            // Limpiar selección inicial
            dgvUsuarios.ClearSelection();
            this.BeginInvoke(new Action(() => dgvUsuarios.ClearSelection()));

        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        // Cargar lista de roles en el ComboBox
        private void CargarRoles()
        {
            var lista = _repo.ObtenerRoles();

            CbmRol.DataSource = lista;
            CbmRol.DisplayMember = "Nombre"; // muestra el nombre del rol
            CbmRol.ValueMember = "Id";       // guarda el ID del rol
            CbmRol.SelectedIndex = -1;       // ninguno seleccionado al inicio
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvUsuarios.Rows[e.RowIndex];
            _usuarioSeleccionadoId = Convert.ToInt32(row.Cells["Id"].Value);

            BoxNombre.Text = row.Cells["Nombre"].Value.ToString();
            BoxDni.Text = row.Cells["Dni"].Value.ToString();
            BoxEmail.Text = row.Cells["Email"].Value.ToString();
            BoxTelefono.Text = row.Cells["Telefono"].Value.ToString();
            CbmRol.SelectedValue = Convert.ToInt32(row.Cells["RolId"].Value);
            chkActivo.Checked = Convert.ToBoolean(row.Cells["Activo"].Value);

            BoxPassword.Clear();
            btnEditar.Enabled = true;
            btnAgregar.Enabled = false;
            bool activo = Convert.ToBoolean(row.Cells["Activo"].Value);
            btnEliminar.Enabled = activo;


        }


        // Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<string> errores = new List<string>();

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(BoxNombre.Text) ||
                string.IsNullOrWhiteSpace(BoxEmail.Text) ||
                string.IsNullOrWhiteSpace(BoxPassword.Text) ||
                string.IsNullOrWhiteSpace(BoxConfirmarPassword.Text) ||
                CbmRol.SelectedIndex == -1)
            {
                errores.Add(" Todos los campos obligatorios deben completarse.");
            }

            // Validar DNI
            if (string.IsNullOrWhiteSpace(BoxDni.Text) || !BoxDni.Text.All(char.IsDigit))
                errores.Add(" El DNI debe contener solo números.");

            else if (BoxDni.Text.Length != 8)
                errores.Add(" El DNI debe tener exactamente 8 dígitos.");

            else if (_repo.DniExiste(int.Parse(BoxDni.Text)))
                errores.Add(" El DNI ingresado ya existe en el sistema.");


            // Validar Teléfono
            if (!string.IsNullOrWhiteSpace(BoxTelefono.Text))
            {
                if (!BoxTelefono.Text.All(char.IsDigit))
                    errores.Add(" El teléfono debe contener solo números.");

                else if (BoxTelefono.Text.Length < 10 || BoxTelefono.Text.Length > 11)
                    errores.Add(" El teléfono debe tener entre 10 y 11 dígitos.");
            }

            // Validar Email
            if (!EsEmailValido(BoxEmail.Text))
                errores.Add(" El formato del email no es válido.");

            else if (_repo.EmailExiste(BoxEmail.Text))
                errores.Add(" El email ingresado ya existe en el sistema.");

            //validar contraseñas
            if (BoxPassword.Text.Length < 4)
                errores.Add(" La contraseña debe tener al menos 4 dígitos.");

            if (BoxPassword.Text != BoxConfirmarPassword.Text)
                errores.Add(" Las contraseñas no coinciden.");

            // Si hay errores, mostrar todos en un solo MessageBox
            if (errores.Count > 0)
            {
                string mensaje = string.Join(Environment.NewLine, errores);
                MessageBox.Show(mensaje, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si todo está correcto, convertir DNI a int
            int dni = int.Parse(BoxDni.Text);

            // Crear el objeto Usuario
            var usuario = new Usuario
            {
                IdNavigation = new Persona
                {
                    Nombre = BoxNombre.Text,
                    Dni = dni,
                    Email = BoxEmail.Text,
                    Telefono = BoxTelefono.Text,
                    Tipo = "Usuario"
                },
                RolId = (int)CbmRol.SelectedValue,
                PasswordHash = PasswordHasher.HashPassword(BoxPassword.Text),
                Activo = true,
                FechaCreacion = DateTime.Now
            };

            // Guardar en la DB
            _repo.AgregarUsuario(usuario);

            CargarUsuarios();
            LimpiarCampos();
            tabControl1.SelectedIndex = 0;
            MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private bool EsEmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void BoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control (ej: Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limitar a 8 caracteres
            if (!char.IsControl(e.KeyChar) && BoxDni.Text.Length >= 8)
            {
                e.Handled = true;
            }
        }
        private void BoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limitar entre 10 y 11 caracteres
            if (!char.IsControl(e.KeyChar) && BoxTelefono.Text.Length >= 11)
            {
                e.Handled = true;
            }
        }




        private void LimpiarCampos()
        {
            _usuarioSeleccionadoId = 0;

            BoxNombre.Clear();
            BoxDni.Clear();
            BoxEmail.Clear();
            BoxTelefono.Clear();
            BoxPassword.Clear();
            BoxConfirmarPassword.Clear();

            CbmRol.SelectedIndex = -1;
            chkActivo.Checked = true;

            // Deseleccionar fila en el grid
            dgvUsuarios.ClearSelection();

            // Deshabilitar botones de editar/eliminar hasta que se seleccione una fila
            btnEditar.Enabled = false;

            btnEliminar.Enabled = false;

            btnAgregar.Enabled = true;
            BoxNombre.Focus();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        // Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;

            int id = (int)dgvUsuarios.CurrentRow.Cells["Id"].Value;
            var usuario = _repo.ObtenerUsuarios().FirstOrDefault(u => u.Id == id);

            if (usuario == null) return;

            List<string> errores = new List<string>();

            // Validar nombre
            if (string.IsNullOrWhiteSpace(BoxNombre.Text))
                errores.Add(" El nombre es obligatorio.");
            else if (BoxNombre.Text.Length > 100)
                errores.Add(" El nombre no puede exceder los 100 caracteres.");

            // Validar DNI
            if (string.IsNullOrWhiteSpace(BoxDni.Text) || !BoxDni.Text.All(char.IsDigit))
                errores.Add(" El DNI debe contener solo números.");
            else if (BoxDni.Text.Length != 8)
                errores.Add(" El DNI debe tener exactamente 8 dígitos.");
            else
            {
                int dni = int.Parse(BoxDni.Text);
                if (usuario.IdNavigation.Dni != dni && _repo.DniExiste(dni))
                    errores.Add(" El DNI ingresado ya existe en el sistema.");
            }

            // Validar Teléfono
            if (!string.IsNullOrWhiteSpace(BoxTelefono.Text))
            {
                if (!BoxTelefono.Text.All(char.IsDigit))
                    errores.Add(" El teléfono debe contener solo números.");
                else if (BoxTelefono.Text.Length < 10 || BoxTelefono.Text.Length > 11)
                    errores.Add(" El teléfono debe tener entre 10 y 11 dígitos.");
            }

            // Validar Email
            if (!EsEmailValido(BoxEmail.Text))
                errores.Add(" El formato del email no es válido.");
            else if (usuario.IdNavigation.Email != BoxEmail.Text && _repo.EmailExiste(BoxEmail.Text))
                errores.Add(" El email ingresado ya existe en el sistema.");

            // Validar contraseñas (si se edita)
            if (!string.IsNullOrWhiteSpace(BoxPassword.Text))
            {
                //validar contraseñas
                if (BoxPassword.Text.Length < 4)
                    errores.Add(" La contraseña debe tener al menos 4 dígitos.");

    
                if (BoxPassword.Text != BoxConfirmarPassword.Text)
                    errores.Add(" Las contraseñas no coinciden.");
            }

            // Mostrar errores si los hay
            if (errores.Any())
            {
                MessageBox.Show(string.Join("\n", errores), "Errores de validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Si pasó todas las validaciones, actualizar el usuario
            usuario.IdNavigation.Nombre = BoxNombre.Text;
            usuario.IdNavigation.Dni = int.Parse(BoxDni.Text);
            usuario.IdNavigation.Email = BoxEmail.Text;
            usuario.IdNavigation.Telefono = BoxTelefono.Text;
            usuario.RolId = (int)CbmRol.SelectedValue;

            if (!string.IsNullOrWhiteSpace(BoxPassword.Text))
                usuario.PasswordHash = PasswordHasher.HashPassword(BoxPassword.Text);

            usuario.FechaModificacion = DateTime.Now;
            usuario.Activo = chkActivo.Checked;

            _repo.ActualizarUsuario(usuario);
            CargarUsuarios();
            LimpiarCampos();
            tabControl1.SelectedIndex = 0;
            MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        // Eliminar (baja lógica)
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;

            var row = dgvUsuarios.CurrentRow;
            string nombre = row.Cells["Nombre"].Value.ToString();
            string rol = row.Cells["Rol"].Value.ToString();

            // Mensaje de confirmación
            var resultado = MessageBox.Show(
                $"¿Está seguro de dar de baja al usuario '{nombre}' con rol '{rol}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                int id = (int)row.Cells["Id"].Value;
                _repo.EliminarUsuario(id); // tu método de baja lógica
                CargarUsuarios();

                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void but(object sender, EventArgs e)
        {

        }

        //  private void btnEditWindows_Click(object sender, EventArgs e)
        //{
        //  if (dgvUsuarios.SelectedRows.Count == 0)
        //{
        //  MessageBox.Show("Debe seleccionar un usuario de la lista.",
        //                "Aviso",
        //              MessageBoxButtons.OK,
        //            MessageBoxIcon.Warning);
        //return;
        //}

        //else 
        //{

        // Cambiar a pestaña de edición
        //  tabControl1.SelectedIndex = 1;
        //}


        //}



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarUsuario.Text.Trim();
            var usuariosFiltrados = string.IsNullOrWhiteSpace(filtro) ? _repo.ObtenerUsuarios() : _repo.BuscarUsuarios(filtro);

            dgvUsuarios.DataSource = usuariosFiltrados.Select(u => new
            {
                u.Id,
                Nombre = u.IdNavigation != null ? u.IdNavigation.Nombre : "(Sin nombre)",
                Dni = u.IdNavigation != null && u.IdNavigation.Dni.HasValue
                    ? u.IdNavigation.Dni.Value.ToString()
                    : "",   //  Mostrar el DNI si existe, sino vacío
                Email = u.IdNavigation != null ? u.IdNavigation.Email : "",
                Telefono = u.IdNavigation != null ? u.IdNavigation.Telefono : "",
                Tipo = u.IdNavigation != null ? u.IdNavigation.Tipo : "N/A",
                Rol = u.Rol != null ? u.Rol.Nombre : "N/A",
                RolId = u.RolId,
                Activo = u.Activo ?? false,

                // Mostrar fechas
                FechaCreacion = u.FechaCreacion.HasValue
                            ? u.FechaCreacion.Value.ToString("dd/MM/yyyy HH:mm")
                            : "No registrada",

                FechaModificacion = u.FechaModificacion.HasValue
                            ? u.FechaModificacion.Value.ToString("dd/MM/yyyy HH:mm")
                            : "No modificado"
            })
                    .ToList();
        }
        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.FileStream stream = new System.IO.FileStream(sfd.FileName, System.IO.FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // 👉 Tabla con columnas = dgvUsuarios.ColumnCount
                        PdfPTable table = new PdfPTable(dgvUsuarios.Columns.Count);

                        // 👉 Cabeceras
                        foreach (DataGridViewColumn column in dgvUsuarios.Columns)
                        {
                            table.AddCell(new Phrase(column.HeaderText));
                        }

                        // 👉 Filas
                        foreach (DataGridViewRow row in dgvUsuarios.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(cell.Value?.ToString() ?? "");
                            }
                        }

                        pdfDoc.Add(table);
                        pdfDoc.Close();
                        stream.Close();
                    }

                    MessageBox.Show("Exportado a PDF correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new ClosedXML.Excel.XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Usuarios");

                        // 👉 Cabeceras
                        for (int i = 0; i < dgvUsuarios.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvUsuarios.Columns[i].HeaderText;
                        }

                        // 👉 Datos
                        for (int i = 0; i < dgvUsuarios.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvUsuarios.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dgvUsuarios.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        workbook.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Exportado a Excel correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscarUsuario.Text.Trim();

            // Fechas desde/hasta (si usás DateTimePicker con CheckBox habilitado)
            DateTime? desde = dtpDesde.Checked ? dtpDesde.Value.Date : (DateTime?)null;
            DateTime? hasta = dtpHasta.Checked ? dtpHasta.Value.Date : (DateTime?)null;

            var usuariosFiltrados = _repo.BuscarUsuarios(filtro, desde, hasta);

            if (usuariosFiltrados.Any())
            {
                dgvUsuarios.DataSource = usuariosFiltrados.Select(u => new
                {
                    u.Id,
                    Nombre = u.IdNavigation != null ? u.IdNavigation.Nombre : "(Sin nombre)",
                    Dni = u.IdNavigation != null && u.IdNavigation.Dni.HasValue
                        ? u.IdNavigation.Dni.Value.ToString()
                        : "",
                    Email = u.IdNavigation != null ? u.IdNavigation.Email : "",
                    Telefono = u.IdNavigation != null ? u.IdNavigation.Telefono : "",
                    Tipo = u.IdNavigation != null ? u.IdNavigation.Tipo : "N/A",
                    Rol = u.Rol != null ? u.Rol.Nombre : "N/A",
                    RolId = u.RolId,
                    Activo = u.Activo ?? false,
                    FechaCreacion = u.FechaCreacion.HasValue
                        ? u.FechaCreacion.Value.ToString("dd/MM/yyyy HH:mm")
                        : "No registrada",
                    FechaModificacion = u.FechaModificacion.HasValue
                        ? u.FechaModificacion.Value.ToString("dd/MM/yyyy HH:mm")
                        : "No modificado"
                }).ToList();
            }
            else
            {
                MessageBox.Show("No se encontraron usuarios con ese criterio.", "Búsqueda",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}


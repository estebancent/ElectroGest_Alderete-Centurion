using DocumentFormat.OpenXml.Spreadsheet;
using ElectroGest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroGest.Forms
{
    public partial class ProveedoresForm : Form
    {
        private int _ProveedorSeleccionadoId = 0;
        public event EventHandler ProveedoresActualizadas;
        private RepositorioProveedores _repositorio;
        public ProveedoresForm()
        {   
            InitializeComponent();
            _repositorio = new RepositorioProveedores();
        }
       

        private void CargarProveedores()
        {
            try
            {
                var proveedores = _repositorio.ObtenerTodosProveedores()
                    .OrderByDescending(p => p.IdProveedor)
                    .Select(p => new
                    {
                        p.IdProveedor,
                        p.Nombre,
                        p.Cuit,
                        p.Email,
                        p.Telefono,
                        p.Direccion,
                        p.Activo,
                       
                         FechaCreacion = p.FechaCreacion?.ToString("dd/MM/yyyy HH:mm") ?? "",
                        FechaActualizacion = p.FechaActualizacion?.ToString("dd/MM/yyyy HH:mm") ?? ""
                    })
                    .ToList();

                dataGridViewProveedores.DataSource = null;
                dataGridViewProveedores.DataSource = proveedores;

                // 🔹 Cambiar nombre de las cabeceras
                dataGridViewProveedores.Columns["IdProveedor"].HeaderText = "Nro";
                dataGridViewProveedores.Columns["Nombre"].HeaderText = "Nombre";
                dataGridViewProveedores.Columns["Cuit"].HeaderText = "CUIT";
                dataGridViewProveedores.Columns["Email"].HeaderText = "Email";
                dataGridViewProveedores.Columns["Telefono"].HeaderText = "Teléfono";
                dataGridViewProveedores.Columns["Direccion"].HeaderText = "Dirección";
                dataGridViewProveedores.Columns["Activo"].HeaderText = "Activo";
                dataGridViewProveedores.Columns["FechaCreacion"].HeaderText = "Creado";
                dataGridViewProveedores.Columns["FechaActualizacion"].HeaderText = "Actualizado";

                // 🔹 Ajuste opcional de columnas
                dataGridViewProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewProveedores.Columns["IdProveedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dataGridViewProveedores.CurrentRow == null) return;

            bool activo = Convert.ToBoolean(dataGridViewProveedores.CurrentRow.Cells["Activo"].Value);

            if (activo)
            {
                btnEliminar.Text = "Desactivar";
                btnEliminar.BackColor = System.Drawing.Color.IndianRed;
                btnEliminar.ForeColor = System.Drawing.Color.White;
                btnEliminar.Image = Properties.Resources.iconDesactivar; // <- tu ícono rojo
                btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;     // alineás el ícono
                btnEliminar.TextAlign = ContentAlignment.MiddleRight;      // texto a la derecha
            }
            else
            {
                btnEliminar.Text = "Habilitar";
                btnEliminar.BackColor = System.Drawing.Color.MediumSeaGreen;
                btnEliminar.ForeColor = System.Drawing.Color.White;
                btnEliminar.Image = Properties.Resources.iconHabilitar; // <- tu ícono verde
                btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
                btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            }


            // Deshabilitar botones de editar/eliminar hasta que se seleccione una fila
            btnEditar.Enabled = false;

            btnEliminar.Enabled = false;

            btnAgregar.Enabled = true;
        }


        private void ProveedoresForm_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            // Configurar columnas
            //dataGridView1.ColumnCount = 4;
            //ataGridView1.Columns[0].Name = "Nombre";
            //ataGridView1.Columns[1].Name = "CUIT/DNI";
            //dataGridView1.Columns[2].Name = "Teléfono";
            //dataGridView1.Columns[3].Name = "Email";

            // Opciones de estilo
            //dataGridView1.ReadOnly = true;
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Datos de ejemplo (proveedores tecnológicos / fabricantes)
            //dataGridView1.Rows.Add("Tech Solutions S.A.", "30-11223344-5", "011-4567-8901", "contacto@techsolutions.com");
            //dataGridView1.Rows.Add("Hardware Global SRL", "30-22334455-6", "011-4789-5623", "ventas@hardwareglobal.com");
            //dataGridView1.Rows.Add("Distribuidora Compumax", "30-33445566-7", "011-5678-1234", "info@compumax.com");
            // dataGridView1.Rows.Add("ElectroParts Factory", "30-44556677-8", "011-4321-8765", "soporte@electroparts.com");
            // dataGridView1.Rows.Add("Innova Tech Fabricantes", "30-55667788-9", "011-5234-9988", "proveedores@innovatech.com");
        }
        private int _proveedorSeleccionadoId = -1;

        private void dataGridViewProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dataGridViewProveedores.Rows[e.RowIndex];
                _proveedorSeleccionadoId = Convert.ToInt32(fila.Cells["IdProveedor"].Value);

                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtCuit.Text = fila.Cells["Cuit"].Value.ToString();
                txtEmail.Text = fila.Cells["Email"].Value?.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value?.ToString();
                chkActivo.Checked = (bool)fila.Cells["Activo"].Value;
            }
            if (dataGridViewProveedores.CurrentRow == null) return;

            bool activo = Convert.ToBoolean(dataGridViewProveedores.CurrentRow.Cells["Activo"].Value);

            if (activo)
            {
                btnEliminar.Text = "Desactivar";
                btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                btnEliminar.Text = "Habilitar";
                btnEliminar.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            // Deshabilitar botones de editar/eliminar hasta que se seleccione una fila
            btnEditar.Enabled = true;

            btnEliminar.Enabled = true;

            btnAgregar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_proveedorSeleccionadoId <= 0)
            {
                MessageBox.Show("Seleccione un proveedor para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var proveedor = new Proveedore
            {
                IdProveedor = _proveedorSeleccionadoId,
                Nombre = txtNombre.Text.Trim(),
                Cuit = txtCuit.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Activo = chkActivo.Checked
            };

            _repositorio.Actualizar(proveedor);
            ProveedoresActualizadas?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Proveedor actualizado correctamente.");
            CargarProveedores();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_proveedorSeleccionadoId <= 0)
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.");
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro de eliminar este proveedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                _repositorio.Desactivar(_proveedorSeleccionadoId);
                ProveedoresActualizadas?.Invoke(this, EventArgs.Empty);
                CargarProveedores();
                LimpiarCampos();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var errores = new List<string>();

            string nombre = txtNombre.Text.Trim();
            string cuit = txtCuit.Text.Trim();
            string email = txtEmail.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            // Validar nombre
            if (string.IsNullOrWhiteSpace(nombre))
                errores.Add("El nombre es obligatorio.");
            else if (nombre.Length > 100)
                errores.Add("El nombre no puede exceder los 100 caracteres.");

            // Validar CUIT: solo dígitos y exactamente 11 caracteres
            if (string.IsNullOrWhiteSpace(cuit))
                errores.Add("El CUIT es obligatorio.");
            else if (!cuit.All(char.IsDigit))
                errores.Add("El CUIT debe contener solo números.");
            else if (cuit.Length != 11)
                errores.Add("El CUIT debe tener exactamente 11 dígitos.");
            else
            {
                // Verificar unicidad usando el repo (ajustá el método si lo tenés con otro nombre)
                var encontrados = _repositorio.Buscar(cuit);
                if (encontrados != null && encontrados.Any(p => p.Cuit == cuit))
                    errores.Add("El CUIT ya está registrado en el sistema.");
            }

            // Validar email (si se ingresó)
            if (!string.IsNullOrWhiteSpace(email))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    if (addr.Address != email) errores.Add("El formato del email no es válido.");
                }
                catch
                {
                    errores.Add("El formato del email no es válido.");
                }
                if (email.Length > 150) errores.Add("El email no puede exceder los 150 caracteres.");
            }

            // Validar teléfono (si se ingresó) - solo dígitos y longitud razonable
            if (!string.IsNullOrWhiteSpace(telefono))
            {
                if (!telefono.All(char.IsDigit))
                    errores.Add("El teléfono debe contener solo números.");
                else if (telefono.Length < 7 || telefono.Length > 15)
                    errores.Add("El teléfono debe tener entre 7 y 15 dígitos.");
            }

            // Validar dirección (opcional, límite de caracteres)
            if (!string.IsNullOrWhiteSpace(direccion) && direccion.Length > 200)
                errores.Add("La dirección no puede exceder los 200 caracteres.");

            // Mostrar errores si existen
            if (errores.Any())
            {
                MessageBox.Show(string.Join("\n", errores), "Errores de validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si pasa validaciones, crear y guardar
            try
            {
                var proveedor = new Proveedore
                {
                    Nombre = nombre,
                    Cuit = cuit,
                    Email = string.IsNullOrWhiteSpace(email) ? null : email,
                    Telefono = string.IsNullOrWhiteSpace(telefono) ? null : telefono,
                    Direccion = string.IsNullOrWhiteSpace(direccion) ? null : direccion,
                    Activo = true
                };

                _repositorio.Agregar(proveedor); // o _repositorio.Agregar(proveedor) según tu repo

                MessageBox.Show("Proveedor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProveedoresActualizadas?.Invoke(this, EventArgs.Empty);
                CargarProveedores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            _proveedorSeleccionadoId = -1;
            txtNombre.Clear();
            txtCuit.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            chkActivo.Checked = false;
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.CurrentRow == null) return;

            var proveedor = (Proveedore)dataGridViewProveedores.CurrentRow.DataBoundItem;
            _repositorio.Desactivar(proveedor.IdProveedor);
            CargarProveedores();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}


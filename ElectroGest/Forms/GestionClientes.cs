using ElectroGest.Datas;
using ElectroGest.Models;
using Microsoft.Data.SqlClient;
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
    public partial class GestionClientes : Form
    {
        private readonly RepositorioClientes _repoClientes;
        private Cliente _clienteSeleccionado;
        private int _usuarioSeleccionadoId = 0;
        private RepositoriosUsuarios _repo;


        public GestionClientes()
        {
          
            InitializeComponent();
            _repoClientes = new RepositorioClientes();

        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {   
            CargarClientes();
            ConfigurarBotonEstado(false);
        }
        private void CargarClientes(string filtro = null)
        {
            var clientes = _repoClientes.ObtenerClientes(filtro)
                .Select(c => new
                {
                    c.Id,
                    Nombre = c.IdNavigation?.Nombre,
                    Email = c.IdNavigation?.Email,
                    Dni = c.IdNavigation?.Dni,
                    Telefono = c.IdNavigation?.Telefono,
                    c.Direccion,
                    c.FechaRegistro,
                    c.FechaModificacion,
                    c.Activo
                })
                .ToList();

            dgvClientes.DataSource = clientes;

            // Ocultar columnas si querés
            dgvClientes.Columns["Id"].Visible = true;
            //  dgvClientes.Columns["Activo"].Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<string> errores = new List<string>();

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(BoxNombre.Text) ||
                string.IsNullOrWhiteSpace(BoxEmail.Text) ||
                string.IsNullOrWhiteSpace(BoxDireccion.Text))
            {
                errores.Add(" Todos los campos obligatorios deben completarse.");
            }

            // Validar DNI
            if (string.IsNullOrWhiteSpace(BoxDni.Text) || !BoxDni.Text.All(char.IsDigit))
                errores.Add(" El DNI debe contener solo números.");
            else if (BoxDni.Text.Length != 8)
                errores.Add(" El DNI debe tener exactamente 8 dígitos.");
            else if (_repoClientes.DniExiste(int.Parse(BoxDni.Text)))
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
            else if (_repoClientes.EmailExiste(BoxEmail.Text))
                errores.Add(" El email ingresado ya existe en el sistema.");

            // Si hay errores, mostrar todos
            if (errores.Count > 0)
            {
                string mensaje = string.Join(Environment.NewLine, errores);
                MessageBox.Show(mensaje, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convertir DNI
            int dni = int.Parse(BoxDni.Text);

            // Crear objeto Cliente
            var cliente = new Cliente
            {
                IdNavigation = new Persona
                {
                    Nombre = BoxNombre.Text,
                    Dni = dni,
                    Email = BoxEmail.Text,
                    Telefono = BoxTelefono.Text,
                    Tipo = "Cliente"
                },
                Direccion = BoxDireccion.Text,
                FechaRegistro = DateTime.Now,
                FechaModificacion = DateTime.Now,
                Activo = true
            };

            // Guardar en la base de datos
            _repoClientes.AgregarCliente(cliente);

            // Refrescar grilla y limpiar
            CargarClientes();
            LimpiarCampos();
            MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            BoxDireccion.Clear();

            // chkActivo.Checked = true;

            // Deseleccionar fila en el grid
            dgvClientes.ClearSelection();

            // Deshabilitar botones de editar/eliminar hasta que se seleccione una fila
            //btnEditar.Enabled = false;

            btnEstado.Enabled = false;

            btnAgregar.Enabled = true;
            BoxNombre.Focus();
            ConfigurarBotonEstado(false);
        }

        private void txtBuscarDni_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarDni.Text.Trim();
            CargarClientes(filtro);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // ===================== SELECCIONAR CLIENTE =====================
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvClientes.Rows[e.RowIndex] != null)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                // Función auxiliar para convertir nulos a texto seguro
                string SafeToString(object value) =>
                    value == null || value == DBNull.Value ? "—" : value.ToString();

                // Cargar datos a los TextBox, controlando nulos
                txtIdCliente.Text = SafeToString(row.Cells["Id"].Value);
                BoxDni.Text = SafeToString(row.Cells["Dni"].Value);
                BoxNombre.Text = SafeToString(row.Cells["Nombre"].Value);
                BoxEmail.Text = SafeToString(row.Cells["Email"].Value);
                BoxTelefono.Text = SafeToString(row.Cells["Telefono"].Value);
                BoxDireccion.Text = SafeToString(row.Cells["Direccion"].Value);

                // Manejar el estado (Activo) de forma segura
                bool activo = false;
                if (row.Cells["Activo"].Value != null && row.Cells["Activo"].Value != DBNull.Value)
                {
                    bool.TryParse(row.Cells["Activo"].Value.ToString(), out activo);
                }

                // Configurar el botón dinámico de estado
                ConfigurarBotonEstado(true, activo);

                // Deshabilitar agregar mientras se edita
                btnAgregar.Enabled = false;
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
            {
                MessageBox.Show("Seleccione un cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCliente = int.Parse(txtIdCliente.Text);
            var cliente = _repoClientes.ObtenerPorId(idCliente);

            if (cliente == null)
            {
                MessageBox.Show("No se encontró el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool resultado = _repoClientes.CambiarEstadoCliente(idCliente);

            if (resultado)
            {
                string mensaje = cliente.Activo == true
                    ? "Cliente activado correctamente."
                    : "Cliente desactivado correctamente.";

                MessageBox.Show(mensaje, "Estado actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo cambiar el estado del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ===================== CONFIGURAR BOTÓN ESTADO =====================
        private void ConfigurarBotonEstados(bool habilitar, bool activo = false)
        {
            btnEstado.Enabled = habilitar;

            if (!habilitar)
            {
                btnEstado.Text = "Activar / Desactivar";
                btnEstado.BackColor = SystemColors.Control;
            }
            else
            {
                if (activo)
                {
                    btnEstado.Text = "Desactivar Cliente";
                    btnEstado.BackColor = Color.IndianRed;
                }
                else
                {
                    btnEstado.Text = "Activar Cliente";
                    btnEstado.BackColor = Color.MediumSeaGreen;
                }
            }
        }
        private void ConfigurarBotonEstado(bool habilitar, bool activo = false)
        {
            btnEstado.Enabled = habilitar;

            if (!habilitar)
            {
                btnEstado.Text = "Activar / Desactivar";
                btnEstado.BackColor = SystemColors.Control;
                btnEstado.Image = null;
            }
            else
            {
                if (activo)
                {
                    btnEstado.Text = "Desactivar Cliente";
                    btnEstado.BackColor = Color.IndianRed;
                    btnEstado.Image = Properties.Resources.iconDesactivar; // 🔴 imagen roja
                }
                else
                {
                    btnEstado.Text = "Activar Cliente";
                    btnEstado.BackColor = Color.MediumSeaGreen;
                    btnEstado.Image = Properties.Resources.iconHabilitar; // 🟢 imagen verde
                }

                // Opcional: para que la imagen quede a la izquierda del texto
                btnEstado.ImageAlign = ContentAlignment.MiddleLeft;
                btnEstado.TextAlign = ContentAlignment.MiddleRight;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvClientes.CurrentRow.Cells["Id"].Value;
            var cliente = _repoClientes.ObtenerClientes().FirstOrDefault(c => c.Id == id);

            if (cliente == null)
            {
                MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // VALIDACIONES
            List<string> errores = new List<string>();

            if (string.IsNullOrWhiteSpace(BoxNombre.Text))
                errores.Add(" El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(BoxDni.Text) || !BoxDni.Text.All(char.IsDigit))
                errores.Add(" El DNI debe contener solo números.");
            else if (BoxDni.Text.Length != 8)
                errores.Add(" El DNI debe tener exactamente 8 dígitos.");
            else
            {
                int dni = int.Parse(BoxDni.Text);
                if (cliente.IdNavigation.Dni != dni && _repoClientes.DniExiste(dni))
                    errores.Add(" El DNI ingresado ya existe en el sistema.");
            }

            if (!string.IsNullOrWhiteSpace(BoxTelefono.Text))
            {
                if (!BoxTelefono.Text.All(char.IsDigit))
                    errores.Add(" El teléfono debe contener solo números.");
                else if (BoxTelefono.Text.Length < 10 || BoxTelefono.Text.Length > 11)
                    errores.Add(" El teléfono debe tener entre 10 y 11 dígitos.");
            }

            if (!EsEmailValido(BoxEmail.Text))
                errores.Add(" El formato del email no es válido.");
            else if (cliente.IdNavigation.Email != BoxEmail.Text && _repoClientes.EmailExiste(BoxEmail.Text))
                errores.Add(" El email ingresado ya existe en el sistema.");

            if (errores.Any())
            {
                MessageBox.Show(string.Join("\n", errores), "Errores de validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ACTUALIZAR LOS DATOS
            cliente.IdNavigation.Nombre = BoxNombre.Text;
            cliente.IdNavigation.Dni = int.Parse(BoxDni.Text);
            cliente.IdNavigation.Email = BoxEmail.Text;
            cliente.IdNavigation.Telefono = BoxTelefono.Text;
            cliente.Direccion = BoxDireccion.Text;
            cliente.Activo = chkActivo.Checked;

            _repoClientes.ActualizarCliente(cliente);

            CargarClientes();
            LimpiarCampos();
            MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}


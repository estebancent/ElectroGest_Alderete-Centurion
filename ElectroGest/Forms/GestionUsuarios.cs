using ElectroGest.Datas;
using ElectroGest.Models;
using ElectroGest.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroGest.Forms
{
    public partial class GestionUsuarios : Form
    {

        private int _usuarioSeleccionadoId = 0;



        private  RepositoriosUsuarios _repo;

        public GestionUsuarios()
        {
            InitializeComponent();
            _repo = new RepositoriosUsuarios();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarRoles();
            LimpiarCampos();

        }
        // Cargar lista de usuarios en el DataGridView
        private void CargarUsuarios()
        {
            var lista = _repo.ObtenerUsuarios()
                .Select(u => new
                {
                    u.Id,
                    Nombre = u.IdNavigation != null ? u.IdNavigation.Nombre : "(Sin nombre)",
                    Email = u.IdNavigation != null ? u.IdNavigation.Email : "",
                    Telefono = u.IdNavigation != null ? u.IdNavigation.Telefono : "",
                    Rol = u.Rol != null ? u.Rol.Nombre : "N/A",
                    RolId = u.RolId,
                    Activo = u.Activo.HasValue ? u.Activo.Value : false
                })
                .ToList();

            dgvUsuarios.AutoGenerateColumns = true;   // que genere columnas automáticas
            dgvUsuarios.DataSource = lista;

            // Ocultar columna RolId, solo sirve para SelectedValue del ComboBox
            if (dgvUsuarios.Columns["RolId"] != null)
                dgvUsuarios.Columns["RolId"].Visible = false;

            dgvUsuarios.ClearSelection(); // ninguna fila seleccionada al inicio
        }

        // Cargar lista de roles en el ComboBox
        private void CargarRoles()
        {
            var repo = new RepositoriosUsuarios();
            var lista = repo.ObtenerRoles();

            CbmRol.DataSource = lista;
            CbmRol.DisplayMember = "Nombre"; // qué mostrar
            CbmRol.ValueMember = "Id";       // el valor real
            CbmRol.SelectedIndex = -1;       // ninguno seleccionado al inicio
        }


        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvUsuarios.Rows[e.RowIndex];
            _usuarioSeleccionadoId = Convert.ToInt32(row.Cells["Id"].Value);

            BoxNombre.Text = row.Cells["Nombre"].Value.ToString();
            BoxEmail.Text = row.Cells["Email"].Value.ToString();
            BoxTelefono.Text = row.Cells["Telefono"].Value.ToString();
            CbmRol.SelectedValue = Convert.ToInt32(row.Cells["RolId"].Value);
            chkActivo.Checked = Convert.ToBoolean(row.Cells["Activo"].Value);

            BoxPassword.Clear();
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }


        // Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                CbmRol.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuario = new Usuario
            {
                IdNavigation = new Persona
                {
                    Nombre = BoxNombre.Text,
                    Email = BoxEmail.Text,
                    Telefono = BoxTelefono.Text,
                    Tipo = "Usuario"
                },
                RolId = (int)CbmRol.SelectedValue,
                PasswordHash = PasswordHasher.HashPassword(txtPassword.Text),
                Activo = true
            };

            _repo.AgregarUsuario(usuario);
            CargarUsuarios();
            LimpiarCampos();
        }



        private void LimpiarCampos()
        {
            _usuarioSeleccionadoId = 0;

            BoxNombre.Clear();
            BoxEmail.Clear();
            BoxTelefono.Clear();
            BoxPassword.Clear();

            CbmRol.SelectedIndex = -1;
            chkActivo.Checked = true;

            // Deseleccionar fila en el grid
            dgvUsuarios.ClearSelection();

            // Deshabilitar botones de editar/eliminar hasta que se seleccione una fila
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            txtNombre.Focus();
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

            if (usuario != null)
            {
                usuario.IdNavigation.Nombre = txtNombre.Text;
                usuario.IdNavigation.Email = txtEmail.Text;
                usuario.IdNavigation.Telefono = txtTelefono.Text;
                usuario.RolId = (int)CbmRol.SelectedValue;

                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                    usuario.PasswordHash = PasswordHasher.HashPassword(txtPassword.Text);

                _repo.ActualizarUsuario(usuario);
                CargarUsuarios();
                LimpiarCampos();
            }
        }


        // Eliminar (baja lógica)
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;

            int id = (int)dgvUsuarios.CurrentRow.Cells["Id"].Value;
            _repo.EliminarUsuario(id);

            CargarUsuarios();
        }

        private void usuarioBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

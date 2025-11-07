using ElectroGest.Datas;
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
    public partial class FormBuscarCliente : Form
    {
        private readonly RepositorioClientes _repoClientes;
        private List<Cliente> listaClientes;

        public Cliente ClienteSeleccionado { get; private set; }

        public FormBuscarCliente()
        {
            InitializeComponent();
            _repoClientes = new RepositorioClientes();
        }

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            CargarClientes(filtro);
        }
        private void CargarClientes(string filtro = null)
        {
            listaClientes = _repoClientes.ObtenerClientes(filtro).ToList(); // ✅ Guarda la lista completa

            var clientes = listaClientes
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

            // Mostrar u ocultar columnas
            dgvClientes.Columns["Id"].Visible = true;
        }




        // 📋 Seleccionar con click
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idCliente = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["Id"].Value);
                ClienteSeleccionado = listaClientes.FirstOrDefault(c => c.Id == idCliente);
            }
        }



        // ✅ Confirmar selección
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (ClienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        // ❌ Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}

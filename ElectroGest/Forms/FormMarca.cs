using ElectroGest.Datas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectroGest.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ElectroGest.Forms
{
    public partial class FormMarca : Form
    {
   
        private RepositoriosMarcas _repositorio;

        public FormMarca()
        {
            InitializeComponent();
            _repositorio = new RepositoriosMarcas();
        }
        private void FormMarca_Load(object sender, EventArgs e)
        {
            CargarMarcas();
        }
        private void CargarMarcas()
        {
            try
            {
                // Obtener todas las marcas (activas e inactivas)
                List<Marca> marcas = _repositorio.ObtenerTodasMarcas();

                // Asignar al DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = marcas;

                // Configurar columnas
                dataGridView1.Columns["IdMarca"].HeaderText = "ID";
                dataGridView1.Columns["Nombre"].HeaderText = "Nombre";
                dataGridView1.Columns["Activo"].HeaderText = "Activo";
                dataGridView1.Columns["FechaCreacion"].HeaderText = "Fecha creación";
                dataGridView1.Columns["FechaActualizacion"].HeaderText = "Última actualización";

                // Si tiene propiedades de navegación, ocultarlas
                if (dataGridView1.Columns.Contains("Productos"))
                    dataGridView1.Columns["Productos"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar marcas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

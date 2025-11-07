using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectroGest.Datas;
using ElectroGest.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ElectroGest.Forms
{
    public partial class FormCategoria : Form
    {
        public event EventHandler CategoriasActualizadas;
        private int _categoriaSeleccionadaId = 0;
        private RepositoriosCategorias _repositorio;
        public FormCategoria() {
            InitializeComponent();
            _repositorio = new RepositoriosCategorias();
            dataGridView1.AutoGenerateColumns = true; // Asegura que las columnas se generen automáticamente
        }
        private void FormCategoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }
       private void CargarCategorias()
{
    try
    {
        // Traemos todas las categorías
        var categorias = _repositorio.ObtenerTodasCategorias()
            .Select(c => new
            {
                c.IdCategoria,
                c.Nombre,
                c.Descripcion,
                Activo = c.Activo == true, // 👈 asegura que siempre sea bool
                FechaCreacion = c.FechaCreacion?.ToString("dd/MM/yyyy HH:mm") ?? "",
                FechaActualizacion = c.FechaActualizacion?.ToString("dd/MM/yyyy HH:mm") ?? ""

            })
            .ToList();

        // Asignamos al DataGridView
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = categorias;

        // Renombrar columnas
        dataGridView1.Columns["IdCategoria"].HeaderText = "ID";
        dataGridView1.Columns["Nombre"].HeaderText = "Nombre";
        dataGridView1.Columns["Descripcion"].HeaderText = "Descripción";
        dataGridView1.Columns["Activo"].HeaderText = "Activo";
        dataGridView1.Columns["FechaCreacion"].HeaderText = "Creación";
        dataGridView1.Columns["FechaActualizacion"].HeaderText = "Última actualización";

        // Ajustes visuales opcionales
   
        dataGridView1.Columns["Descripcion"].Width = 250;
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al cargar categorías: " + ex.Message);
    }
}

    
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignorar clic en encabezado

            var row = dataGridView1.Rows[e.RowIndex];

            // Guardar ID seleccionado
            _categoriaSeleccionadaId = Convert.ToInt32(row.Cells["IdCategoria"].Value);

            // Rellenar los controles con los datos
            txtCategoria.Text = row.Cells["Nombre"].Value.ToString();
            txtDescripcion.Text = row.Cells["Descripcion"].Value?.ToString() ?? "";
            checkBoxActivar.Checked = Convert.ToBoolean(row.Cells["Activo"].Value);

            // Configurar botones según el estado
            btnEditar.Enabled = true;
            btnAgregar.Enabled = false;

            bool activo = Convert.ToBoolean(row.Cells["Activo"].Value);
            btnEliminar.Enabled = activo;
        }
        private void LimpiarCampos()
        {
            _categoriaSeleccionadaId = 0;

            txtCategoria.Clear();
            txtDescripcion.Clear();
            checkBoxActivar.Checked = false;

            // Deseleccionar fila en el grid
            dataGridView1.ClearSelection();

            // Deshabilitar botones de editar/eliminar hasta que se seleccione una fila
            btnEditar.Enabled = false;

            btnEliminar.Enabled = false;

            btnAgregar.Enabled = true;
         
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_categoriaSeleccionadaId <= 0)
            {
                MessageBox.Show("Seleccione una categoría para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Buscamos la categoría existente en la lista o desde el repositorio
                var categoriaExistente = _repositorio.ObtenerTodasCategorias()
                                                     .FirstOrDefault(c => c.IdCategoria == _categoriaSeleccionadaId);
                if (categoriaExistente == null)
                {
                    MessageBox.Show("La categoría seleccionada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Aplicamos los cambios
                categoriaExistente.Nombre = txtCategoria.Text.Trim();
                categoriaExistente.Descripcion = txtDescripcion.Text.Trim();
                categoriaExistente.Activo = checkBoxActivar.Checked;

                // Mandamos al repositorio para actualizar
                _repositorio.ActualizarCategoria(categoriaExistente);
                // Disparar el evento
              CategoriasActualizadas?.Invoke(this, EventArgs.Empty);

                MessageBox.Show("Categoría actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarCategorias(); // 🔄 refresca el DataGridView
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_categoriaSeleccionadaId <= 0)
            {
                MessageBox.Show("Seleccione una categoría para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro de que desea inhabilitar esta categoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
                return;

            try
            {
       
                _repositorio.EliminarCategoria(_categoriaSeleccionadaId);

                MessageBox.Show("Categoría inhabilitada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarCategorias(); // 🔄 refresca el DataGridView
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}

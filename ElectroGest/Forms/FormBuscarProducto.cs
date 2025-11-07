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
    public partial class FormBuscarProducto : Form
    {
        private readonly RepositorioProductos _repositorioProducto;
        public Producto ProductoSeleccionado { get; private set; }
        public FormBuscarProducto()
        {
            InitializeComponent();
            _repositorioProducto = new RepositorioProductos();
            CargarProductosIniciales();
        }

        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {

        }
  
            private void CargarProductosIniciales()
            {
                var productos = _repositorioProducto.ObtenerTodos()
                    .Select(p => new
                    {
                        p.IdProducto,
                        p.Nombre,
                        p.Sku,
                        p.CodigoBarras,
                        p.PrecioCompra,
                        p.PrecioVenta,
                        p.Stock,
                        Categoria = p.IdCategoriaNavigation != null ? p.IdCategoriaNavigation.Nombre : "Sin categoría",
                        Marca = p.IdMarcaNavigation != null ? p.IdMarcaNavigation.Nombre : "Sin marca"
                    })
                    .ToList();

                dgvProductos.DataSource = productos;
                dgvProductos.ClearSelection();
            }

            private void btnBuscar_Click(object sender, EventArgs e)
            {
                string termino = txtBuscarProducto.Text.Trim();
                if (string.IsNullOrWhiteSpace(termino))
                {
                    CargarProductosIniciales();
                    return;
                }

                var productos = _repositorioProducto.BuscarProductos(termino)
                    .Select(p => new
                    {
                        p.IdProducto,
                        p.Nombre,
                        p.Sku,
                        p.CodigoBarras,
                        p.PrecioCompra,
                        p.PrecioVenta,
                        p.Stock,
                        Categoria = p.IdCategoriaNavigation != null ? p.IdCategoriaNavigation.Nombre : "Sin categoría",
                        Marca = p.IdMarcaNavigation != null ? p.IdMarcaNavigation.Nombre : "Sin marca"
                    })
                    .ToList();

                dgvProductos.DataSource = productos;
                dgvProductos.ClearSelection();
            }

            private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                    SeleccionarProducto();
            }

            private void btnSeleccionar_Click(object sender, EventArgs e)
            {
                SeleccionarProducto();
            }

            private void SeleccionarProducto()
            {
                if (dgvProductos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccioná un producto de la lista.");
                    return;
                }

                int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["IdProducto"].Value);
                ProductoSeleccionado = _repositorioProducto.ObtenerPorId(idProducto);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            private void btnCancelar_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ElectroGest.Datas;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ElectroGest.Forms
{
    public partial class FormDetalleCompra : Form
    {
        private readonly RepositorioCompra _repoCompras;
        private readonly int _idCompra;

        public FormDetalleCompra(int idCompra)
        {
            InitializeComponent();
            _repoCompras = new RepositorioCompra();
            _idCompra = idCompra;
        }

        private void FormDetalleCompra_Load(object sender, EventArgs e)
        {
            CargarDetalleCompra();
        }

        private void CargarDetalleCompra()
        {
            try
            {
                var compra = _repoCompras.ObtenerTodas()
                    .FirstOrDefault(c => c.IdCompra == _idCompra);

                if (compra == null)
                {
                    MessageBox.Show("Compra no encontrada.");
                    return;
                }

                lblProveedor.Text = $"Proveedor: {compra.IdProveedorNavigation?.Nombre}";
                lblFecha.Text = $"Fecha: {compra.FechaCompra?.ToString("dd/MM/yyyy HH:mm")}";
                lblTotal.Text = $"Total: {compra.TotalCompra.ToString("C2")}";

              
                var detalles = _repoCompras.ObtenerDetallesPorCompra(_idCompra)
                .Select(d => new
                {
                    Producto = d.IdProductoNavigation.Nombre,
                    Cantidad = d.Cantidad,
                    PrecioCompra = d.PrecioCompraUnitario.ToString("C2"),
                    PrecioVenta = d.PrecioVentaCalculado.ToString("C2"),
                    Subtotal = d.Subtotal.ToString("C2")
                })
                .ToList();

                dgvDetalles.DataSource = detalles;

                dgvDetalles.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles: " + ex.Message);
            }
        }
    }
}


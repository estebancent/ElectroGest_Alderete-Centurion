using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class FormRegistrarCompra : Form
    {
        private RepositorioProveedores _repositorio;
        private RepositorioCompra _repositorioCompras;
        private RepositorioProductos _repositorioProductos;
        // 🔸 Declaración a nivel de clase
        private int idProductoSeleccionado = 0;
        private Usuario _usuario;
       

        public event EventHandler ProductosActualizados;

        public FormRegistrarCompra()
        {
            InitializeComponent();
            _repositorio = new RepositorioProveedores();
            _repositorioCompras = new RepositorioCompra();
            _usuario = Utils.Sesion.UsuarioActual;
        }


        private void FormRegistrarCompra_Load(object sender, EventArgs e)
        {
            CargarComboBoxProveedores();
            // Configuramos las columnas del carrito
            dgvCarrito.Columns.Clear();
            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.AllowUserToAddRows = false;

            dgvCarrito.Columns.Add("IdProducto", "ID Producto");
            dgvCarrito.Columns.Add("NombreProducto", "Producto");
            dgvCarrito.Columns.Add("Cantidad", "Cantidad");
            dgvCarrito.Columns.Add("PrecioCompra", "Precio Compra");
            dgvCarrito.Columns.Add("PrecioVenta", "Precio Venta");
            dgvCarrito.Columns.Add("Subtotal", "Subtotal");

            // Opcional: ajustar formato y alineación
            dgvCarrito.Columns["PrecioCompra"].DefaultCellStyle.Format = "C2";
            dgvCarrito.Columns["PrecioVenta"].DefaultCellStyle.Format = "C2";
            dgvCarrito.Columns["Subtotal"].DefaultCellStyle.Format = "C2";

            dgvCarrito.Columns["IdProducto"].Visible = false; // ocultamos ID interno
            if (!dgvCarrito.Columns.Contains("btnEliminar"))
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.HeaderText = "Acción";
                btnEliminar.Name = "btnEliminarSeleccionado";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                btnEliminar.Width = 80;
                dgvCarrito.Columns.Add(btnEliminar);
            }
        }
        // Manejador del evento
        private void ProveedoresForm_ProveedoresActualizadas(object sender, EventArgs e)
        {
            CargarComboBoxProveedores(); // Función que refresca el ComboBox
        }
        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que la columna sea la del botón "Eliminar"
            if (dgvCarrito.Columns[e.ColumnIndex].Name == "btnEliminar" && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show(
                    "¿Estás seguro de eliminar este producto del carrito?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    dgvCarrito.Rows.RemoveAt(e.RowIndex);
                    CalcularTotalCompra(); // Recalcula el total tras eliminar
                }
            }
        }

        private void CargarComboBoxProveedores()
        {
            var proveedoresActivos = _repositorio.ObtenerProveedoresActivos(); // solo activos
            if (proveedoresActivos != null && proveedoresActivos.Any())
            {
                cmbProveedor.DataSource = proveedoresActivos;
                cmbProveedor.DisplayMember = "Nombre";
                cmbProveedor.ValueMember = "IdProveedor";
                cmbProveedor.SelectedIndex = -1;
                cmbProveedor.Enabled = true;
            }
            else
            {
                cmbProveedor.DataSource = null;
                cmbProveedor.Items.Clear();
                cmbProveedor.Items.Add("No hay proveedores habilitados");
                cmbProveedor.SelectedIndex = 0;
                cmbProveedor.Enabled = false;
            }
        }

        private void btnAgregaMarca_Click(object sender, EventArgs e)
        {
            //ProveedoresForm addProveedor = new ProveedoresForm();

            // Mostramos el formulario como modal
            //DialogResult resultado = addProveedor.ShowDialog();
            var formProveedores = new ProveedoresForm();

            // 📡 Suscribirse al evento
            formProveedores.ProveedoresActualizadas += ProveedoresForm_ProveedoresActualizadas;

            formProveedores.ShowDialog();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var frm = new FormBuscarProducto())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var producto = frm.ProductoSeleccionado;
                    if (producto != null)
                    {
                        idProductoSeleccionado = producto.IdProducto;
                        txtProductoSeleccionado.Text = producto.Nombre;
                        txtPrecioCompra.Text = producto.PrecioCompra.HasValue ? producto.PrecioCompra.Value.ToString("0.00") : "0.00";
                        txtMargen.Text = producto.MargenGanancia.HasValue ? producto.MargenGanancia.Value.ToString("0.00") : "0.00";
                        txtPrecioVenta.Text = producto.PrecioVenta.HasValue ? producto.PrecioVenta.Value.ToString("0.00") : "0.00";

                    }
                }
            }
        }
        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito.");
                return;
            }
            //string serie = "F001"; // Podés poner esto fijo o configurable

            //  Generar serie según el proveedor
            int idProveedor = (int)cmbProveedor.SelectedValue;
            string serie = $"F{idProveedor:000}";

            int ultimoNumero = _repositorioCompras.ObtenerUltimoNumeroFactura(serie); // método que devuelve el último usado
            string numeroFactura = $"{serie}-{ultimoNumero + 1:0000}";

            var compra = new Compra
            {
                IdProveedor = (int)cmbProveedor.SelectedValue,
                IdUsuario = _usuario.Id,
                FechaCompra = DateTime.Now,
                TotalCompra = CalcularTotalDecimal(),
                NumeroFactura = string.IsNullOrWhiteSpace(txtFactura.Text)
                     ? $"{serie}-{_repositorioCompras.ObtenerUltimoNumeroFactura(serie) + 1:0000}"
                     : txtFactura.Text,
                Observaciones = string.IsNullOrWhiteSpace(txtObservaciones.Text)
                     ? "Sin observaciones"
                     : txtObservaciones.Text
            };



            int idCompra = _repositorioCompras.InsertarCompra(compra);

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                var detalle = new DetalleCompra
                {
                    IdCompra = idCompra,
                    IdProducto = Convert.ToInt32(row.Cells["IdProducto"].Value),
                    Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                    PrecioCompraUnitario = Convert.ToDecimal(row.Cells["PrecioCompra"].Value),
                    PrecioVentaCalculado = Convert.ToDecimal(row.Cells["PrecioVenta"].Value),
                    Subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value)
                };

                _repositorioCompras.InsertarDetalle(detalle);
                

                // 🔄 Registrar relación producto–proveedor
                int idProdProv = _repositorioCompras.RegistrarProductoProveedor(
                    detalle.IdProducto,
                    (int)cmbProveedor.SelectedValue,
                    detalle.PrecioCompraUnitario
                );

                // 💾 Registrar historial de precios
                _repositorioCompras.RegistrarHistorialPrecioCompra(idProdProv, detalle.PrecioCompraUnitario);
                ProductosActualizados?.Invoke(this, EventArgs.Empty);
            }
          

            MessageBox.Show("Compra registrada correctamente. El stock fue actualizado.");
          

            LimpiarFormulario();
            // 🔔 Disparar el evento para avisar que los productos se actualizaron
    

            // Cerramos el formulario si es modal
            this.Close();
        }
  

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedValue == null)
            {
                MessageBox.Show("Seleccioná un proveedor.");
                return;
            }
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccioná un producto primero.");
                return;
            }

            int cantidad = int.Parse(NumericCantidad.Text);
            decimal precioCompra = decimal.Parse(txtPrecioCompra.Text);
            decimal margen = decimal.Parse(txtMargen.Text);
            decimal precioVenta = precioCompra + (precioCompra * (margen / 100));
            decimal subtotal = cantidad * precioCompra;

            dgvCarrito.Rows.Add(
                idProductoSeleccionado,
                txtProductoSeleccionado.Text,
                cantidad,
                precioCompra,
                precioVenta,
                subtotal
            );

            CalcularTotalCompra();
            LimpiarCamposProducto();
        }
        private void CalcularTotalCompras()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }
            lblTotalCompra.Text = $"Total: ${total:0.00}";
        }
        private void CalcularTotalCompra()
        {
            decimal total = CalcularTotalDecimal();
            lblTotalCompra.Text = $"Total: ${total:N2} ARS";

            // Activar el botón finalizar sólo si hay items
            // btnFinalizarCompra.Enabled = dgvCarrito.Rows.Count > 0;
        }

        private decimal CalcularTotalDecimal()
        {
            decimal total = 0m;
            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (row.IsNewRow) continue;
                var cell = row.Cells["Subtotal"];
                if (cell?.Value == null) continue;
                if (decimal.TryParse(cell.Value.ToString(), out decimal sub))
                    total += sub;
            }
            return total;
        }

        private void LimpiarCamposProducto()
        {
            // Reiniciar selección de producto
            idProductoSeleccionado = 0; // o null si la variable es int?

            // Limpiar campos de producto
            txtProductoSeleccionado.Clear();
            txtProductoSeleccionado.Clear();
            txtPrecioCompra.Clear();
            txtMargen.Clear();
            txtPrecioVenta.Clear();
            NumericCantidad.Text = "1";
            //txtUrlImagen.Clear();

            // Restaurar imagen por defecto
            //  picProducto.Image = Properties.Resources.icons8_producto_100; // o el recurso que uses
            //picProducto.SizeMode = PictureBoxSizeMode.Zoom;

            // Estado botones
            // btnAgregarProducto.Enabled = false; // hasta que se vuelva a seleccionar un producto válido
            // Opcional: poner foco para buscar otro producto
            txtProductoSeleccionado.Focus();
        }
        private void LimpiarFormulario()
        {
            // Limpiar campos del encabezado
            txtFactura.Clear();
            txtObservaciones.Clear();

            // Restablecer proveedor (si querés dejar el seleccionado comentar la siguiente línea)
            cmbProveedor.SelectedIndex = -1;

            // Limpiar carrito (DataGridView)
            dgvCarrito.Rows.Clear();
            dgvCarrito.DataSource = null; // si lo cargas por DataSource, volver a asignar la lista vacía o Clear()

            // Reiniciar totales
            lblTotalCompra.Text = "Total: $0.00";

            // Limpiar campos de producto
            LimpiarCamposProducto();

            // Reactivar/desactivar botones
            // btnFinalizarCompra.Enabled = false;
            //btnAgregarProducto.Enabled = false;

            //Opcional: recargar combos o datos si hace falta
            CargarComboBoxProveedores(); // si querés recargar la lista de proveedores
        }

        private void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count > 0)
            {
                int fila = dgvCarrito.SelectedRows[0].Index;
                dgvCarrito.Rows.RemoveAt(fila);
                CalcularTotalCompra();
            }
            else
            {
                MessageBox.Show("Seleccioná un producto del carrito para eliminarlo.");
            }
        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

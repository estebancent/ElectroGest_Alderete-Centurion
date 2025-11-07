using ElectroGest.Datas;
using ElectroGest.Models;
using ElectroGest.Repositorios;
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
    public partial class VentasForm : Form
    {
        private Cliente clienteSeleccionado;
        private readonly RepositorioClientes _repoClientes;
        private Producto ProductoSeleccionado;
        private readonly RepositorioProductos _repositorioProducto;
        private readonly RepositorioVentas _repoVentas;
        private int idClienteSeleccionado;
        private int idProductoSeleccionado;

        private Usuario _usuario;


        public VentasForm()
        {
            InitializeComponent();
            _repoClientes = new RepositorioClientes();
            _repositorioProducto = new RepositorioProductos();
            _repoVentas = new RepositorioVentas();
            _usuario = Utils.Sesion.UsuarioActual;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            string dniTexto = txtDniBuscar.Text.Trim();

            if (string.IsNullOrEmpty(dniTexto))
            {
                MessageBox.Show("Por favor ingrese un DNI para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dniTexto, out int dni))
            {
                MessageBox.Show("El DNI ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 🔍 Buscar el cliente por DNI
            var cliente = _repoClientes.ObtenerClientes()
                .FirstOrDefault(c => c.IdNavigation != null && c.IdNavigation.Dni == dni);

            if (cliente != null)
            {
                // ✅ Guardamos el cliente encontrado
                clienteSeleccionado = cliente;

                // 🔹 Cargamos los labels
                lblNombreCliente.Text = cliente.IdNavigation.Nombre;
                lblEmailCliente.Text = cliente.IdNavigation.Email ?? "—";
                lblTelefonoCliente.Text = cliente.IdNavigation.Telefono ?? "—";
                lblDniCliente.Text = cliente.IdNavigation.Dni?.ToString() ?? "—";
                lblDireccionCliente.Text = cliente.Direccion ?? "—";

                lblNombreClienteDetalle.Text = cliente.IdNavigation.Nombre;
                // Guardamos internamente el ID (aunque no lo mostremos)
                idClienteSeleccionado = cliente.Id;
            }
            else
            {
                // ❌ Cliente no encontrado
                MessageBox.Show("No se encontró ningún cliente con ese DNI. Regístrelo antes de continuar.",
                    "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar labels
                LimpiarClientes();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void VentasForm_Load(object sender, EventArgs e)
        {
            //  Configuración del DataGridView del carrito
            lblTotalVenta.Text = "Total: $0.00";
            lblTotalFinal.Text = "$0.00";
            lblNombreVendedorDetalle.Text = $"{_usuario.IdNavigation.Nombre}";
            dgvCarrito.Columns.Clear();

            dgvCarrito.AllowUserToAddRows = false; // ❌ Evita la fila vacía al final
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.MultiSelect = false;

            // 🔹 Definición de columnas
            dgvCarrito.Columns.Add("IdProducto", "ID Producto");
            dgvCarrito.Columns.Add("IdCliente", "ID Cliente");
            dgvCarrito.Columns.Add("NombreProducto", "Producto");
            dgvCarrito.Columns.Add("Cantidad", "Cantidad");
            dgvCarrito.Columns.Add("PrecioUnitario", "Precio Unit.");
            dgvCarrito.Columns.Add("Subtotal", "Subtotal");

            // 🔹 Ocultamos las columnas que no querés mostrar
             dgvCarrito.Columns["IdProducto"].Visible = false;
             dgvCarrito.Columns["IdCliente"].Visible = false;

            // 🔹 Columna de botón “Eliminar”
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "Acción";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvCarrito.Columns.Add(btnEliminar);
            cmbMetodoPago.Items.AddRange(new string[]
   {
        "Efectivo",
        "Transferencia",
        "Débito",
        "Crédito",
        "QR"
   });
        }

        private void LimpiarClientes()
        {
            lblNombreCliente.Text = "";
            lblDniCliente.Text = "";
            lblEmailCliente.Text = "";
            lblTelefonoCliente.Text = "";
            lblDireccionCliente.Text = "";

            lblNombreClienteDetalle.Text = "";
        }
        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            string metodo = cmbMetodoPago.SelectedItem?.ToString() ?? "";

            switch (metodo)
            {
                case "Efectivo":
                    txtDescuento.Text = "10"; // 10% descuento
                    txtRecargo.Text = "0";
                    break;

                case "Transferencia":
                    txtDescuento.Text = "5"; // 5% descuento
                    txtRecargo.Text = "0";
                    break;

                case "Débito":
                    txtDescuento.Text = "0";
                    txtRecargo.Text = "0"; // precio normal
                    break;

                case "Crédito":
                    txtDescuento.Text = "0";
                    txtRecargo.Text = "15"; // 15% recargo
                    break;

                case "QR":
                    txtDescuento.Text = "8"; // 8% descuento
                    txtRecargo.Text = "0";
                    break;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var frmBuscar = new FormBuscarCliente())
            {
                if (frmBuscar.ShowDialog() == DialogResult.OK)
                {
                    clienteSeleccionado = frmBuscar.ClienteSeleccionado;

                    if (clienteSeleccionado != null)
                    {
                        // ✅ Guardamos el ID del cliente seleccionado
                        idClienteSeleccionado = clienteSeleccionado.Id;

                        // ✅ Mostramos la información en los labels
                        lblNombreCliente.Text = clienteSeleccionado.IdNavigation.Nombre;
                        lblNombreClienteDetalle.Text = clienteSeleccionado.IdNavigation.Nombre;
                        lblDniCliente.Text = clienteSeleccionado.IdNavigation.Dni?.ToString() ?? "-";
                        lblEmailCliente.Text = clienteSeleccionado.IdNavigation.Email ?? "-";
                        lblTelefonoCliente.Text = clienteSeleccionado.IdNavigation.Telefono ?? "-";
                        lblDireccionCliente.Text = clienteSeleccionado.Direccion ?? "-";
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener el cliente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            LimpiarClientes();
        }

        private void lblDniCliente_Click(object sender, EventArgs e)
        {

        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string codigoTexto = txtCodProductoBuscar.Text.Trim();

            if (string.IsNullOrEmpty(codigoTexto))
            {
                MessageBox.Show("Por favor ingrese un código de producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Buscar producto por código
            var producto = _repositorioProducto.ObtenerTodos()
                .FirstOrDefault(p => p.CodigoBarras.ToString().Equals(codigoTexto, StringComparison.OrdinalIgnoreCase));

            if (producto != null)
            {
                // ✅ Producto encontrado, rellenar campos
                txtCodProd.Text = producto.CodigoBarras;
                txtNombreProducto.Text = producto.Nombre;
                txtStockDisponible.Text = producto.Stock.ToString();
                txtPrecio.Text = producto.PrecioVenta?.ToString("0.00");

                // Guardar producto seleccionado para luego usarlo al agregar al carrito
                ProductoSeleccionado = producto;
                // Guardar el ID internamente
                idProductoSeleccionado = producto.IdProducto;
            }
            else
            {
                // ❌ Producto no encontrado
                MessageBox.Show("No se encontró ningún producto con ese código.",
                    "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //LimpiarCamposProducto();
            }
        }

        // 🧮 Recalcular total del carrito
        private void RecalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["Subtotal"].Value.ToString(), out decimal subtotal))
                        total += subtotal;
                }
            }

            lblTotalVenta.Text = $"Total: ${total:0.00}";
            lblTotalFinal.Text = $"${total:0.00}";
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (ProductoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int stockActual = (int)ProductoSeleccionado.Stock;
            int stockMinimo = (int)ProductoSeleccionado.StockMinimo;

            if (stockActual <= 0)
            {
                MessageBox.Show("No hay stock disponible para este producto.", "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cantidad > stockActual)
            {
                MessageBox.Show($"Stock insuficiente. Solo hay {stockActual} unidades disponibles.", "Error de stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (stockActual <= stockMinimo)
            {
                MessageBox.Show($" Atención: el producto '{ProductoSeleccionado.Nombre}' está por debajo del stock mínimo ({stockMinimo}).",
                    "Aviso de stock bajo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 🔹 Verificar si el producto ya está en el carrito
            foreach (DataGridViewRow fila in dgvCarrito.Rows)
            {
                if (fila.Cells["IdProducto"].Value != null &&
                    Convert.ToInt32(fila.Cells["IdProducto"].Value) == ProductoSeleccionado.IdProducto)
                {
                    MessageBox.Show("Este producto ya está agregado al carrito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // ⛔ No agrega de nuevo
                }
            }

            decimal subtotal = (decimal)(cantidad * ProductoSeleccionado.PrecioVenta);

            // Agregar al carrito
            dgvCarrito.Rows.Add(
                ProductoSeleccionado.IdProducto,
                idClienteSeleccionado,
                ProductoSeleccionado.Nombre,
                cantidad,
                ProductoSeleccionado.PrecioVenta?.ToString("0.00"),
                subtotal // ✅ guardamos valor numérico, no string
            );

            // 🔹 Recalcular total al agregar producto
            RecalcularTotal();
        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar clics inválidos
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= dgvCarrito.Rows.Count) return; // seguridad extra

            // Verificar si la columna clickeada es la del botón “Eliminar”
            if (dgvCarrito.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string nombreProducto = dgvCarrito.Rows[e.RowIndex].Cells["NombreProducto"].Value?.ToString() ?? "este producto";

                var result = MessageBox.Show(
                    $"¿Eliminar {nombreProducto} del carrito?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    dgvCarrito.Rows.RemoveAt(e.RowIndex); // eliminar la fila seleccionada
                    RecalcularTotal(); // actualizar total
                }
            }
        }
        private decimal CalcularTotalVenta()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (row.IsNewRow) continue;
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }

            lblTotalVenta.Text = total.ToString("0.00");
            return total;
        }

        private void LimpiarCamposProducto()
        {


            txtNombreProducto.Clear();
            txtCodProd.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtStockDisponible.Clear();




        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            LimpiarCamposProducto();
        }
        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            //  Validaciones básicas
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvCarrito.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // ✅ Validar que se haya seleccionado un método de pago
            if (cmbMetodoPago.SelectedIndex < 0 || string.IsNullOrWhiteSpace(cmbMetodoPago.SelectedItem?.ToString()))
            {
                MessageBox.Show("Debe seleccionar un método de pago antes de finalizar la venta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMetodoPago.Focus();
                return;
            }
            // 🔹 Obtener totales
            decimal totalOriginal = CalcularTotalVenta();
            decimal.TryParse(txtDescuento.Text, out decimal descuento);
            decimal.TryParse(txtRecargo.Text, out decimal recargo);
            decimal totalFinal = CalcularTotalFinal();
            // 🔹 Leer total final desde el label
           // string textoTotalFinal = lblTotalFinal.Text
             //   .Replace("Total:", "")
               // .Replace("$", "")
                //.Replace("ARS", "")
                //.Trim();

            //if (!decimal.TryParse(textoTotalFinal, System.Globalization.NumberStyles.Any,
              //  new System.Globalization.CultureInfo("es-AR"), out decimal totalFinal))
            //{
              //  totalFinal = totalOriginal; // fallback
            //}

            // 🧍 Crear objeto venta
            var venta = new Venta
            {
                ClienteId = clienteSeleccionado.Id,
                VendedorId = _usuario.Id, // ✅ Vendedor logueado
                MetodoPago = cmbMetodoPago.SelectedItem?.ToString() ?? "No especificado",
                Descuento = descuento,
                Recargo = recargo,
                Total = totalOriginal,
                TotalFinal = totalFinal,
               
                Observaciones = string.IsNullOrWhiteSpace(txtObservaciones.Text)
                    ? "Sin observaciones"
                    : txtObservaciones.Text
            };

            //  Crear lista de detalles
            var detalles = new List<DetalleVentum>();
            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (row.IsNewRow) continue;

                var detalle = new DetalleVentum
                {
                    IdProducto = Convert.ToInt32(row.Cells["IdProducto"].Value),
                    Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                    PrecioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value),
                    Subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value)
                };

                detalles.Add(detalle);
            }

            // 💾 Guardar en base de datos
            int idVenta = _repoVentas.InsertarVenta(venta, detalles);

            if (idVenta > 0)
            {
                MessageBox.Show($"Venta registrada correctamente.\nNúmero de factura: {venta.NumeroFactura}",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //  Mostrar la factura generada
                using (var frmFactura = new FormFactura(idVenta))
                {
                    frmFactura.ShowDialog();
                }

                //  Limpieza total del formulario
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("❌ Error al registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            // Crear instancia del formulario
            var formClientes = new GestionClientes();

            // Mostrar como ventana modal
            formClientes.ShowDialog();
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {

            {
                // Abrimos el modal de búsqueda de productos
                using (var frmBuscar = new FormBuscarProducto())
                {
                    if (frmBuscar.ShowDialog() == DialogResult.OK)
                    {
                        // Recuperamos el producto seleccionado desde el formulario modal
                        var productoSeleccionado = frmBuscar.ProductoSeleccionado;

                        if (productoSeleccionado != null)
                        {
                            // ✅ Guardar el ID del producto seleccionado
                            idProductoSeleccionado = productoSeleccionado.IdProducto;

                            // ✅ Mostrar los datos en los campos del formulario principal
                            txtCodProd.Text = productoSeleccionado.CodigoBarras?.ToString() ?? "-";
                            txtNombreProducto.Text = productoSeleccionado.Nombre ?? "-";
                            txtStockDisponible.Text = productoSeleccionado.Stock.ToString();
                            txtPrecio.Text = productoSeleccionado.PrecioVenta?.ToString("0.00") ?? "0.00";

                            // ✅ Guardar el objeto en memoria (para usarlo al agregar al carrito)
                            ProductoSeleccionado = productoSeleccionado;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo obtener el producto seleccionado.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }
        private decimal CalcularTotalFinal()
        {
            try
            {
                // ✅ Intentamos obtener el número real del label, ignorando texto no numérico
                string textoTotal = lblTotalVenta.Text
                    .Replace("Total:", "")
                    .Replace("$", "")
                    .Replace("ARS", "")
                    .Trim();

                if (!decimal.TryParse(textoTotal, System.Globalization.NumberStyles.Any,
                    new System.Globalization.CultureInfo("es-AR"), out decimal totalOriginal))
                {
                    MessageBox.Show("El valor total no tiene un formato numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }

                decimal.TryParse(txtDescuento.Text, out decimal descuento);
                decimal.TryParse(txtRecargo.Text, out decimal recargo);

                decimal montoDescuento = (totalOriginal * descuento) / 100;
                decimal montoRecargo = (totalOriginal * recargo) / 100;

                decimal totalFinal = totalOriginal - montoDescuento + montoRecargo;

                // Mostrar en el label
                lblTotalFinal.Text = totalFinal.ToString("C", new System.Globalization.CultureInfo("es-AR"));

                return totalFinal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el total final: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void btnCalcularTotalFinal_Click(object sender, EventArgs e)
        {
            CalcularTotalFinal();
        }
        private void LimpiarFormulario()
        {
            // Limpiar cliente
            clienteSeleccionado = null;
            //lblClienteSeleccionado.Text = "Cliente no seleccionado";

            // Limpiar carrito
            dgvCarrito.Rows.Clear();

            // Limpiar totales y cálculos
            lblTotalVenta.Text = "Total: $0,00";
            lblTotalFinal.Text = "Total final: $0,00";
            txtDescuento.Text = string.Empty;
            txtRecargo.Text = string.Empty;

            // Limpiar forma de pago y observaciones
            cmbMetodoPago.SelectedIndex = -1;
            txtObservaciones.Clear();

            // Opcional: resetear color o mensajes
            lblTotalFinal.ForeColor = Color.Black;
            lblTotalVenta.ForeColor = Color.Black;

            // Foco inicial en cliente
            //btnSeleccionarCliente.Focus();
            LimpiarCamposProducto();
            LimpiarClientes();
        }

    }
}


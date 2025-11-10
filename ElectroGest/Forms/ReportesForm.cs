using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using ElectroGest.Datas;
using ElectroGest.Models;
using ElectroGest.Repositorios;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore;
using ScottPlot;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;





namespace ElectroGest.Forms
{
    public partial class ReportesForm : Form
    {
        private readonly RepositorioCompra _repoCompras;
        private readonly RepositorioProductoProveedores _repoProductos;
        private readonly RepositorioProductos _repoProductos2;
        private readonly RepositorioClientes _repoClientes;
        private readonly RepositorioVentas _repoVentas;
        private readonly SistemaVentasContext _context = new SistemaVentasContext();

        public ReportesForm()
        {
            InitializeComponent();
            _repoCompras = new RepositorioCompra();
            _repoProductos = new RepositorioProductoProveedores();
            _repoProductos2 = new RepositorioProductos();
            _repoClientes = new RepositorioClientes();
            _repoVentas = new RepositorioVentas();
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {
         
            CargarProductosProveedores();
            CargarCompras();
            GraficarComprasPorProveedor();
            GraficarComprasPorUsuario();
            CargarCantidadClientes();
            CargarCantidadVentas();
            CargarCantidadProductos();
            // CargarTotalDinero();
            //   CargarTotalInvertidoYGanancia();
            CargarTotalesVentasYGanancias(null, null);
            CargarCantidadVentas(null, null);
            CargarCantidadProductos(null, null);
            CargarCantidadClientes(null, null);
            GraficarVentasPrincipal();


            GraficarProductosPorProveedorConChart();
            GraficarProductosPorProveedorConChartEstadistica();


            CargarVentas();
            CargarFiltros();
            dgvCompras.CellContentClick -= dgvCompras_CellContentClick;
            GraficarVentasPorMes();
            GraficarVentasPorUsuario();
            GraficarVentasPorCliente();
            GraficarTop5ClientesConMasCompras();
            GraficarVentasPorCategoria();

            // Agregar la columna de botón (si no existe)
            if (!dgvCompras.Columns.Contains("btnVerDetalle"))
            {
                var btnDetalle = new DataGridViewButtonColumn();
                btnDetalle.Name = "btnVerDetalle";                 // NOMBRE que vamos a chequear
                btnDetalle.HeaderText = "Detalle";
                btnDetalle.Text = "Ver Detalle";
                btnDetalle.UseColumnTextForButtonValue = true;
                btnDetalle.Width = 90;
                dgvCompras.Columns.Add(btnDetalle);
            }
        }
        private void CargarCantidadClientes(DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            try
            {
                using (var context = new SistemaVentasContext())
                {
                    var query = context.Ventas.AsQueryable();

                    if (fechaDesde.HasValue && fechaHasta.HasValue)
                    {
                        query = query.Where(v => v.FechaVenta >= fechaDesde.Value && v.FechaVenta <= fechaHasta.Value);
                    }

                    // Contar clientes distintos que compraron en ese rango
                    int totalClientes = query
                        .Select(v => v.ClienteId)
                        .Distinct()
                        .Count();

                    CantidadClientes.Text = totalClientes.ToString("N0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al contar los clientes: " + ex.Message);
            }
        }


        private void CargarCantidadProductos(DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            try
            {
                using (var context = new SistemaVentasContext())
                {
                    var query = context.DetalleVenta
                        .Include(d => d.IdVentaNavigation)
                        .AsQueryable();

                    if (fechaDesde.HasValue && fechaHasta.HasValue)
                    {
                        query = query.Where(d =>
                            d.IdVentaNavigation.FechaVenta >= fechaDesde.Value &&
                            d.IdVentaNavigation.FechaVenta <= fechaHasta.Value);
                    }

                    // Contamos productos vendidos (sumando cantidades)
                    int totalProductosVendidos = query.Sum(d => d.Cantidad);

                    CantidadProductos.Text = totalProductosVendidos.ToString("N0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al contar los productos vendidos: " + ex.Message);
            }
        }
        private void CargarCantidadVentas(DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            try
            {
                using (var context = new SistemaVentasContext())
                {
                    var query = context.Ventas.AsQueryable();

                    // Filtro opcional por fecha
                    if (fechaDesde.HasValue && fechaHasta.HasValue)
                    {
                        query = query.Where(v => v.FechaVenta >= fechaDesde.Value && v.FechaVenta <= fechaHasta.Value);
                    }

                    int totalVentas = query.Count();
                    VentasCountLabel.Text = totalVentas.ToString("N0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al contar las ventas: " + ex.Message);
            }
        }


        private void CargarCantidadProductos()
        {
            try
            {
                var productos = _repoProductos2.ObtenerProductos();
                int totalProductos = productos.Count;
                CantidadProductos.Text = totalProductos.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al contar los productos: " + ex.Message);
            }
        }

        private void CargarTotalDinero()
        {
            try
            {
                var ventas = _repoVentas.ObtenerVentas();
                decimal totalDinero = ventas.Sum(v => v.Total);
                GananciaNeta.Text = totalDinero.ToString("C2"); // Muestra con formato moneda
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el total de dinero: " + ex.Message);
            }
        }
        private void btnFiltrarGanancias_Click(object sender, EventArgs e)
        {
            DateTime desde = fechaDesde.Value.Date;
            DateTime hasta = fechaHasta.Value.Date.AddDays(1).AddTicks(-1); // incluir todo el día
            CargarTotalesVentasYGanancias(desde, hasta);
            CargarCantidadVentas(desde, hasta);
            CargarCantidadProductos(desde, hasta);
            CargarCantidadClientes(desde, hasta);
        }

        private void CargarTotalesVentasYGanancias(DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            try
            {
                // Traemos los detalles de venta junto con la fecha de la venta
                var detallesQuery = _context.DetalleVenta
                    .Include(d => d.IdProductoNavigation)
                    .Include(d => d.IdVentaNavigation)
                    .AsQueryable();

                // Si el usuario seleccionó fechas, filtramos
                if (fechaDesde.HasValue && fechaHasta.HasValue)
                {
                    detallesQuery = detallesQuery.Where(d =>
                        d.IdVentaNavigation.FechaVenta >= fechaDesde.Value &&
                        d.IdVentaNavigation.FechaVenta <= fechaHasta.Value);
                }

                var detalles = detallesQuery.Select(d => new
                {
                    Cantidad = d.Cantidad,
                    PrecioCompra = d.IdProductoNavigation.PrecioCompra ?? 0,
                    PrecioVenta = d.IdProductoNavigation.PrecioVenta ?? 0
                }).ToList();

                // Total invertido = precio de compra * cantidad
                decimal totalInvertido = detalles.Sum(d => d.PrecioCompra * d.Cantidad);

                // Total de ventas = precio de venta * cantidad
                decimal totalVentas = detalles.Sum(d => d.PrecioVenta * d.Cantidad);

                // Ganancia neta
                decimal gananciaNeta = totalVentas - totalInvertido;

                // Mostrar resultados
                CultureInfo culturaAR = new CultureInfo("es-AR");


                // pesos argentinos
                TotalInvertido.Text = totalInvertido.ToString("C2", culturaAR);
                lblTotalVentas.Text = totalVentas.ToString("C2", culturaAR);
                GananciaNeta.Text = gananciaNeta.ToString("C2", culturaAR);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular los totales: " + ex.Message);
            }
        }

        private void CargarTotalInvertidoYGanancias()
        {
            try
            {
                // Total de ventas
                var ventas = _repoVentas.ObtenerVentas();
                decimal totalVentas = ventas.Sum(v => v.Total);

                // Total de compras (dinero invertido)
                var compras = _repoCompras.ObtenerCompras();
                decimal totalInvertido = compras.Sum(c => c.TotalCompra);

                // Ganancia neta
                decimal gananciaNeta = totalVentas - totalInvertido;

                // Mostrar resultados en labels
                TotalInvertido.Text = totalInvertido.ToString("C2");
                GananciaNeta.Text = gananciaNeta.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular las ganancias: " + ex.Message);
            }
        }



        private void GraficarProductosPorProveedorConChartEstadistica()
        {
            try
            {
                // 1️⃣ Obtener datos agrupados por proveedor
                var productosPorProveedor = _repoProductos.ObtenerProductosProveedores()
                    .GroupBy(pp => pp.IdProveedorNavigation?.Nombre ?? "Sin proveedor")
                    .Select(g => new
                    {
                        Proveedor = g.Key,
                        CantidadProductos = g.Select(p => p.IdProducto).Distinct().Count() // 👈 contar productos únicos
                    })
                    .OrderByDescending(x => x.CantidadProductos)
                    .ToList();

                if (productosPorProveedor.Count == 0)
                {
                    MessageBox.Show("No hay datos de productos por proveedor para graficar.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2️⃣ Preparar nombres y valores
                string[] proveedores = productosPorProveedor
                    .Select(p => p.Proveedor.Length > 20 ? p.Proveedor.Substring(0, 20) + "…" : p.Proveedor)
                    .ToArray();

                double[] cantidades = productosPorProveedor
                    .Select(p => (double)p.CantidadProductos)
                    .ToArray();

                // 3️⃣ Limpiar gráfico
                chartCompraProveedores.Series.Clear();
                chartCompraProveedores.ChartAreas.Clear();
                chartCompraProveedores.Titles.Clear();
                chartCompraProveedores.Legends.Clear();

                // 4️⃣ Configurar el área del gráfico
                ChartArea area = new ChartArea("MainArea");
                area.BackColor = Color.White;
                area.AxisX.MajorGrid.Enabled = false;
                area.AxisY.MajorGrid.LineColor = Color.LightGray;
                area.AxisX.Interval = 1; // mostrar todos los proveedores
                area.AxisX.Title = "Proveedor";
                area.AxisY.Title = "Cantidad de Productos";
                area.AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                area.AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
                area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);
                chartCompraProveedores.ChartAreas.Add(area);

                // 5️⃣ Crear la serie
                Series serie = new Series("Productos")
                {
                    ChartType = SeriesChartType.Column, // Barras verticales
                    IsValueShownAsLabel = true,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    BorderWidth = 0
                };

                // 6️⃣ Paleta moderna
                Color[] colores = new Color[]
                {
            Color.FromArgb(52, 152, 219),
            Color.FromArgb(46, 204, 113),
            Color.FromArgb(231, 76, 60),
            Color.FromArgb(241, 196, 15),
            Color.FromArgb(155, 89, 182),
            Color.FromArgb(230, 126, 34),
            Color.FromArgb(26, 188, 156),
            Color.FromArgb(52, 73, 94)
                };

                // 7️⃣ Agregar cada barra en su posición X única
                for (int i = 0; i < proveedores.Length; i++)
                {
                    int index = serie.Points.AddXY(i, cantidades[i]); // usar posición numérica
                    serie.Points[index].Color = colores[i % colores.Length];
                    serie.Points[index].Label = $"{cantidades[i]:N0}";
                }

                chartCompraProveedores.Series.Add(serie);

                // 8️⃣ Mostrar los nombres de los proveedores en el eje X
                area.AxisX.CustomLabels.Clear();
                for (int i = 0; i < proveedores.Length; i++)
                {
                    double position = i;
                    area.AxisX.CustomLabels.Add(position - 0.5, position + 0.5, proveedores[i]);
                }

                // 9️⃣ Estilos visuales del chart
                serie["PointWidth"] = "0.6";
                serie["DrawingStyle"] = "Cylinder";

                chartCompraProveedores.BackColor = Color.White;
                chartCompraProveedores.BorderlineColor = Color.LightGray;
                chartCompraProveedores.BorderlineDashStyle = ChartDashStyle.Solid;
                chartCompraProveedores.BorderlineWidth = 1;

                // 🔟 Título
                Title title = new Title("Cantidad de Productos por Proveedor",
                    Docking.Top,
                    new Font("Segoe UI", 14, FontStyle.Bold),
                    Color.FromArgb(45, 45, 48));
                chartCompraProveedores.Titles.Add(title);

                // 11️⃣ Refrescar
                chartCompraProveedores.Invalidate();
                chartCompraProveedores.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al graficar: " + ex.Message);
            }
        }

        private void GraficarProductosPorProveedorConChart()
        {
            try
            {
                // 1️⃣ Obtener datos agrupados por proveedor
                var compras = _repoCompras.ObtenerTodas()
                    .GroupBy(c => c.IdProveedorNavigation?.Nombre ?? "Sin proveedor")
                    .Select(g => new
                    {
                        Proveedor = g.Key,
                        TotalCompras = g.Sum(c => c.TotalCompra)
                    })
                    .OrderByDescending(x => x.TotalCompras)
                    .ToList();

                if (compras.Count == 0)
                {
                    MessageBox.Show("No hay datos de compras para graficar.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2️⃣ Preparar nombres y valores
                string[] proveedores = compras
                    .Select(p => p.Proveedor.Length > 20 ? p.Proveedor.Substring(0, 20) + "…" : p.Proveedor)
                    .ToArray();

                double[] totales = compras.Select(c => (double)c.TotalCompras).ToArray();

                // 3️⃣ Limpiar gráfico
                chartComprasPorProveedores.Series.Clear();
                chartComprasPorProveedores.ChartAreas.Clear();
                chartComprasPorProveedores.Titles.Clear();
                chartComprasPorProveedores.Legends.Clear();

                // 4️⃣ Configurar el área del gráfico
                ChartArea area = new ChartArea("MainArea");
                area.BackColor = Color.White;
                area.AxisX.MajorGrid.Enabled = false;
                area.AxisY.MajorGrid.LineColor = Color.LightGray;
                area.AxisX.Interval = 1; // mostrar todos los proveedores
                area.AxisX.Title = "Proveedor";
                area.AxisY.Title = "Total de Compras ($)";
                area.AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                area.AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
                area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);
                chartComprasPorProveedores.ChartAreas.Add(area);

                // 5️⃣ Crear la serie
                Series serie = new Series("TotalCompras")
                {
                    ChartType = SeriesChartType.Column, // Barras verticales independientes
                    IsValueShownAsLabel = true,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    BorderWidth = 0
                };

                // 6️⃣ Paleta moderna
                Color[] colores = new Color[]
                {
            Color.FromArgb(52, 152, 219),
            Color.FromArgb(46, 204, 113),
            Color.FromArgb(231, 76, 60),
            Color.FromArgb(241, 196, 15),
            Color.FromArgb(155, 89, 182),
            Color.FromArgb(230, 126, 34),
            Color.FromArgb(26, 188, 156),
            Color.FromArgb(52, 73, 94)
                };

                // 7️⃣ Agregar cada barra en su posición X única
                for (int i = 0; i < proveedores.Length; i++)
                {
                    int index = serie.Points.AddXY(i, totales[i]); // 👈 usamos i como valor X (numérico)
                    serie.Points[index].Color = colores[i % colores.Length];
                    serie.Points[index].Label = $"$ {totales[i]:N0}";
                }

                chartComprasPorProveedores.Series.Add(serie);

                // 8️⃣ Mostrar los nombres de los proveedores como etiquetas del eje X
                area.AxisX.CustomLabels.Clear();
                for (int i = 0; i < proveedores.Length; i++)
                {
                    double position = i; // la posición X asignada a cada barra
                    area.AxisX.CustomLabels.Add(position - 0.5, position + 0.5, proveedores[i]);
                }

                // 9️⃣ Estilos visuales del chart
                serie["PointWidth"] = "0.6";
                serie["DrawingStyle"] = "Cylinder";

                chartComprasPorProveedores.BackColor = Color.White;
                chartComprasPorProveedores.BorderlineColor = Color.LightGray;
                chartComprasPorProveedores.BorderlineDashStyle = ChartDashStyle.Solid;
                chartComprasPorProveedores.BorderlineWidth = 1;

                // 10️⃣ Título
                Title title = new Title("Total de Compras por Proveedor",
                    Docking.Top,
                    new Font("Segoe UI", 14, FontStyle.Bold),
                    Color.FromArgb(45, 45, 48));
                chartComprasPorProveedores.Titles.Add(title);

                // 11️⃣ Refrescar
                chartComprasPorProveedores.Invalidate();
                chartComprasPorProveedores.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al graficar: " + ex.Message);
            }
        }



        private void GraficarComprasPorProveedor()
        {
            var compras = _repoCompras.ObtenerTodas()
                .GroupBy(c => c.IdProveedorNavigation?.Nombre ?? "Sin proveedor")
                .Select(g => new
                {
                    Proveedor = g.Key,
                    TotalCompras = g.Sum(c => c.TotalCompra)
                })
                .OrderByDescending(x => x.TotalCompras)
                .ToList();

            chartCompraProveedores.Series.Clear();
            chartCompraProveedores.ChartAreas.Clear();
            chartCompraProveedores.Titles.Clear();
            chartCompraProveedores.Legends.Clear();

            var area = new ChartArea("MainArea")
            {
                BackColor = Color.FromArgb(240, 245, 255),
                AxisX =
        {
            Title = "Proveedor",
            TitleFont = new Font("Segoe UI", 10, FontStyle.Bold),
            LabelStyle = { Font = new Font("Segoe UI", 9) },
            MajorGrid = { LineColor = Color.LightGray, LineDashStyle = ChartDashStyle.Dash }
        },
                AxisY =
        {
            Title = "Total de Compras ($)",
            TitleFont = new Font("Segoe UI", 10, FontStyle.Bold),
            LabelStyle = { Font = new Font("Segoe UI", 9) },
            MajorGrid = { LineColor = Color.LightGray, LineDashStyle = ChartDashStyle.Dot }
        }
            };
            chartCompraProveedores.ChartAreas.Add(area);

            var serie = new Series("Compras por proveedor")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                LabelForeColor = Color.FromArgb(40, 40, 40),
                BorderWidth = 2,
                Color = Color.FromArgb(72, 118, 255),
                BackGradientStyle = GradientStyle.VerticalCenter,
                BackSecondaryColor = Color.FromArgb(135, 206, 250)
            };

            // --- AGREGAR PUNTOS MANUALMENTE ---
            foreach (var c in compras)
            {
                int index = serie.Points.AddXY(c.Proveedor, c.TotalCompras);  // devuelve índice
                DataPoint punto = serie.Points[index];                        // obtener el DataPoint real

                punto.Label = c.TotalCompras.ToString("C0"); // muestra el total sobre la barra
            }


            chartCompraProveedores.Series.Add(serie);

            // Leyenda
            var legend = new Legend("MainLegend")
            {
                Font = new Font("Segoe UI", 9),
                BackColor = Color.Transparent,
                Docking = Docking.Bottom,
                Alignment = StringAlignment.Center
            };
            chartCompraProveedores.Legends.Add(legend);

            chartCompraProveedores.Titles.Add(new Title("Compras Totales por Proveedor",
                Docking.Top,
                new Font("Segoe UI", 12, FontStyle.Bold),
                Color.FromArgb(45, 45, 48)));

            chartCompraProveedores.BackColor = Color.White;
            chartCompraProveedores.BorderlineColor = Color.LightGray;
            chartCompraProveedores.BorderlineDashStyle = ChartDashStyle.Solid;
        }
        private void GraficarComprasPorUsuario()
        {
            // 1) Obtener cantidad de compras por usuario (conteo de registros)
            var compras = _repoCompras.ObtenerTodas()
                .GroupBy(c => c.IdUsuarioNavigation?.IdNavigation?.Nombre ?? "Sin usuario")
                .Select(g => new
                {
                    Usuario = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(x => x.Cantidad)
                .ToList();

            if (compras.Count == 0)
            {
                MessageBox.Show("No hay compras para graficar.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // --- limpiar chart ---
            chartComprasUser.Series.Clear();
            chartComprasUser.ChartAreas.Clear();
            chartComprasUser.Titles.Clear();
            chartComprasUser.Legends.Clear();

            // --- ChartArea: dejamos espacio a la derecha para la leyenda ---
            var area = new ChartArea("MainArea")
            {
                BackColor = Color.White,
                // Position: X, Y, Width, Height (dejar width <100 para la leyenda a la derecha)
                Position = new ElementPosition(5, 5, 70, 90),
                // InnerPlotPosition controla la zona interna donde se dibuja la torta
                InnerPlotPosition = new ElementPosition(10, 5, 80, 90)
            };
            chartComprasUser.ChartAreas.Add(area);

            // --- Serie Pie ---
            var serie = new Series("ComprasPorUsuario")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = false,    // mostramos % o valor en el label si queremos; preferimos la leyenda a la derecha
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                BorderWidth = 1,
                BorderColor = Color.White
            };

            // Paleta moderna (puedes agregar más colores si necesitás)
            Color[] colores = new Color[]
            {
        Color.FromArgb(93, 173, 226),   // Azul
        Color.FromArgb(46, 204, 113),   // Verde
        Color.FromArgb(241, 196, 15),   // Amarillo
        Color.FromArgb(231, 76, 60),    // Rojo
        Color.FromArgb(155, 89, 182),   // Violeta
        Color.FromArgb(52, 152, 219),   // Celeste
        Color.FromArgb(230, 126, 34),   // Naranja
        Color.FromArgb(149, 165, 166),  // Gris
        Color.FromArgb(26, 188, 156),   // Turquesa
        Color.FromArgb(52, 73, 94)      // Azul oscuro
            };

            int totalCompras = compras.Sum(x => x.Cantidad);

            //  Añadir puntos: valor = cantidad, y configurar legend text como "Usuario (N)"
            for (int i = 0; i < compras.Count; i++)
            {
                int idx = serie.Points.AddY(compras[i].Cantidad);
                var punto = serie.Points[idx];

                punto.AxisLabel = compras[i].Usuario; // etiqueta asociada (no visible si PieLabelStyle Outside/Inside)
                punto.LegendText = $"{compras[i].Usuario} ({compras[i].Cantidad})";
                punto.Color = colores[i % colores.Length];
                // mostramos porcentaje dentro de la porción (opcional)
                punto.Label = $"{(double)compras[i].Cantidad / totalCompras:P1}";
                punto.LabelForeColor = Color.White;
                punto.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }

            // Propiedades visuales de la torta
            serie["PieLabelStyle"] = "Inside";       // "Inside" o "Outside" según preferencia
            serie["PieDrawingStyle"] = "SoftEdge";   // borde suave
            serie["PieStartAngle"] = "270";
            serie["CollectedThreshold"] = "2";       // agrupa porciones < 2% en "Otros"
            serie["CollectedLabel"] = "Otros";
            serie["CollectedColor"] = "Gray";

            chartComprasUser.Series.Add(serie);

            // --- Leyenda al costado derecho (lista con usuario + cantidad) ---
            var legend = new Legend("MainLegend")
            {
                Docking = Docking.Right,
                Alignment = StringAlignment.Near,
                LegendStyle = LegendStyle.Table,
                TableStyle = LegendTableStyle.Auto,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 9),
                IsTextAutoFit = false
            };
            chartComprasUser.Legends.Add(legend);

            // Esto hace que la leyenda muestre las entradas (usa LegendText que asignamos)
            serie.IsVisibleInLegend = true;

            // --- Título ---
            chartComprasUser.Titles.Add(new Title(
                "Compras registradas por Usuario",
                Docking.Left,

                new Font("Segoe UI", 10, FontStyle.Bold),
                Color.FromArgb(40, 40, 40)
            ));

            // Fondo general
            chartComprasUser.BackColor = Color.WhiteSmoke;

            // Opcional: mejorar estilo de la leyenda (columnas, ancho)
            chartComprasUser.Legends[0].MaximumAutoSize = 50; // porción del área total que puede usar la leyenda

            // Renderizar
            chartComprasUser.Invalidate();
        }

        private void GraficarComprasPorUsuariosTotalInvertido()
        {
            var compras = _repoCompras.ObtenerTodas()
                .GroupBy(c => c.IdUsuarioNavigation?.IdNavigation?.Nombre ?? "Sin usuario")
                .Select(g => new
                {
                    Usuario = g.Key,
                    Total = g.Sum(c => c.TotalCompra)
                })
                .OrderByDescending(x => x.Total)
                .ToList();

            // Limpiar antes de dibujar
            chartComprasUser.Series.Clear();
            chartComprasUser.ChartAreas.Clear();
            chartComprasUser.Titles.Clear();
            chartComprasUser.Legends.Clear();

            // --- AREA DEL CHART ---
            var area = new ChartArea("MainArea")
            {
                BackColor = Color.White
            };

            // Agrandamos la torta y la centramos
            area.Position = new ElementPosition(5, 5, 90, 90);
            area.InnerPlotPosition = new ElementPosition(10, 5, 80, 90);

            chartComprasUser.ChartAreas.Add(area);

            // --- SERIE ---
            var serie = new Series("Compras por usuario")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BorderWidth = 2,
                BorderColor = Color.White
            };

            // Paleta de colores moderna
            Color[] colores = new Color[]
            {
                Color.FromArgb(93, 173, 226),   // Azul
                Color.FromArgb(46, 204, 113),   // Verde
                Color.FromArgb(241, 196, 15),   // Amarillo
                Color.FromArgb(231, 76, 60),    // Rojo
                Color.FromArgb(155, 89, 182),   // Violeta
                Color.FromArgb(52, 152, 219),   // Celeste
                Color.FromArgb(230, 126, 34)    // Naranja
            };

            for (int i = 0; i < compras.Count; i++)
            {
                // Agregar el punto y obtener el DataPoint
                int index = serie.Points.AddY(compras[i].Total);
                DataPoint punto = serie.Points[index];  // <-- aquí obtenemos el DataPoint real

                // Asignar propiedades visuales
                punto.AxisLabel = compras[i].Usuario;
                punto.LegendText = $"{compras[i].Usuario} (${compras[i].Total:N0})";
                punto.Color = colores[i % colores.Length];
                punto.LabelForeColor = Color.White;
                punto.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                punto.Label = $"{compras[i].Total / compras.Sum(x => x.Total):P1}"; // porcentaje
            }


            // --- EFECTOS VISUALES ---
            serie["PieLabelStyle"] = "Inside";        // Etiquetas dentro de la torta
            serie["PieDrawingStyle"] = "SoftEdge";    // Bordes suaves
            serie["PieStartAngle"] = "270";           // Comienza desde arriba
            serie["CollectedThreshold"] = "2";        // Agrupa por debajo del 2%
            serie["CollectedLabel"] = "Otros";
            serie["CollectedColor"] = "Gray";

            // --- LEYENDA ---
            var legend = new Legend("MainLegend")
            {
                Font = new Font("Segoe UI", 9),
                BackColor = Color.Transparent,
                Docking = Docking.Bottom,
                Alignment = StringAlignment.Far,
                LegendStyle = LegendStyle.Table
            };
            chartComprasUser.Legends.Add(legend);

            // --- TITULO ---
            chartComprasUser.Titles.Add(new Title(
                "Distribución de Compras por Usuario",
                Docking.Top,
                new Font("Segoe UI", 12, FontStyle.Bold),
                Color.FromArgb(40, 40, 40)
            ));

            // Fondo general
            chartComprasUser.BackColor = Color.WhiteSmoke;

            // Asignar datos
            chartComprasUser.Series.Add(serie);
            chartComprasUser.DataBind();
        }


        private void CargarProductosProveedores()
        {
            try
            {
                // Asegúrate de que el repositorio cargue las entidades relacionadas
                var lista = _repoProductos.ObtenerProductosProveedores()
                    .Select(pp => new
                    {
                        Producto = pp.IdProductoNavigation?.Nombre ?? "(Producto inexistente)",
                        Proveedor = pp.IdProveedorNavigation?.Nombre ?? "(Proveedor inexistente)",
                        PrecioCompra = pp.PrecioCompra.ToString("C2"),
                        FechaActualizacion = pp.FechaActualizacion?.ToString("dd/MM/yyyy")
                    })
                    .ToList();

                // Asignar al DataGridView
                dgvProductosProveedores.DataSource = lista;

                // Configurar encabezados
                dgvProductosProveedores.Columns["Producto"].HeaderText = "Producto";
                dgvProductosProveedores.Columns["Proveedor"].HeaderText = "Proveedor";
                dgvProductosProveedores.Columns["PrecioCompra"].HeaderText = "Precio Compra";
                dgvProductosProveedores.Columns["FechaActualizacion"].HeaderText = "Última actualización";

                // Ajustes opcionales de visualización
                dgvProductosProveedores.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProductosProveedores.Columns["Proveedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Limpiar selección inicial
                dgvProductosProveedores.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos por proveedor: " + ex.Message);
            }
        }
        private void CargarCompras()
        {
            var compras = _repoCompras.ObtenerTodas()
                .Select(c => new
                {
                    c.IdCompra,
                    c.NumeroFactura,
                    Proveedor = c.IdProveedorNavigation?.Nombre ?? "Sin proveedor",
                    Usuario = c.IdUsuarioNavigation?.IdNavigation?.Nombre ?? "Sin usuario",
                    Rol = c.IdUsuarioNavigation?.Rol?.Nombre ?? "Sin rol",
                    Fecha = c.FechaCompra?.ToString("dd/MM/yyyy HH:mm"),
                    Total = c.TotalCompra,
                    c.Observaciones
                })
                .ToList();
          
            dgvCompras.AutoGenerateColumns = true;
            dgvCompras.DataSource = compras;
            if (dgvCompras.Columns.Contains("IdCompra"))
                dgvCompras.Columns["IdCompra"].Visible = false;
            // Evitar agregar la columna del botón varias veces
            if (!dgvCompras.Columns.Contains("btnVerDetalle"))
            {
                // Crear la columna de botón
                DataGridViewButtonColumn btnVerDetalle = new DataGridViewButtonColumn();
                btnVerDetalle.Name = "btnVerDetalle";
                btnVerDetalle.HeaderText = "";
                btnVerDetalle.Text = "🔍 Ver Detalle"; // Emoji o texto
                btnVerDetalle.UseColumnTextForButtonValue = true;
                btnVerDetalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Agregar la columna
                dgvCompras.Columns.Add(btnVerDetalle);
            }

            // Formato visual del DataGridView
            dgvCompras.EnableHeadersVisualStyles = false;
            dgvCompras.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvCompras.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCompras.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvCompras.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvCompras.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 144, 255);
            dgvCompras.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvCompras.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvCompras.RowsDefaultCellStyle.BackColor = Color.White;

            // Estilo visual específico para la columna de botón
            var btnColumn = dgvCompras.Columns["btnVerDetalle"] as DataGridViewButtonColumn;
            if (btnColumn != null)
            {
                dgvCompras.CellPainting += (s, e) =>
                {
                    if (e.ColumnIndex == btnColumn.Index && e.RowIndex >= 0)
                    {
                        e.PaintBackground(e.CellBounds, true);

                        Rectangle buttonRect = new Rectangle(e.CellBounds.Left + 5, e.CellBounds.Top + 5, e.CellBounds.Width - 10, e.CellBounds.Height - 10);
                        using (System.Drawing.Brush b = new System.Drawing.SolidBrush(Color.FromArgb(0, 153, 51)))

                        {
                            //  Color.FromArgb(0, 153, 51) // verde
                            //Color.FromArgb(60, 63, 65) // gris oscuro
                            e.Graphics.FillRectangle(b, buttonRect);
                        }

                        TextRenderer.DrawText(e.Graphics, "Ver Detalle", new Font("Segoe UI", 9, FontStyle.Bold),
                            buttonRect, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                        e.Handled = true;
                    }
                };
            }
        }




        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evita clics en encabezados o celdas vacías
            if (e.RowIndex < 0 || e.RowIndex >= dgvCompras.Rows.Count)
                return;

            // Evita clics fuera de una columna válida
            if (e.ColumnIndex < 0 || e.ColumnIndex >= dgvCompras.Columns.Count)
                return;

            // Comprobamos que la columna sea la del botón "btnVerDetalle"
            if (dgvCompras.Columns[e.ColumnIndex].Name == "btnVerDetalle")
            {
                // Verificar que exista la columna "IdCompra"
                if (!dgvCompras.Columns.Contains("IdCompra"))
                {
                    MessageBox.Show("La columna 'IdCompra' no existe en el DataGridView.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener la celda del IdCompra
                var cell = dgvCompras.Rows[e.RowIndex].Cells["IdCompra"];

                // Validar que tenga valor
                if (cell == null || cell.Value == null || cell.Value == DBNull.Value)
                {
                    MessageBox.Show("No se encontró el Id de la compra seleccionada.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Intentar convertir el valor a int de forma segura
                if (!int.TryParse(cell.Value.ToString(), out int idCompra))
                {
                    MessageBox.Show("El Id de compra no es válido.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Abrir el formulario de detalle
                using (var frm = new FormDetalleCompra(idCompra))
                {
                    frm.ShowDialog();
                }
            }
        }


        private void CargarVentas(DateTime? fechaDesde = null, DateTime? fechaHasta = null, int? categoriaId = null, int? vendedorId = null)
        {
            using (var context = new SistemaVentasContext())
            {
                var query = context.Ventas
                    .Include(v => v.Cliente).ThenInclude(c => c.IdNavigation)
                    .Include(v => v.Vendedor).ThenInclude(u => u.IdNavigation)
                    .Include(v => v.Vendedor).ThenInclude(u => u.Rol)
                    .Include(v => v.DetalleVenta).ThenInclude(dv => dv.IdProductoNavigation)
                    .ThenInclude(p => p.IdCategoriaNavigation)
                    .AsQueryable();

                // 🧩 Aplicar filtros dinámicamente
                if (fechaDesde.HasValue)
                    query = query.Where(v => v.FechaVenta >= fechaDesde.Value);

                if (fechaHasta.HasValue)
                    query = query.Where(v => v.FechaVenta <= fechaHasta.Value);

                if (categoriaId.HasValue)
                    query = query.Where(v => v.DetalleVenta
                        .Any(dv => dv.IdProductoNavigation.IdCategoriaNavigation.IdCategoria == categoriaId.Value));

                if (vendedorId.HasValue)
                    query = query.Where(v => v.VendedorId == vendedorId.Value);

                var ventas = query
                    .ToList()
                    .Select(v => new
                    {
                        v.Id,
                        v.NumeroFactura,
                        Cliente = v.Cliente != null && v.Cliente.IdNavigation != null
                            ? $"{v.Cliente.IdNavigation.Nombre}"
                            : "Sin cliente",

                        Vendedor = v.Vendedor != null && v.Vendedor.IdNavigation != null
                            ? $"{v.Vendedor.IdNavigation.Nombre}"
                            : "Sin vendedor",

                        RolVendedor = v.Vendedor != null && v.Vendedor.Rol != null
                            ? v.Vendedor.Rol.Nombre
                            : "Sin rol",

                        Fecha = v.FechaVenta.HasValue ? v.FechaVenta.Value.ToString("dd/MM/yyyy HH:mm") : "—",
                        MetodoPago = v.MetodoPago ?? "—",
                        Descuento = v.Descuento,
                        Recargo = v.Recargo,
                        Total = v.Total,
                        TotalFinal = v.TotalFinal,
                        v.Observaciones,
                        Estado = v.Estado ?? "—"
                    })
                    .ToList();

                dgvVentas.AutoGenerateColumns = true;
                dgvVentas.DataSource = ventas;

                // Evitar agregar el botón varias veces
                if (!dgvVentas.Columns.Contains("btnVerDetalle"))
                {
                    DataGridViewButtonColumn btnVerDetalle = new DataGridViewButtonColumn();
                    btnVerDetalle.Name = "btnVerDetalle";
                    btnVerDetalle.HeaderText = "";
                    btnVerDetalle.Text = "🔍 Ver Detalle";
                    btnVerDetalle.UseColumnTextForButtonValue = true;
                    btnVerDetalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvVentas.Columns.Add(btnVerDetalle);
                }

                // 🎨 Mantener estilos
                dgvVentas.EnableHeadersVisualStyles = false;
                dgvVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
                dgvVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                dgvVentas.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dgvVentas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 144, 255);
                dgvVentas.DefaultCellStyle.SelectionForeColor = Color.White;

                dgvVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                dgvVentas.RowsDefaultCellStyle.BackColor = Color.White;
                dgvVentas.Columns["Id"].Visible = false;

                // 🎨 Botón personalizado
                var btnColumn = dgvVentas.Columns["btnVerDetalle"] as DataGridViewButtonColumn;
                if (btnColumn != null)
                {
                    dgvVentas.CellPainting += (s, e) =>
                    {
                        if (e.ColumnIndex == btnColumn.Index && e.RowIndex >= 0)
                        {
                            e.PaintBackground(e.CellBounds, true);

                            Rectangle buttonRect = new Rectangle(e.CellBounds.Left + 5, e.CellBounds.Top + 5,
                                e.CellBounds.Width - 10, e.CellBounds.Height - 10);

                            using (System.Drawing.Brush b = new System.Drawing.SolidBrush(Color.FromArgb(0, 153, 51)))

                            {
                                e.Graphics.FillRectangle(b, buttonRect);
                            }

                            TextRenderer.DrawText(
                                e.Graphics,
                                "Ver Detalle",
                                new Font("Segoe UI", 9, FontStyle.Bold),
                                buttonRect,
                                Color.White,
                                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                            );

                            e.Handled = true;
                        }
                    };
                }
            }
        }

        private void btnFiltrarr_Click(object sender, EventArgs e)
        {
            DateTime? desde = fechaDesdeVentas.Value.Date;
            DateTime? hasta = fechaHastaVentas.Value.Date.AddDays(1).AddSeconds(-1);
            int? categoriaId = FiltroCategoria.SelectedIndex >= 0 ? (int?)FiltroCategoria.SelectedValue : null;
            int? vendedorId = FiltroVendedor.SelectedIndex >= 0 ? (int?)FiltroVendedor.SelectedValue : null;

            CargarVentas(desde, hasta, categoriaId, vendedorId);
        }
        private void btnFiltrar2_Click(object sender, EventArgs e)
        {
            DateTime? desde = fechaDesdeVentas.Value.Date;
            DateTime? hasta = fechaHastaVentas.Value.Date.AddDays(1).AddSeconds(-1);

            int? categoriaId = (int)FiltroCategoria.SelectedValue != 0 ? (int?)FiltroCategoria.SelectedValue : null;
            int? vendedorId = (int)FiltroVendedor.SelectedValue != 0 ? (int?)FiltroVendedor.SelectedValue : null;

            CargarVentas(desde, hasta, categoriaId, vendedorId);
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime? desde = fechaDesdeVentas.Value.Date;
            DateTime? hasta = fechaHastaVentas.Value.Date.AddDays(1).AddSeconds(-1);

            int? categoriaId = null;
            int? vendedorId = null;

            if (FiltroCategoria != null && FiltroCategoria.SelectedValue != null && (int)FiltroCategoria.SelectedValue != 0)
                categoriaId = (int)FiltroCategoria.SelectedValue;

            if (FiltroVendedor != null && FiltroVendedor.SelectedValue != null && (int)FiltroVendedor.SelectedValue != 0)
                vendedorId = (int)FiltroVendedor.SelectedValue;

            CargarVentas(desde, hasta, categoriaId, vendedorId);
        }



        private void CargarFiltros()
        {
            using (var context = new SistemaVentasContext())
            {
                //FILTRO DE CATEGORÍA
                var categorias = context.Categorias
                    .OrderBy(c => c.Nombre)
                    .Select(c => new { c.IdCategoria, c.Nombre })
                    .ToList();

                // "Todos"
                categorias.Insert(0, new { IdCategoria = 0, Nombre = "Todas las categorías" });

                FiltroCategoria.DataSource = categorias;
                FiltroCategoria.DisplayMember = "Nombre";
                FiltroCategoria.ValueMember = "IdCategoria";
                FiltroCategoria.SelectedIndex = 0; // Por defecto "Todas"

                // === FILTRO DE VENDEDORES ===
                var vendedores = context.Usuarios
                    .Include(u => u.IdNavigation)
                    .Where(u => u.Rol.Nombre == "Vendedor")
                    .Select(u => new { u.Id, Nombre = u.IdNavigation.Nombre })
                    .ToList();

                // Todos"
                vendedores.Insert(0, new { Id = 0, Nombre = "Todos los vendedores" });

                FiltroVendedor.DataSource = vendedores;
                FiltroVendedor.DisplayMember = "Nombre";
                FiltroVendedor.ValueMember = "Id";
                FiltroVendedor.SelectedIndex = 0; // Por defecto "Todos"

                // === FECHAS PREDETERMINADAS ===
                fechaDesdeVentas.Value = DateTime.Today.AddMonths(-3);
                fechaHastaVentas.Value = DateTime.Today;
            }
        }


        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            fechaDesdeVentas.Value = DateTime.Today.AddMonths(-3);
            fechaHastaVentas.Value = DateTime.Today;
            FiltroCategoria.SelectedIndex = -1;
            FiltroVendedor.SelectedIndex = -1;

            CargarVentas(); // recarga todo sin filtros
        }
        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            string termino = txtBuscarCliente.Text.Trim();

            // Si el usuario borra todo, mostrar todas las ventas
            if (string.IsNullOrEmpty(termino))
            {
                CargarVentas();
                return;
            }

            // Aplicar filtro de búsqueda (por nombre o DNI)
            BuscarVentasPorCliente(termino);
        }

        private void BuscarVentasPorCliente(string termino)
        {
            using (var context = new SistemaVentasContext())
            {
                var query = context.Ventas
                    .Include(v => v.Cliente).ThenInclude(c => c.IdNavigation)
                    .Include(v => v.Vendedor).ThenInclude(u => u.IdNavigation)
                    .Include(v => v.Vendedor).ThenInclude(u => u.Rol)
                    .Include(v => v.DetalleVenta).ThenInclude(dv => dv.IdProductoNavigation)
                    .ThenInclude(p => p.IdCategoriaNavigation)
                    .AsQueryable();

                // Filtrar por coincidencia de nombre o DNI
                query = query.Where(v =>
                    v.Cliente.IdNavigation.Nombre.Contains(termino) ||
                    (v.Cliente.IdNavigation.Dni.HasValue &&
                     v.Cliente.IdNavigation.Dni.ToString().Contains(termino)));

                var ventas = query
                    .ToList()
                    .Select(v => new
                    {
                        v.Id,
                        v.NumeroFactura,
                        Cliente = v.Cliente != null && v.Cliente.IdNavigation != null
                            ? $"{v.Cliente.IdNavigation.Nombre}"
                            : "Sin cliente",

                        Vendedor = v.Vendedor != null && v.Vendedor.IdNavigation != null
                            ? $"{v.Vendedor.IdNavigation.Nombre}"
                            : "Sin vendedor",

                        RolVendedor = v.Vendedor != null && v.Vendedor.Rol != null
                            ? v.Vendedor.Rol.Nombre
                            : "Sin rol",

                        Fecha = v.FechaVenta.HasValue ? v.FechaVenta.Value.ToString("dd/MM/yyyy HH:mm") : "—",
                        MetodoPago = v.MetodoPago ?? "—",
                        Descuento = v.Descuento,
                        Recargo = v.Recargo,
                        Total = v.Total,
                        TotalFinal = v.TotalFinal,
                        v.Observaciones,
                        Estado = v.Estado ?? "—"
                    })
                    .ToList();

                dgvVentas.DataSource = ventas;
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            var datos = ObtenerDatosVentasActuales();

            if (datos.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Ventas");

                // 🟦 Encabezado de empresa
                ws.Cell("A1").Value = "ELECTROGEST";
                ws.Cell("A1").Style.Font.SetBold();
                ws.Cell("A1").Style.Font.FontSize = 18;
                ws.Cell("A1").Style.Font.FontColor = XLColor.White;
                ws.Range("A1:K1").Merge();
                ws.Range("A1:K1").Style.Fill.BackgroundColor = XLColor.FromHtml("#0078D7"); // Azul corporativo
                ws.Range("A1:K1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range("A1:K1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                // 🕒 Fecha de exportación
                ws.Cell("A2").Value = $"Fecha de exportación: {DateTime.Now:dd/MM/yyyy HH:mm}";
                ws.Range("A2:K2").Merge();
                ws.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                ws.Cell("A2").Style.Font.Italic = true;
                ws.Cell("A2").Style.Font.FontSize = 10;
                ws.Row(2).Height = 20;

                // 📋 Encabezados de la tabla
                string[] headers = {
            "ID Venta", "Cliente", "Vendedor", "Fecha Venta", "Estado",
            "Forma de Pago", "Descuento (%)", "Recargo (%)",
            "Total", "Total Final", "Observaciones"
        };

                for (int i = 0; i < headers.Length; i++)
                {
                    ws.Cell(4, i + 1).Value = headers[i];
                }

                // 🎨 Estilo del encabezado de tabla
                var headerRange = ws.Range(4, 1, 4, headers.Length);
                headerRange.Style.Font.Bold = true;
                headerRange.Style.Fill.BackgroundColor = XLColor.FromHtml("#1E1E1E");
                headerRange.Style.Font.FontColor = XLColor.White;
                headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                headerRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                headerRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                headerRange.Style.Border.OutsideBorderColor = XLColor.Black;
                headerRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                headerRange.Style.Border.InsideBorderColor = XLColor.Black;

                // 📊 Cargar datos
                int fila = 5;
                foreach (var item in datos)
                {
                    ws.Cell(fila, 1).Value = item.Id;
                    ws.Cell(fila, 2).Value = item.Cliente;
                    ws.Cell(fila, 3).Value = item.Vendedor;
                    ws.Cell(fila, 4).Value = item.Fecha;
                    ws.Cell(fila, 5).Value = item.Estado;
                    ws.Cell(fila, 6).Value = item.FormaPago;
                    ws.Cell(fila, 7).Value = item.Descuento;
                    ws.Cell(fila, 8).Value = item.Recargo;
                    ws.Cell(fila, 9).Value = item.Total;
                    ws.Cell(fila, 10).Value = item.TotalFinal;
                    ws.Cell(fila, 11).Value = item.Observaciones;
                    fila++;
                }

                // Formatos numéricos
                ws.Column(9).Style.NumberFormat.Format = "$ #,##0.00";
                ws.Column(10).Style.NumberFormat.Format = "$ #,##0.00";

                // Bordes para toda la tabla
                var dataRange = ws.Range(4, 1, fila - 1, headers.Length);
                dataRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                dataRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                dataRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                // Ajustar ancho de columnas
                ws.Columns().AdjustToContents();

                // Pie de página
                ws.Cell(fila + 2, 1).Value = "Reporte generado automáticamente por ElectroGest";
                ws.Range(fila + 2, 1, fila + 2, headers.Length).Merge();
                ws.Cell(fila + 2, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell(fila + 2, 1).Style.Font.Italic = true;
                ws.Cell(fila + 2, 1).Style.Font.FontColor = XLColor.Gray;

                // Guardar archivo
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Archivos Excel (*.xlsx)|*.xlsx",
                    Title = "Guardar reporte de ventas"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Reporte exportado correctamente a Excel.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private List<dynamic> ObtenerDatosVentasActuales()
        {
            var lista = new List<dynamic>();

            if (dgvVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return lista;
            }

            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.IsNewRow) continue;

                lista.Add(new
                {
                    Id = row.Cells["Id"].Value,
                    Cliente = row.Cells["Cliente"].Value,
                    Vendedor = row.Cells["Vendedor"].Value,
                    Fecha = row.Cells["Fecha"].Value,
                    Estado = row.Cells["Estado"].Value,
                    FormaPago = row.Cells["MetodoPago"].Value,
                    Descuento = row.Cells["Descuento"].Value,
                    Recargo = row.Cells["Recargo"].Value,
                    Total = row.Cells["Total"].Value,
                    TotalFinal = row.Cells["TotalFinal"].Value,
                    Observaciones = row.Cells["Observaciones"].Value
                });
            }

            return lista;
        }





        private void dgvVentass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evita clics en encabezados o fuera del rango
            if (e.RowIndex < 0 || e.RowIndex >= dgvVentas.Rows.Count)
                return;

            if (e.ColumnIndex < 0 || e.ColumnIndex >= dgvVentas.Columns.Count)
                return;

            // Comprobar que se haya hecho clic en el botón "btnVerDetalle"
            if (dgvVentas.Columns[e.ColumnIndex].Name == "btnVerDetalle")
            {
                if (!dgvVentas.Columns.Contains("Id"))
                {
                    MessageBox.Show("La columna 'Id' no existe en el DataGridView.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var cell = dgvVentas.Rows[e.RowIndex].Cells["Id"];
                if (cell?.Value == null || cell.Value == DBNull.Value)
                {
                    MessageBox.Show("No se encontró el Id de la venta seleccionada.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(cell.Value.ToString(), out int idVenta))
                {
                    MessageBox.Show("El Id de venta no es válido.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Abrir el formulario de detalle
                //  using (var frm = new FormFactura(idVenta))
                //{
                //  frm.ShowDialog();
                //}
            }
        }
        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvVentas.Columns[e.ColumnIndex].Name == "btnVerDetalle")
            {
                var cell = dgvVentas.Rows[e.RowIndex].Cells["Id"];

                if (cell?.Value == null || !int.TryParse(cell.Value.ToString(), out int idVenta))
                {
                    MessageBox.Show("No se encontró el Id de la venta seleccionada.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var frm = new FormFactura(idVenta))
                {
                    frm.ShowDialog();
                }
            }
        }
        private void GraficarVentasPorMes()
        {
            try
            {
                // 1️⃣ Obtener todas las ventas
                var ventas = _repoVentas.ObtenerTodas();

                if (ventas.Count == 0)
                {
                    MessageBox.Show("No hay ventas registradas para graficar.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2️⃣ Agrupar por mes y año
                var ventasPorMes = ventas
                    .Where(v => v.FechaVenta != null)
                    .GroupBy(v => new { v.FechaVenta.Value.Year, v.FechaVenta.Value.Month })
                    .Select(g => new
                    {
                        Fecha = new DateTime(g.Key.Year, g.Key.Month, 1),
                        Total = g.Sum(v => v.TotalFinal)
                    })
                    .OrderBy(x => x.Fecha)
                    .ToList();

                // 3️⃣ Preparar etiquetas y valores
                string[] etiquetasMeses = ventasPorMes
                    .Select(v => v.Fecha.ToString("MMM yy")) // más compacto (Ene 25)
                    .ToArray();

                double[] totales = ventasPorMes.Select(v => (double)v.Total).ToArray();

                // 4️⃣ Limpiar gráfico
                chartVentasMensuales.Series.Clear();
                chartVentasMensuales.ChartAreas.Clear();
                chartVentasMensuales.Titles.Clear();
                chartVentasMensuales.Legends.Clear();

                // 5️⃣ Configurar área del gráfico
                ChartArea area = new ChartArea("MainArea")
                {
                    BackColor = Color.White
                };

                // Cuadrícula ligera y moderna
                area.AxisX.MajorGrid.LineColor = Color.FromArgb(235, 235, 235);
                area.AxisY.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);

                // Títulos de ejes
                area.AxisX.Title = "Mes";
                area.AxisY.Title = "Total de Ventas ($)";
                area.AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                area.AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);

                // Etiquetas del eje
                area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                area.AxisX.LabelStyle.ForeColor = Color.FromArgb(60, 60, 60);
                area.AxisY.LabelStyle.ForeColor = Color.FromArgb(60, 60, 60);

                // Ajustes visuales del eje X
                area.AxisX.Interval = 1;
                area.AxisX.LabelStyle.Angle = -30; // ligeramente inclinadas
                area.AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont | LabelAutoFitStyles.StaggeredLabels;
                area.AxisX.IsLabelAutoFit = true;

                // Márgenes equilibrados
                area.Position = new ElementPosition(5, 10, 90, 80);
                area.InnerPlotPosition = new ElementPosition(5, 0, 90, 90);

                chartVentasMensuales.ChartAreas.Add(area);

                // 6️⃣ Crear la serie (línea moderna con puntos)
                Series serie = new Series("VentasMensuales")
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 3,
                    Color = Color.FromArgb(52, 152, 219), // Azul moderno
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8,
                    MarkerColor = Color.White,
                    MarkerBorderColor = Color.FromArgb(41, 128, 185),
                    MarkerBorderWidth = 2,
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    IsValueShownAsLabel = true
                };

                // 7️⃣ Agregar los puntos con etiquetas balanceadas
                for (int i = 0; i < etiquetasMeses.Length; i++)
                {
                    int index = serie.Points.AddXY(i, totales[i]);
                    double valor = totales[i];
                    string etiqueta = $"${valor:N0}";

                    // Evita saturar etiquetas en gráficos con muchos meses
                    if (etiquetasMeses.Length > 8 && i % 2 != 0)
                        etiqueta = ""; // oculta una de cada dos etiquetas

                    serie.Points[index].Label = etiqueta;
                    serie.Points[index].LabelForeColor = Color.FromArgb(50, 50, 50);
                }

                chartVentasMensuales.Series.Add(serie);

                // 8️⃣ Etiquetas personalizadas eje X
                area.AxisX.CustomLabels.Clear();
                for (int i = 0; i < etiquetasMeses.Length; i++)
                {
                    double pos = i;
                    area.AxisX.CustomLabels.Add(pos - 0.5, pos + 0.5, etiquetasMeses[i]);
                }

                // 9️⃣ Apariencia general
                chartVentasMensuales.BackColor = Color.White;
                chartVentasMensuales.BorderlineColor = Color.FromArgb(220, 220, 220);
                chartVentasMensuales.BorderlineDashStyle = ChartDashStyle.Solid;
                chartVentasMensuales.BorderlineWidth = 1;

                // 10️⃣ Título principal elegante
                Title title = new Title("Tendencia Mensual de Ventas",
                    Docking.Top,
                    new Font("Segoe UI", 9, FontStyle.Bold),
                    Color.FromArgb(35, 35, 35))
                {
                    Alignment = ContentAlignment.TopCenter
                };
                chartVentasMensuales.Titles.Add(title);

                // 11️⃣ Leyenda minimalista
                Legend legend = new Legend("MainLegend")
                {
                    Docking = Docking.Bottom,
                    Alignment = StringAlignment.Center,
                    Font = new Font("Segoe UI", 9),
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(70, 70, 70),
                    BorderColor = Color.Transparent
                };
                chartVentasMensuales.Legends.Add(legend);

                // 12️⃣ Refrescar gráfico
                chartVentasMensuales.Invalidate();
                chartVentasMensuales.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al graficar ventas mensuales: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GraficarVentasPrincipal()
        {
            try
            {
                // 1️⃣ Obtener todas las ventas
                var ventas = _repoVentas.ObtenerTodas();

                if (ventas.Count == 0)
                {
                    MessageBox.Show("No hay ventas registradas para graficar.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2️⃣ Agrupar por mes y año
                var ventasPorMes = ventas
                    .Where(v => v.FechaVenta != null)
                    .GroupBy(v => new { v.FechaVenta.Value.Year, v.FechaVenta.Value.Month })
                    .Select(g => new
                    {
                        Fecha = new DateTime(g.Key.Year, g.Key.Month, 1),
                        Total = g.Sum(v => v.TotalFinal)
                    })
                    .OrderBy(x => x.Fecha)
                    .ToList();

                // 3️⃣ Preparar etiquetas y valores
                string[] etiquetasMeses = ventasPorMes
                    .Select(v => v.Fecha.ToString("MMM yy"))
                    .ToArray();

                double[] totales = ventasPorMes.Select(v => (double)v.Total).ToArray();

                // 4️⃣ Limpiar gráfico
                chartVentas.Series.Clear();
                chartVentas.ChartAreas.Clear();
                chartVentas.Titles.Clear();
                chartVentas.Legends.Clear();

                // 5️⃣ Configurar área del gráfico
                ChartArea area = new ChartArea("MainArea")
                {
                    BackColor = Color.White
                };

                area.AxisX.MajorGrid.LineColor = Color.FromArgb(235, 235, 235);
                area.AxisY.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);

                area.AxisX.Title = "Mes";
                area.AxisY.Title = "Total de Ventas ($)";
                area.AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                area.AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);

                area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                area.AxisX.LabelStyle.ForeColor = Color.FromArgb(60, 60, 60);
                area.AxisY.LabelStyle.ForeColor = Color.FromArgb(60, 60, 60);

                area.AxisX.Interval = 1;
                area.AxisX.LabelStyle.Angle = -30;
                area.AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont | LabelAutoFitStyles.StaggeredLabels;
                area.AxisX.IsLabelAutoFit = true;

                area.Position = new ElementPosition(5, 10, 90, 80);
                area.InnerPlotPosition = new ElementPosition(5, 0, 90, 90);

                chartVentas.ChartAreas.Add(area);

                // 6️⃣ Crear serie
                Series serie = new Series("Ventas")
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 3,
                    Color = Color.FromArgb(46, 204, 113), // Verde moderno
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8,
                    MarkerColor = Color.White,
                    MarkerBorderColor = Color.FromArgb(39, 174, 96),
                    MarkerBorderWidth = 2,
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    IsValueShownAsLabel = true
                };

                // 7️⃣ Agregar puntos
                for (int i = 0; i < etiquetasMeses.Length; i++)
                {
                    int index = serie.Points.AddXY(i, totales[i]);
                    double valor = totales[i];
                    string etiqueta = $"${valor:N0}";

                    if (etiquetasMeses.Length > 8 && i % 2 != 0)
                        etiqueta = "";

                    serie.Points[index].Label = etiqueta;
                    serie.Points[index].LabelForeColor = Color.FromArgb(50, 50, 50);
                }

                chartVentas.Series.Add(serie);

                // 8️⃣ Etiquetas eje X
                area.AxisX.CustomLabels.Clear();
                for (int i = 0; i < etiquetasMeses.Length; i++)
                {
                    double pos = i;
                    area.AxisX.CustomLabels.Add(pos - 0.5, pos + 0.5, etiquetasMeses[i]);
                }

                // 9️⃣ Apariencia general
                chartVentas.BackColor = Color.White;
                chartVentas.BorderlineColor = Color.FromArgb(220, 220, 220);
                chartVentas.BorderlineDashStyle = ChartDashStyle.Solid;
                chartVentas.BorderlineWidth = 1;

                // 🔟 Título
                Title title = new Title("Ventas Mensuales",
                    Docking.Top,
                    new Font("Segoe UI", 9, FontStyle.Bold),
                    Color.FromArgb(35, 35, 35))
                {
                    Alignment = ContentAlignment.TopCenter
                };
                chartVentas.Titles.Add(title);

                // 🔟 Leyenda
                Legend legend = new Legend("MainLegend")
                {
                    Docking = Docking.Bottom,
                    Alignment = StringAlignment.Center,
                    Font = new Font("Segoe UI", 9),
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(70, 70, 70),
                    BorderColor = Color.Transparent
                };
                chartVentas.Legends.Add(legend);

                // 🔟 Refrescar gráfico
                chartVentas.Invalidate();
                chartVentas.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al graficar las ventas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GraficarVentasPorUsuario()
        {
            // 1️⃣ Obtener cantidad de ventas por usuario (vendedor)
            var ventas = _repoVentas.ObtenerTodas()
                .GroupBy(v => v.Vendedor?.IdNavigation.Nombre ?? "Sin vendedor")
                .Select(g => new
                {
                    Usuario = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(x => x.Cantidad)
                .ToList();

            if (ventas.Count == 0)
            {
                MessageBox.Show("No hay ventas para graficar.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // --- limpiar chart ---
            chartVentasPorUsuario.Series.Clear();
            chartVentasPorUsuario.ChartAreas.Clear();
            chartVentasPorUsuario.Titles.Clear();
            chartVentasPorUsuario.Legends.Clear();

            // --- ChartArea ---
            var area = new ChartArea("MainArea")
            {
                BackColor = Color.White,
                Position = new ElementPosition(5, 5, 70, 90),
                InnerPlotPosition = new ElementPosition(10, 5, 80, 90)
            };
            chartVentasPorUsuario.ChartAreas.Add(area);

            // --- Serie tipo Pie ---
            var serie = new Series("VentasPorUsuario")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = false,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                BorderWidth = 1,
                BorderColor = Color.White
            };

            // --- Paleta moderna ---
            Color[] colores = new Color[]
            {
        Color.FromArgb(93, 173, 226),   // Azul
        Color.FromArgb(46, 204, 113),   // Verde
        Color.FromArgb(241, 196, 15),   // Amarillo
        Color.FromArgb(231, 76, 60),    // Rojo
        Color.FromArgb(155, 89, 182),   // Violeta
        Color.FromArgb(52, 152, 219),   // Celeste
        Color.FromArgb(230, 126, 34),   // Naranja
        Color.FromArgb(149, 165, 166),  // Gris
        Color.FromArgb(26, 188, 156),   // Turquesa
        Color.FromArgb(52, 73, 94)      // Azul oscuro
            };

            int totalVentas = ventas.Sum(x => x.Cantidad);

            // --- Añadir puntos ---
            for (int i = 0; i < ventas.Count; i++)
            {
                int idx = serie.Points.AddY(ventas[i].Cantidad);
                var punto = serie.Points[idx];

                punto.AxisLabel = ventas[i].Usuario;
                punto.LegendText = $"{ventas[i].Usuario} ({ventas[i].Cantidad})";
                punto.Color = colores[i % colores.Length];
                punto.Label = $"{(double)ventas[i].Cantidad / totalVentas:P1}";
                punto.LabelForeColor = Color.White;
                punto.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }

            // --- Estilo de la torta ---
            serie["PieLabelStyle"] = "Inside";
            serie["PieDrawingStyle"] = "SoftEdge";
            serie["PieStartAngle"] = "270";
            serie["CollectedThreshold"] = "2";
            serie["CollectedLabel"] = "Otros";
            serie["CollectedColor"] = "Gray";

            chartVentasPorUsuario.Series.Add(serie);

            // --- Leyenda ---
            var legend = new Legend("MainLegend")
            {
                Docking = Docking.Right,
                Alignment = StringAlignment.Near,
                LegendStyle = LegendStyle.Table,
                TableStyle = LegendTableStyle.Auto,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 9),
                IsTextAutoFit = false
            };
            chartVentasPorUsuario.Legends.Add(legend);
            serie.IsVisibleInLegend = true;

            // --- Título ---
            chartVentasPorUsuario.Titles.Add(new Title(
                "Ventas registradas por Usuario",
                Docking.Top,
                new Font("Segoe UI", 11, FontStyle.Bold),
                Color.FromArgb(40, 40, 40)
            ));

            // --- Fondo general ---
            chartVentasPorUsuario.BackColor = Color.WhiteSmoke;
            chartVentasPorUsuario.Legends[0].MaximumAutoSize = 50;

            chartVentasPorUsuario.Invalidate();
        }
        private void GraficarVentasPorCliente()
        {
            try
            {
                // 1️⃣ Obtener todas las ventas agrupadas por cliente
                var ventasPorCliente = _repoVentas.ObtenerTodas()
                    .Where(v => v.Cliente != null)
                    .GroupBy(v => v.Cliente.IdNavigation.Nombre)
                    .Select(g => new
                    {
                        Cliente = g.Key,
                        TotalVendido = g.Sum(v => v.TotalFinal ?? v.Total)
                    })
                    .OrderByDescending(x => x.TotalVendido)
                    .ToList();

                if (ventasPorCliente.Count == 0)
                {
                    MessageBox.Show("No hay ventas registradas para graficar.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2️⃣ Limpiar gráfico
                chartVentasPorCliente.Series.Clear();
                chartVentasPorCliente.ChartAreas.Clear();
                chartVentasPorCliente.Titles.Clear();
                chartVentasPorCliente.Legends.Clear();

                // 3️⃣ Crear área principal
                ChartArea area = new ChartArea("MainArea")
                {
                    BackColor = Color.White
                };
                area.AxisX.MajorGrid.LineColor = Color.LightGray;
                area.AxisY.MajorGrid.Enabled = false;

                area.AxisX.Title = "Total Vendido ($)";
                area.AxisY.Title = "Cliente";

                area.AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                area.AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
                area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);

                chartVentasPorCliente.ChartAreas.Add(area);

                // 4️⃣ Crear la serie
                Series serie = new Series("VentasPorCliente")
                {
                    ChartType = SeriesChartType.Bar,
                    BorderWidth = 1,
                    Color = Color.FromArgb(52, 152, 219),
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    IsValueShownAsLabel = true
                };

                // 5️⃣ Cargar los datos en el gráfico
                foreach (var item in ventasPorCliente)
                {
                    int idx = serie.Points.AddXY(item.Cliente, item.TotalVendido);
                    serie.Points[idx].Label = $"$ {item.TotalVendido:N0}";
                    serie.Points[idx].Color = Color.FromArgb(93, 173, 226);
                }

                chartVentasPorCliente.Series.Add(serie);

                // 6️⃣ Ajustes visuales
                chartVentasPorCliente.BackColor = Color.WhiteSmoke;
                chartVentasPorCliente.BorderlineColor = Color.LightGray;
                chartVentasPorCliente.BorderlineDashStyle = ChartDashStyle.Solid;

                // 7️⃣ Título
                Title title = new Title("Total de Ventas por Cliente",
                    Docking.Top,
                    new Font("Segoe UI", 13, FontStyle.Bold),
                    Color.FromArgb(40, 40, 40));
                title.Alignment = ContentAlignment.TopCenter;
                chartVentasPorCliente.Titles.Add(title);

                // 8️⃣ Leyenda (opcional)
                Legend legend = new Legend("MainLegend")
                {
                    Docking = Docking.Bottom,
                    Alignment = StringAlignment.Center,
                    Font = new Font("Segoe UI", 9),
                    IsTextAutoFit = true
                };
                chartVentasPorCliente.Legends.Add(legend);

                // 9️⃣ Ajustar márgenes internos
                chartVentasPorCliente.ChartAreas[0].InnerPlotPosition = new ElementPosition(10, 5, 80, 90);

                // 🔟 Renderizar
                chartVentasPorCliente.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al graficar ventas por cliente: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GraficarTop5ClientesConMasCompras()
        {
            try
            {
                // 1️⃣ Obtener datos agrupados por cliente (total y cantidad)
                var ventas = _repoVentas.ObtenerTodas()
                    .GroupBy(v => v.Cliente.IdNavigation?.Nombre ?? "Sin cliente")
                    .Select(g => new
                    {
                        Cliente = g.Key,
                        TotalVentas = g.Sum(v => v.Total),
                        CantidadVentas = g.Count()
                    })
                    .OrderByDescending(x => x.TotalVentas)
                    .Take(5)
                    .ToList();

                if (ventas.Count == 0)
                {
                    MessageBox.Show("No hay ventas registradas para graficar.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2️⃣ Preparar nombres y valores
                string[] clientes = ventas
                    .Select(c => c.Cliente.Length > 20 ? c.Cliente.Substring(0, 20) + "…" : c.Cliente)
                    .ToArray();

                double[] totales = ventas.Select(c => (double)c.TotalVentas).ToArray();
                int[] cantidades = ventas.Select(c => c.CantidadVentas).ToArray();

                // 3️⃣ Limpiar gráfico
                chartVentasPorCliente.Series.Clear();
                chartVentasPorCliente.ChartAreas.Clear();
                chartVentasPorCliente.Titles.Clear();
                chartVentasPorCliente.Legends.Clear();

                // 4️⃣ Configurar área del gráfico
                ChartArea area = new ChartArea("MainArea");
                area.BackColor = Color.White;
                area.AxisX.MajorGrid.Enabled = false;
                area.AxisY.MajorGrid.LineColor = Color.LightGray;
                area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
                area.AxisX.Title = "Cliente";
                area.AxisY.Title = "Total de Ventas ($)";
                area.AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                area.AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
                area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);
                area.AxisX.Interval = 1;
                chartVentasPorCliente.ChartAreas.Add(area);

                // 5️⃣ Crear la serie
                Series serie = new Series("TopClientes")
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    BorderWidth = 0
                };

                // 6️⃣ Paleta de colores moderna
                Color[] colores = new Color[]
                {
            Color.FromArgb(52, 152, 219),
            Color.FromArgb(46, 204, 113),
            Color.FromArgb(231, 76, 60),
            Color.FromArgb(241, 196, 15),
            Color.FromArgb(155, 89, 182),
            Color.FromArgb(230, 126, 34),
            Color.FromArgb(26, 188, 156),
            Color.FromArgb(52, 73, 94)
                };

                // 7️⃣ Agregar barras y etiquetas personalizadas
                for (int i = 0; i < clientes.Length; i++)
                {
                    int index = serie.Points.AddXY(i, totales[i]);
                    serie.Points[index].Color = colores[i % colores.Length];
                    // Mostrar tanto el total como la cantidad
                    serie.Points[index].Label = $"$ {totales[i]:N0}\n({cantidades[i]} ventas)";
                }

                chartVentasPorCliente.Series.Add(serie);

                // 8️⃣ Etiquetas personalizadas en eje X
                area.AxisX.CustomLabels.Clear();
                for (int i = 0; i < clientes.Length; i++)
                {
                    double position = i;
                    area.AxisX.CustomLabels.Add(position - 0.5, position + 0.5, clientes[i]);
                }

                // 9️⃣ Estilos visuales
                serie["PointWidth"] = "0.6";
                serie["DrawingStyle"] = "Cylinder";
                chartVentasPorCliente.BackColor = Color.White;
                chartVentasPorCliente.BorderlineColor = Color.LightGray;
                chartVentasPorCliente.BorderlineDashStyle = ChartDashStyle.Solid;
                chartVentasPorCliente.BorderlineWidth = 1;

                // 🔟 Título
                Title title = new Title("Top 5 Clientes con Más Compras",
                    Docking.Top,
                    new Font("Segoe UI", 13, FontStyle.Bold),
                    Color.FromArgb(45, 45, 48));
                chartVentasPorCliente.Titles.Add(title);

                // 11️⃣ Refrescar
                chartVentasPorCliente.Invalidate();
                chartVentasPorCliente.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al graficar el Top 5 de clientes: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GraficarVentasPorCategoria()
        {
            using (var context = new SistemaVentasContext())
            {
                // 1) Traer ventas con detalle, producto y categoría
                var ventas = context.Ventas
                    .Include(v => v.DetalleVenta)
                        .ThenInclude(dv => dv.IdProductoNavigation)
                            .ThenInclude(p => p.IdCategoriaNavigation)
                    .ToList();

                // 2) Agrupar por categoría y contar cantidad total de productos vendidos
                var ventasPorCategoria = ventas
                    .SelectMany(v => v.DetalleVenta)
                    .Where(dv => dv.IdProductoNavigation != null && dv.IdProductoNavigation.IdCategoriaNavigation != null)
                    .GroupBy(dv => dv.IdProductoNavigation.IdCategoriaNavigation.Nombre)
                    .Select(g => new
                    {
                        Categoria = g.Key,
                        Cantidad = g.Sum(dv => dv.Cantidad) // cuenta unidades vendidas
                    })
                    .OrderByDescending(x => x.Cantidad)
                    .ToList();

                if (ventasPorCategoria.Count == 0)
                {
                    MessageBox.Show("No hay categorías con ventas registradas.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // --- limpiar chart ---
                chartVentasCategoria.Series.Clear();
                chartVentasCategoria.ChartAreas.Clear();
                chartVentasCategoria.Titles.Clear();
                chartVentasCategoria.Legends.Clear();

                // --- ChartArea ---
                var area = new ChartArea("MainArea")
                {
                    BackColor = Color.White,
                    Position = new ElementPosition(5, 5, 70, 90),
                    InnerPlotPosition = new ElementPosition(10, 5, 80, 90)
                };
                chartVentasCategoria.ChartAreas.Add(area);

                // --- Serie Pie ---
                var serie = new Series("VentasPorCategoria")
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = false,
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    BorderWidth = 1,
                    BorderColor = Color.White
                };

                // Colores modernos
                Color[] colores = new Color[]
                {
            Color.FromArgb(93, 173, 226),
            Color.FromArgb(46, 204, 113),
            Color.FromArgb(241, 196, 15),
            Color.FromArgb(231, 76, 60),
            Color.FromArgb(155, 89, 182),
            Color.FromArgb(230, 126, 34),
            Color.FromArgb(26, 188, 156),
            Color.FromArgb(52, 73, 94),
            Color.FromArgb(149, 165, 166)
                };

                int totalVentas = ventasPorCategoria.Sum(x => x.Cantidad);

                for (int i = 0; i < ventasPorCategoria.Count; i++)
                {
                    int idx = serie.Points.AddY(ventasPorCategoria[i].Cantidad);
                    var punto = serie.Points[idx];

                    punto.LegendText = $"{ventasPorCategoria[i].Categoria} ({ventasPorCategoria[i].Cantidad})";
                    punto.Color = colores[i % colores.Length];
                    punto.Label = $"{(double)ventasPorCategoria[i].Cantidad / totalVentas:P1}";
                    punto.LabelForeColor = Color.White;
                    punto.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }

                serie["PieLabelStyle"] = "Inside";
                serie["PieDrawingStyle"] = "SoftEdge";
                serie["PieStartAngle"] = "270";
                serie["CollectedThreshold"] = "2";
                serie["CollectedLabel"] = "Otros";
                serie["CollectedColor"] = "Gray";

                chartVentasCategoria.Series.Add(serie);

                // --- Leyenda ---
                var legend = new Legend("MainLegend")
                {
                    Docking = Docking.Right,
                    Alignment = StringAlignment.Near,
                    LegendStyle = LegendStyle.Table,
                    TableStyle = LegendTableStyle.Auto,
                    BackColor = Color.Transparent,
                    Font = new Font("Segoe UI", 9),
                    IsTextAutoFit = false
                };
                chartVentasCategoria.Legends.Add(legend);

                serie.IsVisibleInLegend = true;

                // --- Título ---
                chartVentasCategoria.Titles.Add(new Title(
                    "Cantidad de Ventas por Categoría",
                    Docking.Top,
                    new Font("Segoe UI", 11, FontStyle.Bold),
                    Color.FromArgb(40, 40, 40)
                ));

                chartVentasCategoria.BackColor = Color.WhiteSmoke;
                chartVentasCategoria.Legends[0].MaximumAutoSize = 50;
                chartVentasCategoria.Invalidate();
            }
        }

        private void GraficarVentasPorCategoriasTotalEnPrecio()
        {
            using (var context = new SistemaVentasContext())
            {
                // 1) Traer ventas con detalle, producto y categoría
                var ventas = context.Ventas
                    .Include(v => v.DetalleVenta)
                        .ThenInclude(dv => dv.IdProductoNavigation)
                            .ThenInclude(p => p.IdCategoriaNavigation)
                    .ToList();

                // 2) Agrupar por categoría y sumar el total vendido
                var ventasPorCategoria = ventas
                    .SelectMany(v => v.DetalleVenta)
                    .Where(dv => dv.IdProductoNavigation != null && dv.IdProductoNavigation.IdCategoriaNavigation != null)
                    .GroupBy(dv => dv.IdProductoNavigation.IdCategoriaNavigation.Nombre)
                    .Select(g => new
                    {
                        Categoria = g.Key,
                        Total = g.Sum(dv => dv.Subtotal)
                    })
                    .OrderByDescending(x => x.Total)
                    .ToList();

                if (ventasPorCategoria.Count == 0)
                {
                    MessageBox.Show("No hay categorías con ventas registradas.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // --- limpiar chart ---
                chartVentasCategoria.Series.Clear();
                chartVentasCategoria.ChartAreas.Clear();
                chartVentasCategoria.Titles.Clear();
                chartVentasCategoria.Legends.Clear();

                // --- ChartArea ---
                var area = new ChartArea("MainArea")
                {
                    BackColor = Color.White,
                    Position = new ElementPosition(5, 5, 70, 90),
                    InnerPlotPosition = new ElementPosition(10, 5, 80, 90)
                };
                chartVentasCategoria.ChartAreas.Add(area);

                // --- Serie Pie ---
                var serie = new Series("VentasPorCategoria")
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = false,
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    BorderWidth = 1,
                    BorderColor = Color.White
                };

                // Colores modernos
                Color[] colores = new Color[]
                {
            Color.FromArgb(93, 173, 226),
            Color.FromArgb(46, 204, 113),
            Color.FromArgb(241, 196, 15),
            Color.FromArgb(231, 76, 60),
            Color.FromArgb(155, 89, 182),
            Color.FromArgb(230, 126, 34),
            Color.FromArgb(26, 188, 156),
            Color.FromArgb(52, 73, 94),
            Color.FromArgb(149, 165, 166)
                };

                decimal totalVentas = ventasPorCategoria.Sum(x => x.Total);

                for (int i = 0; i < ventasPorCategoria.Count; i++)
                {
                    int idx = serie.Points.AddY(ventasPorCategoria[i].Total);
                    var punto = serie.Points[idx];

                    punto.LegendText = $"{ventasPorCategoria[i].Categoria} ({ventasPorCategoria[i].Total:C0})";
                    punto.Color = colores[i % colores.Length];
                    punto.Label = $"{(ventasPorCategoria[i].Total / totalVentas):P1}";
                    punto.LabelForeColor = Color.White;
                    punto.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }

                serie["PieLabelStyle"] = "Inside";
                serie["PieDrawingStyle"] = "SoftEdge";
                serie["PieStartAngle"] = "270";
                serie["CollectedThreshold"] = "2";
                serie["CollectedLabel"] = "Otros";
                serie["CollectedColor"] = "Gray";

                chartVentasCategoria.Series.Add(serie);

                // --- Leyenda ---
                var legend = new Legend("MainLegend")
                {
                    Docking = Docking.Right,
                    Alignment = StringAlignment.Near,
                    LegendStyle = LegendStyle.Table,
                    TableStyle = LegendTableStyle.Auto,
                    BackColor = Color.Transparent,
                    Font = new Font("Segoe UI", 9),
                    IsTextAutoFit = false
                };
                chartVentasCategoria.Legends.Add(legend);

                serie.IsVisibleInLegend = true;

                // --- Título ---
                chartVentasCategoria.Titles.Add(new Title(
                    "Ventas por Categoría",
                    Docking.Top,
                    new Font("Segoe UI", 11, FontStyle.Bold),
                    Color.FromArgb(40, 40, 40)
                ));

                chartVentasCategoria.BackColor = Color.WhiteSmoke;
                chartVentasCategoria.Legends[0].MaximumAutoSize = 50;
                chartVentasCategoria.Invalidate();
            }
        }

        private void TotalDinero_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarFiltroGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                // 🧭 Restaurar fechas por defecto
                fechaDesde.Value = DateTime.Today.AddMonths(-3);
                fechaHasta.Value = DateTime.Today;

                // 🔄 Recargar todos los datos completos
                CargarTotalesVentasYGanancias(); // sin parámetros => todas las ventas
                CargarCantidadVentas();
                CargarCantidadProductos();
                CargarCantidadClientes();

                MessageBox.Show("Filtros limpiados correctamente.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar los filtros: " + ex.Message);
            }
        }
    }
}


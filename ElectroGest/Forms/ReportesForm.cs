using ElectroGest.Datas;
using ElectroGest.Repositorios;
using ScottPlot;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private readonly RepositorioClientes _repoClientes;
        private readonly RepositorioVentas _repoVentas;
        public ReportesForm()
        {
            InitializeComponent();
            _repoCompras = new RepositorioCompra();
            _repoProductos = new RepositorioProductoProveedores();
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

            GraficarProductosPorProveedorConChart();
            GraficarProductosPorProveedorConChartEstadistica();


            CargarVentas();
            dgvCompras.CellContentClick -= dgvCompras_CellContentClick;


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
        private void CargarCantidadClientes()
        {
            try
            {
                // Trae la lista de clientes y cuenta los registros
                var clientes = _repoClientes.ObtenerClientes();
                int totalClientes = clientes.Count;

                // Muestra el número en el label
                CantidadClientes.Text = totalClientes.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al contar los clientes: " + ex.Message);
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
                        using (Brush b = new SolidBrush(Color.FromArgb(0, 153, 51))) // Azul moderno
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

        private void CargarVentas()
        {
            var ventas = _repoVentas.ObtenerTodas()
     .Select(v => new
     {
         v.Id,
         v.NumeroFactura,
         // 👇 Cliente: viene desde Cliente.IdNavigation (Persona)
         Cliente = v.Cliente != null && v.Cliente.IdNavigation != null
             ? $"{v.Cliente.IdNavigation.Nombre}"
             : "Sin cliente",

         // 👇 Vendedor: viene desde Usuario.IdNavigation (Persona)
         Vendedor = v.Vendedor != null && v.Vendedor.IdNavigation != null
             ? $"{v.Vendedor.IdNavigation.Nombre}"
             : "Sin vendedor",

         // 👇 Rol del vendedor (opcional)
         RolVendedor = v.Vendedor?.Rol?.Nombre ?? "Sin rol",

         // 👇 Supervisor: también desde Usuario.IdNavigation (Persona)
        // Supervisor = v.Supervisor != null && v.Supervisor.IdNavigation != null
          //   ? $"{v.Supervisor.IdNavigation.Nombre}"
            // : "—",

         Fecha = v.FechaVenta?.ToString("dd/MM/yyyy HH:mm") ?? "—",
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

            // Evitar agregar la columna del botón varias veces
            if (!dgvVentas.Columns.Contains("btnVerDetalle"))
            {
                // Crear la columna de botón
                DataGridViewButtonColumn btnVerDetalle = new DataGridViewButtonColumn();
                btnVerDetalle.Name = "btnVerDetalle";
                btnVerDetalle.HeaderText = "";
                btnVerDetalle.Text = "🔍 Ver Detalle";
                btnVerDetalle.UseColumnTextForButtonValue = true;
                btnVerDetalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvVentas.Columns.Add(btnVerDetalle);
            }

            // 🎨 Estilos del DataGridView (mismo estilo que Compras)
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

                        using (Brush b = new SolidBrush(Color.FromArgb(0, 153, 51))) // Verde moderno
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


    }
}


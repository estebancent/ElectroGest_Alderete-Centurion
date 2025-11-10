using ElectroGest.Models;
using ElectroGest.Repositorios;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Microsoft.EntityFrameworkCore;
using ScottPlot.Drawing.Colormaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;
using System.Globalization;

namespace ElectroGest.Forms
{
    public partial class FormFactura : Form
    {

        private int _idVenta;
        private readonly RepositorioVentas _repoVentas;

        private Venta _ventaActual;

        public FormFactura(int idVenta)
        {
            InitializeComponent();
            _idVenta = idVenta;
            _repoVentas = new RepositorioVentas();

            // CargarDatosFactura();
            CargarDetalleVenta();


        }

        private Button btnExportarPDF;

        private void FormFactura_Load(object sender, EventArgs e)
        {
            CargarFactura();
            CargarDetalleVenta();

        }
        private void CargarFactura()
        {
            _ventaActual = _repoVentas.ObtenerPorId(_idVenta);

            if (_ventaActual == null)
            {
                MessageBox.Show("No se encontró la venta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Cultura argentina para formato monetario
            var culturaAR = new CultureInfo("es-AR");
            // Mostrar encabezado
            lblNumeroFactura.Text = _ventaActual.NumeroFactura ?? "—";
            lblFecha.Text = _ventaActual.FechaVenta?.ToString("dd/MM/yyyy HH:mm") ?? "—";
            lblCliente.Text = $"{_ventaActual.Cliente.IdNavigation.Nombre} ";
            lblVendedor.Text = $"{_ventaActual.Vendedor.IdNavigation.Nombre} ";
            // lblSupervisor.Text = _ventaActual.Supervisor != null ? $"{_ventaActual.Supervisor.IdNavigation.Nombre}" : "—";
            lblEstado.Text = _ventaActual.Estado ?? "—";
            lblFormaPago.Text = _ventaActual.MetodoPago ?? "—";
            lblObservaciones.Text = _ventaActual.Observaciones ?? "Sin observaciones";
            lblTotal.Text = _ventaActual.Total.ToString("C", culturaAR);
            lblTotalFinal.Text = _ventaActual.TotalFinal?.ToString("C", culturaAR);

            // Cargar los detalles de la venta
            dgvDetalleVentas.DataSource = _ventaActual.DetalleVenta.Select(d => new
            {
                Producto = d.IdProductoNavigation.Nombre,
                Cantidad = d.Cantidad,
                PrecioUnitario = d.PrecioUnitario.ToString("C", culturaAR),
                Subtotal = d.Subtotal.ToString("C", culturaAR)
            }).ToList();


            // Estilo simple, sobrio y uniforme para el DataGridView
            dgvDetalleVentas.BorderStyle = BorderStyle.None;
            dgvDetalleVentas.BackgroundColor = Color.White;
            dgvDetalleVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleVentas.MultiSelect = false;
            dgvDetalleVentas.AllowUserToAddRows = false;
            dgvDetalleVentas.AllowUserToResizeRows = false;
            dgvDetalleVentas.RowHeadersVisible = false;

            // Encabezados (todos negros)
            dgvDetalleVentas.EnableHeadersVisualStyles = false;
            dgvDetalleVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDetalleVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvDetalleVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDetalleVentas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            dgvDetalleVentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Celdas
            dgvDetalleVentas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9);
            dgvDetalleVentas.DefaultCellStyle.BackColor = Color.White;
            dgvDetalleVentas.DefaultCellStyle.ForeColor = Color.Black;
            dgvDetalleVentas.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvDetalleVentas.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Filas alternadas (ligeramente diferenciadas)
            dgvDetalleVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);


        }

        private void BtnExportarPDF_Click(object sender, EventArgs e)
        {
            if (_ventaActual == null)
            {
                MessageBox.Show("Debe cargar una venta antes de exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                FileName = $"Factura_{_ventaActual.NumeroFactura}.pdf",
                Filter = "Archivos PDF (*.pdf)|*.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GenerarFacturaPDF(_ventaActual, saveFileDialog.FileName);
                    MessageBox.Show("Factura exportada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GenerarFacturaPDF(Venta venta, string rutaArchivo)
        {
            Document doc = new Document(PageSize.A4, 40, 40, 60, 40);
            PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
            doc.Open();

            // Fuentes
            var fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            var fuenteSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            var fuenteNormal = FontFactory.GetFont(FontFactory.HELVETICA, 10);

            var culturaAR = new CultureInfo("es-AR");

            // Encabezado
            Paragraph titulo = new Paragraph("FACTURA DE VENTA", fuenteTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph($"Fecha: {venta.FechaVenta:dd/MM/yyyy HH:mm}", fuenteNormal));
            doc.Add(new Paragraph($"Número de factura: {venta.NumeroFactura}", fuenteNormal));
            doc.Add(new Paragraph($"Cliente: {venta.Cliente.IdNavigation.Nombre} ", fuenteNormal));
            doc.Add(new Paragraph($"Vendedor: {venta.Vendedor.IdNavigation.Nombre} ", fuenteNormal));
            doc.Add(new Paragraph($"Forma de Pago: {venta.MetodoPago}", fuenteNormal));
            doc.Add(new Paragraph(" "));
            doc.Add(new LineSeparator(1f, 100f, BaseColor.GRAY, Element.ALIGN_CENTER, -2));

            // Detalles
            doc.Add(new Paragraph("Detalles de productos", fuenteSubtitulo));
            doc.Add(new Paragraph(" "));

            PdfPTable tabla = new PdfPTable(4);
            tabla.WidthPercentage = 100;
            tabla.SetWidths(new float[] { 40, 20, 20, 20 });

            // Encabezados
            tabla.AddCell(new PdfPCell(new Phrase("Producto", fuenteSubtitulo)) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tabla.AddCell(new PdfPCell(new Phrase("Cantidad", fuenteSubtitulo)) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tabla.AddCell(new PdfPCell(new Phrase("Precio Unitario", fuenteSubtitulo)) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tabla.AddCell(new PdfPCell(new Phrase("Subtotal", fuenteSubtitulo)) { BackgroundColor = BaseColor.LIGHT_GRAY });

            foreach (var d in venta.DetalleVenta)
            {
                tabla.AddCell(new Phrase(d.IdProductoNavigation.Nombre, fuenteNormal));
                tabla.AddCell(new Phrase(d.Cantidad.ToString(), fuenteNormal));
                tabla.AddCell(new Phrase(d.PrecioUnitario.ToString("C", culturaAR), fuenteNormal));
                tabla.AddCell(new Phrase(d.Subtotal.ToString("C", culturaAR), fuenteNormal));
            }

            doc.Add(tabla);
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph($"Total: {venta.TotalFinal?.ToString("C", culturaAR)}", fuenteSubtitulo));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph($"Observaciones: {venta.Observaciones ?? "—"}", fuenteNormal));

            doc.Close();
        }

        private void CargarDetalleVenta()
        {
            using (var context = new SistemaVentasContext())
            {
                var detalles = context.DetalleVenta
                    .Include(d => d.IdProductoNavigation)
                    .Where(d => d.IdVenta == _idVenta)
                    .Select(d => new
                    {
                        Producto = d.IdProductoNavigation.Nombre,
                        d.Cantidad,
                        PrecioUnitario = d.PrecioUnitario,
                        Subtotal = d.Subtotal
                    })
                    .ToList();

                dgvDetalleVentas.AutoGenerateColumns = true;
                dgvDetalleVentas.DataSource = detalles;

                // Formato visual
                // Asegurate de estar en un Form (WinForms)
                dgvDetalleVentas.EnableHeadersVisualStyles = false;
                dgvDetalleVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
                dgvDetalleVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                // 👇 Especificá que es System.Drawing.Font
                dgvDetalleVentas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);

                dgvDetalleVentas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9);
                dgvDetalleVentas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 144, 255);
                dgvDetalleVentas.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvDetalleVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                dgvDetalleVentas.RowsDefaultCellStyle.BackColor = Color.White;

            }
        }

        private void lblVendedor_Click(object sender, EventArgs e)
        {

        }
    }
}

using ElectroGest.Datas;
using ElectroGest.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;


namespace ElectroGest.Forms
{
    public partial class BackupForm : Form
    {
        private Usuario _usuarioActual;
        private readonly RepositorioBackup _repoBackup;
        public BackupForm()
        {
            InitializeComponent();
            _usuarioActual = Utils.Sesion.UsuarioActual;
             _repoBackup = new RepositorioBackup();
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            _usuarioActual = Utils.Sesion.UsuarioActual;

            dgvHistorialBackups.AutoGenerateColumns = false;
            dgvHistorialBackups.Columns.Clear();

            dgvHistorialBackups.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Fecha",
                HeaderText = "Fecha/Hora",
                DataPropertyName = "Fecha"
            });
            dgvHistorialBackups.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Archivo",
                HeaderText = "Archivo",
                DataPropertyName = "Archivo"
            });
            dgvHistorialBackups.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Ubicacion",
                HeaderText = "Ubicación",
                DataPropertyName = "Ubicacion"
            });
            dgvHistorialBackups.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Usuario",
                HeaderText = "Usuario",
                DataPropertyName = "Usuario"
            });
            dgvHistorialBackups.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Tamano",
                HeaderText = "Tamaño (MB)",
                DataPropertyName = "Tamano"
            });
            dgvHistorialBackups.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Observaciones",
                HeaderText = "Observaciones",
                DataPropertyName = "Observaciones"
            });

            dgvHistorialBackups.ReadOnly = true;
            dgvHistorialBackups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialBackups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EstilizarDataGridView();

            CargarHistorial();
        }





        private void btnExaminar_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtRuta.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnGenerarBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRuta.Text))
                {
                    MessageBox.Show("Seleccioná una carpeta de destino.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔹 Datos del backup
                string baseDatos = "SistemaVentas"; 
                string fecha = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string nombreArchivo = $"{baseDatos}_{fecha}.bak";
                string rutaCompleta = Path.Combine(txtRuta.Text, nombreArchivo);

                // 🔹 Generar backup con SQL
                var context = new SistemaVentasContext();
                string connectionString = context.Database.GetConnectionString();

                string query = $@"BACKUP DATABASE [{baseDatos}] TO DISK = '{rutaCompleta}'";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // 🔹 Obtener tamaño del archivo
                FileInfo fileInfo = new FileInfo(rutaCompleta);
                decimal tamanioMB = fileInfo.Length / 1024m / 1024m;

                // 🔹 Registrar backup en la base de datos
                var backup = new BackupHistorial
                {
                    NombreArchivo = nombreArchivo,
                    RutaDestino = rutaCompleta,
                    IdUsuario = _usuarioActual?.Id, // si no hay sesión, queda null
                    TamanoMb = tamanioMB,
                    Observaciones = "Backup manual generado por el usuario."
                };

                _repoBackup.RegistrarBackup(backup);

                // 🔹 Recargar historial
                CargarHistorial();

                MessageBox.Show("Backup generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar el backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarHistorial()
        {
            try
            {
                var historial = _repoBackup.ObtenerHistorial()
                    .Select(b => new
                    {
                        Fecha = b.FechaBackup?.ToString("dd/MM/yyyy HH:mm"),
                        Archivo = b.NombreArchivo,
                        Ubicacion = b.RutaDestino,
                        Usuario = b.IdUsuarioNavigation?.IdNavigation?.Nombre ?? "Desconocido",
                        Tamano = $"{b.TamanoMb:N2} MB",
                        Observaciones = b.Observaciones
                    })
                    .ToList();

                dgvHistorialBackups.DataSource = historial;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial: " + ex.Message);
            }
        }
        private void EstilizarDataGridView()
        {
            // 🔹 Colores base
            dgvHistorialBackups.BackgroundColor = Color.FromArgb(245, 245, 245);
            dgvHistorialBackups.BorderStyle = BorderStyle.None;
            dgvHistorialBackups.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistorialBackups.GridColor = Color.LightGray;

            // 🔹 Encabezados
            dgvHistorialBackups.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvHistorialBackups.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistorialBackups.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvHistorialBackups.EnableHeadersVisualStyles = false;
           // dgvHistorialBackups.ColumnHeadersHeight = 35;

            // 🔹 Filas
            dgvHistorialBackups.DefaultCellStyle.BackColor = Color.White;
            dgvHistorialBackups.DefaultCellStyle.ForeColor = Color.Black;
            dgvHistorialBackups.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvHistorialBackups.DefaultCellStyle.SelectionBackColor = Color.FromArgb(93, 173, 226);
            dgvHistorialBackups.DefaultCellStyle.SelectionForeColor = Color.White;

            // 🔹 Alternancia de color de filas
            dgvHistorialBackups.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);

            // 🔹 Sin bordes de encabezado de fila
            dgvHistorialBackups.RowHeadersVisible = false;

            // 🔹 Modo de selección
            dgvHistorialBackups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // 🔹 Mostrar color de fondo completo, incluso sin registros
            dgvHistorialBackups.RowsDefaultCellStyle.BackColor = Color.White;
            dgvHistorialBackups.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(93, 173, 226);
            dgvHistorialBackups.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            // 🔹 Para mantener fondo uniforme si no hay filas
            dgvHistorialBackups.BackgroundColor = Color.White;
        }


    }
}

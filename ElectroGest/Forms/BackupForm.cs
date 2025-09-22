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
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            // Configurar columnas
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Fecha/Hora";
            dataGridView1.Columns[1].Name = "Archivo";
            dataGridView1.Columns[2].Name = "Ubicación";
            dataGridView1.Columns[3].Name = "Usuario";

            // Opciones de estilo
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cargar datos estáticos de ejemplo
            dataGridView1.Rows.Add("21/09/2025 12:30", "backup_210925.bak", @"C:\Backups\", "admin");
            dataGridView1.Rows.Add("20/09/2025 18:15", "backup_200925.bak", @"D:\Resguardos\", "soporte");
            dataGridView1.Rows.Add("19/09/2025 09:50", "backup_190925.bak", @"C:\Backups\", "usuario1");
        }


    }
}

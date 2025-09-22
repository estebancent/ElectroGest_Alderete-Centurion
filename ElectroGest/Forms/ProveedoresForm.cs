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
    public partial class ProveedoresForm : Form
    {
        public ProveedoresForm()
        {
            InitializeComponent();
        }

        
            private void ProveedoresForm_Load(object sender, EventArgs e)
        {
            // Configurar columnas
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Nombre";
            dataGridView1.Columns[1].Name = "CUIT/DNI";
            dataGridView1.Columns[2].Name = "Teléfono";
            dataGridView1.Columns[3].Name = "Email";

            // Opciones de estilo
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Datos de ejemplo (proveedores tecnológicos / fabricantes)
            dataGridView1.Rows.Add("Tech Solutions S.A.", "30-11223344-5", "011-4567-8901", "contacto@techsolutions.com");
            dataGridView1.Rows.Add("Hardware Global SRL", "30-22334455-6", "011-4789-5623", "ventas@hardwareglobal.com");
            dataGridView1.Rows.Add("Distribuidora Compumax", "30-33445566-7", "011-5678-1234", "info@compumax.com");
            dataGridView1.Rows.Add("ElectroParts Factory", "30-44556677-8", "011-4321-8765", "soporte@electroparts.com");
            dataGridView1.Rows.Add("Innova Tech Fabricantes", "30-55667788-9", "011-5234-9988", "proveedores@innovatech.com");
        }

    }
}


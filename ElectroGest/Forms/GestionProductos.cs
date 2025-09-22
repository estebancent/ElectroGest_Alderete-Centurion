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
    public partial class GestionProductos : Form
    {
        public GestionProductos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<string> errores = new List<string>();

            // Nombre
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                errores.Add("El campo Nombre es obligatorio.");
            }

            // Código de producto
            if (string.IsNullOrWhiteSpace(tbCodProd.Text))
            {
                errores.Add("El campo Código de Producto es obligatorio.");
            }

            // Precio Compra
            if (string.IsNullOrWhiteSpace(tbPrecioCompra.Text) ||
                !decimal.TryParse(tbPrecioCompra.Text, out decimal precioCompra) || precioCompra < 0)
            {
                errores.Add("El campo Precio de Compra es obligatorio y debe ser un número mayor o igual a 0.");
            }

            // Precio Venta
            if (string.IsNullOrWhiteSpace(tbPrecioVenta.Text) ||
                !decimal.TryParse(tbPrecioVenta.Text, out decimal precioVenta) || precioVenta < 0)
            {
                errores.Add("El campo Precio de Venta es obligatorio y debe ser un número mayor o igual a 0.");
            }

            // Stock
            if (string.IsNullOrWhiteSpace(tbStock.Text) ||
                !int.TryParse(tbStock.Text, out int stock) || stock < 0)
            {
                errores.Add("El campo Stock es obligatorio y debe ser un número mayor o igual a 0.");
            }

            // Marca
            if (string.IsNullOrWhiteSpace(tbMarca.Text))
            {
                errores.Add("El campo Marca es obligatorio.");
            }

            // Mostrar errores si existen
            if (errores.Count > 0)
            {
                string mensaje = string.Join("\n- ", errores);
                MessageBox.Show("Se encontraron los siguientes errores:\n- " + mensaje, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si todo es válido
            MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Aquí iría la lógica para guardar el producto en la base de datos
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBusquedaProd.Text))
            {
                MessageBox.Show("Por favor ingrese el codigo de producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBusquedaProd.Focus();
                return;
            }

        }

        private void tbPrecioCompra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

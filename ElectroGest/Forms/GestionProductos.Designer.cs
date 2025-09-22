namespace ElectroGest.Forms
{
    partial class GestionProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionProductos));
            groupBox1 = new GroupBox();
            btnProbar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            tbMarca = new TextBox();
            label9 = new Label();
            label7 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            tbPrecioCompra = new TextBox();
            tbNombre = new TextBox();
            tbStock = new TextBox();
            tbPrecioVenta = new TextBox();
            tbCodProd = new TextBox();
            tbBusquedaProd = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            CodProd = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            precioCompra = new DataGridViewTextBoxColumn();
            precioVenta = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            comboBox2 = new ComboBox();
            label8 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnProbar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(tbMarca);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(tbPrecioCompra);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(tbStock);
            groupBox1.Controls.Add(tbPrecioVenta);
            groupBox1.Controls.Add(tbCodProd);
            groupBox1.Controls.Add(tbBusquedaProd);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(570, 272);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Producto";
            // 
            // btnProbar
            // 
            btnProbar.BackColor = Color.FromArgb(192, 192, 255);
            btnProbar.FlatAppearance.BorderSize = 0;
            btnProbar.FlatStyle = FlatStyle.Flat;
            btnProbar.Location = new Point(403, 217);
            btnProbar.Name = "btnProbar";
            btnProbar.Size = new Size(75, 34);
            btnProbar.TabIndex = 20;
            btnProbar.Text = "Refresh";
            btnProbar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.BurlyWood;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(306, 217);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 34);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(207, 217);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 34);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Goldenrod;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(110, 217);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(91, 34);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkSeaGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(13, 217);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(91, 34);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbMarca
            // 
            tbMarca.Location = new Point(370, 106);
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(181, 23);
            tbMarca.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(297, 114);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 19;
            label9.Text = "Marca";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 174);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 14;
            label7.Text = "Stock disponible";
            // 
            // button1
            // 
            button1.Location = new Point(306, 14);
            button1.Name = "button1";
            button1.Size = new Size(88, 23);
            button1.TabIndex = 13;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(370, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(181, 23);
            comboBox1.TabIndex = 12;
            // 
            // tbPrecioCompra
            // 
            tbPrecioCompra.Location = new Point(110, 106);
            tbPrecioCompra.Name = "tbPrecioCompra";
            tbPrecioCompra.Size = new Size(181, 23);
            tbPrecioCompra.TabIndex = 11;
            tbPrecioCompra.TextChanged += tbPrecioCompra_TextChanged;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(370, 72);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(181, 23);
            tbNombre.TabIndex = 10;
            // 
            // tbStock
            // 
            tbStock.Location = new Point(110, 174);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(181, 23);
            tbStock.TabIndex = 9;
            // 
            // tbPrecioVenta
            // 
            tbPrecioVenta.Location = new Point(110, 140);
            tbPrecioVenta.Name = "tbPrecioVenta";
            tbPrecioVenta.Size = new Size(181, 23);
            tbPrecioVenta.TabIndex = 8;
            // 
            // tbCodProd
            // 
            tbCodProd.Location = new Point(110, 72);
            tbCodProd.Name = "tbCodProd";
            tbCodProd.Size = new Size(181, 23);
            tbCodProd.TabIndex = 7;
            // 
            // tbBusquedaProd
            // 
            tbBusquedaProd.Location = new Point(110, 14);
            tbBusquedaProd.Name = "tbBusquedaProd";
            tbBusquedaProd.PlaceholderText = "Ingrese codigo de producto";
            tbBusquedaProd.Size = new Size(181, 23);
            tbBusquedaProd.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 22);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 5;
            label6.Text = "Buscar producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 148);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 143);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 114);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 80);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 80);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo producto";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CodProd, NombreProducto, Stock, precioCompra, precioVenta, Categoria });
            dataGridView1.Location = new Point(12, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1107, 322);
            dataGridView1.TabIndex = 0;
            // 
            // CodProd
            // 
            CodProd.HeaderText = "Codigo producto";
            CodProd.Name = "CodProd";
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.Name = "NombreProducto";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            // 
            // precioCompra
            // 
            precioCompra.HeaderText = "Precio Compra";
            precioCompra.Name = "precioCompra";
            // 
            // precioVenta
            // 
            precioVenta.HeaderText = "Precio Venta";
            precioVenta.Name = "precioVenta";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(844, 276);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(181, 23);
            comboBox2.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(728, 284);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 13;
            label8.Text = "Filtrar por categoria";
            // 
            // button2
            // 
            button2.Location = new Point(1031, 276);
            button2.Name = "button2";
            button2.Size = new Size(88, 23);
            button2.TabIndex = 19;
            button2.Text = "Filtrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // GestionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1160, 653);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "GestionProductos";
            Text = "GestionProductos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox tbPrecioCompra;
        private TextBox tbNombre;
        private TextBox tbStock;
        private TextBox tbPrecioVenta;
        private TextBox tbCodProd;
        private TextBox tbBusquedaProd;
        private Label label7;
        private DataGridViewTextBoxColumn CodProd;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn precioCompra;
        private DataGridViewTextBoxColumn precioVenta;
        private DataGridViewTextBoxColumn Categoria;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnProbar;
        private TextBox tbMarca;
        private Label label9;
        private ComboBox comboBox2;
        private Label label8;
        private Button button2;
    }
}
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            checkActivo = new CheckBox();
            lblStock = new Label();
            tbNombre = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            label6 = new Label();
            tbPrecioCompra = new TextBox();
            btnPrecioVenta = new Button();
            tbMargen = new TextBox();
            label4 = new Label();
            tbPrecioVenta = new TextBox();
            label12 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnCompras = new Button();
            btnProbar = new Button();
            tbDescripcion = new TextBox();
            comboBoxMarcas = new ComboBox();
            btnAgregarCategoria = new Button();
            btnAgregaMarca = new Button();
            label9 = new Label();
            comboBoxCategorias = new ComboBox();
            tbCodProd = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBuscar = new Button();
            txtBusquedaProducto = new TextBox();
            comboBoxCategoria = new ComboBox();
            comboBoxMarca = new ComboBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            picProducto = new PictureBox();
            btnCargarImagen = new Button();
            btnExportarPdf = new Button();
            btnExportarExcel = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvProductos = new DataGridView();
            lblTitulo = new Label();
            txtUrlImagen = new TextBox();
            btnLimpiarFiltros = new Button();
            btnFiltrar = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProducto).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkActivo);
            groupBox1.Controls.Add(lblStock);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(tbDescripcion);
            groupBox1.Controls.Add(comboBoxMarcas);
            groupBox1.Controls.Add(btnAgregarCategoria);
            groupBox1.Controls.Add(btnAgregaMarca);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(comboBoxCategorias);
            groupBox1.Controls.Add(tbCodProd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(635, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Producto";
            // 
            // checkActivo
            // 
            checkActivo.AutoSize = true;
            checkActivo.FlatAppearance.BorderSize = 5;
            checkActivo.FlatAppearance.CheckedBackColor = Color.Green;
            checkActivo.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            checkActivo.Location = new Point(10, 197);
            checkActivo.Name = "checkActivo";
            checkActivo.Size = new Size(60, 19);
            checkActivo.TabIndex = 33;
            checkActivo.Text = "Activo";
            checkActivo.UseVisualStyleBackColor = true;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.Teal;
            lblStock.Location = new Point(80, 193);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(0, 21);
            lblStock.TabIndex = 31;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(80, 64);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(236, 23);
            tbNombre.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tbPrecioCompra);
            panel1.Controls.Add(btnPrecioVenta);
            panel1.Controls.Add(tbMargen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbPrecioVenta);
            panel1.Location = new Point(322, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 96);
            panel1.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 16);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio compra:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 40);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 34;
            label6.Text = "Ganancia:";
            // 
            // tbPrecioCompra
            // 
            tbPrecioCompra.Location = new Point(97, 13);
            tbPrecioCompra.Name = "tbPrecioCompra";
            tbPrecioCompra.Size = new Size(181, 23);
            tbPrecioCompra.TabIndex = 11;
            tbPrecioCompra.TextChanged += tbPrecioCompra_TextChanged;
            // 
            // btnPrecioVenta
            // 
            btnPrecioVenta.BackColor = Color.Transparent;
            btnPrecioVenta.FlatAppearance.BorderSize = 0;
            btnPrecioVenta.FlatStyle = FlatStyle.Flat;
            btnPrecioVenta.Image = (Image)resources.GetObject("btnPrecioVenta.Image");
            btnPrecioVenta.Location = new Point(58, 58);
            btnPrecioVenta.Name = "btnPrecioVenta";
            btnPrecioVenta.Size = new Size(28, 23);
            btnPrecioVenta.TabIndex = 29;
            btnPrecioVenta.TextAlign = ContentAlignment.MiddleRight;
            btnPrecioVenta.UseVisualStyleBackColor = false;
            // 
            // tbMargen
            // 
            tbMargen.Location = new Point(8, 59);
            tbMargen.Name = "tbMargen";
            tbMargen.Size = new Size(44, 23);
            tbMargen.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 61);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio venta:";
            // 
            // tbPrecioVenta
            // 
            tbPrecioVenta.Location = new Point(167, 58);
            tbPrecioVenta.Name = "tbPrecioVenta";
            tbPrecioVenta.Size = new Size(111, 23);
            tbPrecioVenta.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 181);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 28;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAgregar);
            flowLayoutPanel1.Controls.Add(btnEditar);
            flowLayoutPanel1.Controls.Add(btnEliminar);
            flowLayoutPanel1.Controls.Add(btnLimpiar);
            flowLayoutPanel1.Controls.Add(btnCompras);
            flowLayoutPanel1.Controls.Add(btnProbar);
            flowLayoutPanel1.Location = new Point(5, 235);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(621, 46);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkSeaGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(3, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(91, 34);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Goldenrod;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(100, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(91, 34);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(197, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 34);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.BurlyWood;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(294, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 34);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.Teal;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Image = (Image)resources.GetObject("btnCompras.Image");
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(391, 3);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(127, 34);
            btnCompras.TabIndex = 21;
            btnCompras.Text = "Nueva compra";
            btnCompras.TextAlign = ContentAlignment.MiddleRight;
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnProbar
            // 
            btnProbar.BackColor = Color.FromArgb(192, 192, 255);
            btnProbar.FlatAppearance.BorderSize = 0;
            btnProbar.FlatStyle = FlatStyle.Flat;
            btnProbar.Image = (Image)resources.GetObject("btnProbar.Image");
            btnProbar.ImageAlign = ContentAlignment.MiddleLeft;
            btnProbar.Location = new Point(524, 3);
            btnProbar.Name = "btnProbar";
            btnProbar.Size = new Size(86, 34);
            btnProbar.TabIndex = 20;
            btnProbar.Text = "Refresh";
            btnProbar.TextAlign = ContentAlignment.MiddleRight;
            btnProbar.UseVisualStyleBackColor = false;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(10, 97);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.PlaceholderText = "*Descripcion del producto";
            tbDescripcion.Size = new Size(306, 84);
            tbDescripcion.TabIndex = 25;
            // 
            // comboBoxMarcas
            // 
            comboBoxMarcas.FormattingEnabled = true;
            comboBoxMarcas.Location = new Point(400, 68);
            comboBoxMarcas.Name = "comboBoxMarcas";
            comboBoxMarcas.Size = new Size(185, 23);
            comboBoxMarcas.TabIndex = 23;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.BackColor = Color.Transparent;
            btnAgregarCategoria.FlatAppearance.BorderSize = 0;
            btnAgregarCategoria.FlatStyle = FlatStyle.Flat;
            btnAgregarCategoria.Image = (Image)resources.GetObject("btnAgregarCategoria.Image");
            btnAgregarCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarCategoria.Location = new Point(591, 26);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(28, 23);
            btnAgregarCategoria.TabIndex = 22;
            btnAgregarCategoria.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarCategoria.UseVisualStyleBackColor = false;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // btnAgregaMarca
            // 
            btnAgregaMarca.BackColor = Color.Transparent;
            btnAgregaMarca.FlatAppearance.BorderSize = 0;
            btnAgregaMarca.FlatStyle = FlatStyle.Flat;
            btnAgregaMarca.Image = (Image)resources.GetObject("btnAgregaMarca.Image");
            btnAgregaMarca.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregaMarca.Location = new Point(591, 68);
            btnAgregaMarca.Name = "btnAgregaMarca";
            btnAgregaMarca.Size = new Size(28, 23);
            btnAgregaMarca.TabIndex = 21;
            btnAgregaMarca.TextAlign = ContentAlignment.MiddleRight;
            btnAgregaMarca.UseVisualStyleBackColor = false;
            btnAgregaMarca.Click += btnAgregaMarca_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(341, 71);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 19;
            label9.Text = "*Marca:";
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(400, 26);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(185, 23);
            comboBoxCategorias.TabIndex = 12;
            // 
            // tbCodProd
            // 
            tbCodProd.Location = new Point(80, 22);
            tbCodProd.Name = "tbCodProd";
            tbCodProd.Size = new Size(236, 23);
            tbCodProd.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 29);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 4;
            label5.Text = "*Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 69);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "*Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 25);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(190, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 23);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBusquedaProducto
            // 
            txtBusquedaProducto.Location = new Point(3, 3);
            txtBusquedaProducto.Name = "txtBusquedaProducto";
            txtBusquedaProducto.PlaceholderText = "Ingrese codigo de producto";
            txtBusquedaProducto.Size = new Size(181, 23);
            txtBusquedaProducto.TabIndex = 6;
            txtBusquedaProducto.TextChanged += txtBusquedaProducto_TextChanged;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(3, 3);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(181, 23);
            comboBoxCategoria.TabIndex = 14;
            comboBoxCategoria.Text = " Categoria";
            comboBoxCategoria.SelectedIndexChanged += comboBoxCategoria_SelectedIndexChanged;
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(190, 3);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(181, 23);
            comboBoxMarca.TabIndex = 21;
            comboBoxMarca.Text = " Marca";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(comboBoxCategoria);
            flowLayoutPanel2.Controls.Add(comboBoxMarca);
            flowLayoutPanel2.Location = new Point(311, 340);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(382, 30);
            flowLayoutPanel2.TabIndex = 27;
            // 
            // picProducto
            // 
            picProducto.Image = Properties.Resources.icons8_producto_100;
            picProducto.InitialImage = Properties.Resources.icons8_producto_100;
            picProducto.Location = new Point(665, 51);
            picProducto.Name = "picProducto";
            picProducto.Size = new Size(237, 221);
            picProducto.SizeMode = PictureBoxSizeMode.CenterImage;
            picProducto.TabIndex = 28;
            picProducto.TabStop = false;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.BackColor = Color.Transparent;
            btnCargarImagen.FlatAppearance.BorderSize = 0;
            btnCargarImagen.FlatStyle = FlatStyle.Flat;
            btnCargarImagen.Image = (Image)resources.GetObject("btnCargarImagen.Image");
            btnCargarImagen.ImageAlign = ContentAlignment.MiddleLeft;
            btnCargarImagen.Location = new Point(653, 295);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(40, 32);
            btnCargarImagen.TabIndex = 29;
            btnCargarImagen.TextAlign = ContentAlignment.MiddleRight;
            btnCargarImagen.UseVisualStyleBackColor = false;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // btnExportarPdf
            // 
            btnExportarPdf.Cursor = Cursors.Hand;
            btnExportarPdf.FlatAppearance.BorderSize = 0;
            btnExportarPdf.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExportarPdf.FlatStyle = FlatStyle.Flat;
            btnExportarPdf.Image = Properties.Resources.icons8_pdf_32;
            btnExportarPdf.Location = new Point(830, 340);
            btnExportarPdf.Name = "btnExportarPdf";
            btnExportarPdf.Size = new Size(30, 29);
            btnExportarPdf.TabIndex = 31;
            btnExportarPdf.UseVisualStyleBackColor = true;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Cursor = Cursors.Hand;
            btnExportarExcel.FlatAppearance.BorderSize = 0;
            btnExportarExcel.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExportarExcel.FlatStyle = FlatStyle.Flat;
            btnExportarExcel.Image = Properties.Resources.icons8_ms_excel_26;
            btnExportarExcel.Location = new Point(866, 341);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(31, 29);
            btnExportarExcel.TabIndex = 30;
            btnExportarExcel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(txtBusquedaProducto);
            flowLayoutPanel3.Controls.Add(btnBuscar);
            flowLayoutPanel3.Location = new Point(12, 340);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(293, 30);
            flowLayoutPanel3.TabIndex = 32;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 376);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(894, 265);
            tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvProductos);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(886, 237);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Productos ElectroGest Tecnologia";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 100, 150);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new Point(3, 3);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SteelBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvProductos.RowTemplate.DefaultCellStyle.BackColor = SystemColors.ActiveCaption;
            dgvProductos.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvProductos.Size = new Size(880, 231);
            dgvProductos.TabIndex = 20;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Teal;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(0, 20);
            lblTitulo.TabIndex = 36;
            // 
            // txtUrlImagen
            // 
            txtUrlImagen.Location = new Point(699, 301);
            txtUrlImagen.Name = "txtUrlImagen";
            txtUrlImagen.Size = new Size(207, 23);
            txtUrlImagen.TabIndex = 37;
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.BackColor = Color.Transparent;
            btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            btnLimpiarFiltros.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltros.Image = (Image)resources.GetObject("btnLimpiarFiltros.Image");
            btnLimpiarFiltros.Location = new Point(741, 338);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(34, 32);
            btnLimpiarFiltros.TabIndex = 38;
            btnLimpiarFiltros.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarFiltros.UseVisualStyleBackColor = false;
            btnLimpiarFiltros.Click += btnLimpiarFiltros_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.Transparent;
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Image = (Image)resources.GetObject("btnFiltrar.Image");
            btnFiltrar.Location = new Point(699, 338);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(36, 32);
            btnFiltrar.TabIndex = 39;
            btnFiltrar.TextAlign = ContentAlignment.MiddleRight;
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // GestionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1160, 653);
            Controls.Add(btnFiltrar);
            Controls.Add(btnLimpiarFiltros);
            Controls.Add(txtUrlImagen);
            Controls.Add(lblTitulo);
            Controls.Add(tabControl1);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(picProducto);
            Controls.Add(btnExportarPdf);
            Controls.Add(btnExportarExcel);
            Controls.Add(btnCargarImagen);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(groupBox1);
            Name = "GestionProductos";
            Text = "GestionProductos";
            Load += GestionProductos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProducto).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnBuscar;
        private ComboBox comboBoxCategorias;
        private TextBox tbPrecioCompra;
        private TextBox tbNombre;
        private TextBox tbPrecioVenta;
        private TextBox tbCodProd;
        private TextBox txtBusquedaProducto;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnProbar;
        private Label label9;
        private ComboBox comboBoxCategoria;
        private Button btnAgregaMarca;
        private Button btnAgregarCategoria;
        private ComboBox comboBoxMarcas;
        private TextBox tbDescripcion;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox comboBoxMarca;
        private Label label12;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox tbMargen;
        private Button btnPrecioVenta;
        private Button btnCompras;
        private PictureBox picProducto;
        private Button btnCargarImagen;
        private Button btnExportarPdf;
        private Button btnExportarExcel;
        private FlowLayoutPanel flowLayoutPanel3;
        private CheckBox checkActivo;
        private Label label6;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvProductos;
        private Label lblTitulo;
        private TextBox txtUrlImagen;
        private Button btnLimpiarFiltros;
        private Button btnFiltrar;
        private Label lblStock;
    }
}
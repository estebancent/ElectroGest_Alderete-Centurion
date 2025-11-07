namespace ElectroGest.Forms
{
    partial class FormRegistrarCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarCompra));
            panelSuperior = new Panel();
            label2 = new Label();
            btnAgregaMarca = new Button();
            txtProductoSeleccionado = new TextBox();
            txtFactura = new TextBox();
            btnBuscarProducto = new Button();
            label12 = new Label();
            cmbProveedor = new ComboBox();
            panelDetalles = new Panel();
            label1 = new Label();
            txtObservaciones = new TextBox();
            txtPrecioCompra = new TextBox();
            NumericCantidad = new NumericUpDown();
            label8 = new Label();
            txtMargen = new TextBox();
            btnPrecioVenta = new Button();
            txtPrecioVenta = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lblTotalCompra = new Label();
            dgvCarrito = new DataGridView();
            Total = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnFinalizarCompra = new Button();
            btnAgregarProducto = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnEliminarSeleccionado = new Button();
            txtNroCompra = new TextBox();
            panelSuperior.SuspendLayout();
            panelDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(txtNroCompra);
            panelSuperior.Controls.Add(label2);
            panelSuperior.Controls.Add(btnAgregaMarca);
            panelSuperior.Controls.Add(txtProductoSeleccionado);
            panelSuperior.Controls.Add(txtFactura);
            panelSuperior.Controls.Add(btnBuscarProducto);
            panelSuperior.Controls.Add(label12);
            panelSuperior.Controls.Add(cmbProveedor);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(923, 80);
            panelSuperior.TabIndex = 0;
            panelSuperior.Paint += panelSuperior_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 9);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 47;
            label2.Text = "Nro Compra:";
            label2.Click += label2_Click;
            // 
            // btnAgregaMarca
            // 
            btnAgregaMarca.BackColor = Color.Transparent;
            btnAgregaMarca.FlatAppearance.BorderSize = 0;
            btnAgregaMarca.FlatStyle = FlatStyle.Flat;
            btnAgregaMarca.Image = (Image)resources.GetObject("btnAgregaMarca.Image");
            btnAgregaMarca.Location = new Point(267, 34);
            btnAgregaMarca.Name = "btnAgregaMarca";
            btnAgregaMarca.Size = new Size(28, 23);
            btnAgregaMarca.TabIndex = 33;
            btnAgregaMarca.TextAlign = ContentAlignment.MiddleRight;
            btnAgregaMarca.UseVisualStyleBackColor = false;
            btnAgregaMarca.Click += btnAgregaMarca_Click;
            // 
            // txtProductoSeleccionado
            // 
            txtProductoSeleccionado.Location = new Point(357, 34);
            txtProductoSeleccionado.Name = "txtProductoSeleccionado";
            txtProductoSeleccionado.PlaceholderText = "seleccionar producto";
            txtProductoSeleccionado.Size = new Size(244, 23);
            txtProductoSeleccionado.TabIndex = 32;
            // 
            // txtFactura
            // 
            txtFactura.Location = new Point(357, 5);
            txtFactura.Name = "txtFactura";
            txtFactura.PlaceholderText = "FAC-00001";
            txtFactura.ReadOnly = true;
            txtFactura.Size = new Size(179, 23);
            txtFactura.TabIndex = 46;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(619, 25);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(121, 40);
            btnBuscarProducto.TabIndex = 31;
            btnBuscarProducto.Text = "Buscar Producto";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(4, 38);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 30;
            label12.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(82, 34);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(179, 23);
            cmbProveedor.TabIndex = 29;
            // 
            // panelDetalles
            // 
            panelDetalles.Controls.Add(label1);
            panelDetalles.Controls.Add(txtObservaciones);
            panelDetalles.Controls.Add(txtPrecioCompra);
            panelDetalles.Controls.Add(NumericCantidad);
            panelDetalles.Controls.Add(label8);
            panelDetalles.Controls.Add(txtMargen);
            panelDetalles.Controls.Add(btnPrecioVenta);
            panelDetalles.Controls.Add(txtPrecioVenta);
            panelDetalles.Controls.Add(label4);
            panelDetalles.Controls.Add(label3);
            panelDetalles.Dock = DockStyle.Top;
            panelDetalles.Location = new Point(0, 80);
            panelDetalles.Name = "panelDetalles";
            panelDetalles.Size = new Size(923, 80);
            panelDetalles.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(514, 6);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 48;
            label1.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(601, 4);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(274, 54);
            txtObservaciones.TabIndex = 47;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(102, 3);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(159, 23);
            txtPrecioCompra.TabIndex = 45;
            // 
            // NumericCantidad
            // 
            NumericCantidad.Location = new Point(419, 37);
            NumericCantidad.Name = "NumericCantidad";
            NumericCantidad.Size = new Size(66, 23);
            NumericCantidad.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(358, 41);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 39;
            label8.Text = "Cantidad";
            // 
            // txtMargen
            // 
            txtMargen.Location = new Point(15, 35);
            txtMargen.Name = "txtMargen";
            txtMargen.Size = new Size(44, 23);
            txtMargen.TabIndex = 38;
            // 
            // btnPrecioVenta
            // 
            btnPrecioVenta.BackColor = Color.Transparent;
            btnPrecioVenta.FlatAppearance.BorderSize = 0;
            btnPrecioVenta.FlatStyle = FlatStyle.Flat;
            btnPrecioVenta.Image = (Image)resources.GetObject("btnPrecioVenta.Image");
            btnPrecioVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrecioVenta.Location = new Point(65, 35);
            btnPrecioVenta.Name = "btnPrecioVenta";
            btnPrecioVenta.Size = new Size(28, 23);
            btnPrecioVenta.TabIndex = 37;
            btnPrecioVenta.TextAlign = ContentAlignment.MiddleRight;
            btnPrecioVenta.UseVisualStyleBackColor = false;
            btnPrecioVenta.Click += btnPrecioVenta_Click;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(171, 36);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(181, 23);
            txtPrecioVenta.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 41);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 34;
            label4.Text = "Precio venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 6);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 33;
            label3.Text = "Precio compra";
            // 
            // lblTotalCompra
            // 
            lblTotalCompra.AutoSize = true;
            lblTotalCompra.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCompra.Location = new Point(601, 421);
            lblTotalCompra.Name = "lblTotalCompra";
            lblTotalCompra.Size = new Size(0, 25);
            lblTotalCompra.TabIndex = 40;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Dock = DockStyle.Fill;
            dgvCarrito.Location = new Point(3, 3);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.Size = new Size(885, 190);
            dgvCarrito.TabIndex = 2;
            dgvCarrito.CellContentClick += dgvCarrito_CellContentClick;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 175);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(899, 224);
            tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvCarrito);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(891, 196);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Compras";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarCompra
            // 
            btnFinalizarCompra.BackColor = Color.FromArgb(50, 50, 80);
            btnFinalizarCompra.ForeColor = SystemColors.ButtonFace;
            btnFinalizarCompra.Image = (Image)resources.GetObject("btnFinalizarCompra.Image");
            btnFinalizarCompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizarCompra.Location = new Point(361, 3);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(173, 39);
            btnFinalizarCompra.TabIndex = 43;
            btnFinalizarCompra.Text = "Finalizar Compra";
            btnFinalizarCompra.UseVisualStyleBackColor = false;
            btnFinalizarCompra.Click += btnFinalizarCompra_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(50, 50, 80);
            btnAgregarProducto.ForeColor = SystemColors.ButtonFace;
            btnAgregarProducto.Image = (Image)resources.GetObject("btnAgregarProducto.Image");
            btnAgregarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarProducto.Location = new Point(3, 3);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(173, 39);
            btnAgregarProducto.TabIndex = 44;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAgregarProducto);
            flowLayoutPanel1.Controls.Add(btnEliminarSeleccionado);
            flowLayoutPanel1.Controls.Add(btnFinalizarCompra);
            flowLayoutPanel1.Location = new Point(19, 401);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(541, 51);
            flowLayoutPanel1.TabIndex = 45;
            // 
            // btnEliminarSeleccionado
            // 
            btnEliminarSeleccionado.BackColor = Color.FromArgb(100, 50, 80);
            btnEliminarSeleccionado.ForeColor = SystemColors.ButtonFace;
            btnEliminarSeleccionado.Image = (Image)resources.GetObject("btnEliminarSeleccionado.Image");
            btnEliminarSeleccionado.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarSeleccionado.Location = new Point(182, 3);
            btnEliminarSeleccionado.Name = "btnEliminarSeleccionado";
            btnEliminarSeleccionado.Size = new Size(173, 39);
            btnEliminarSeleccionado.TabIndex = 45;
            btnEliminarSeleccionado.Text = "Eliminar";
            btnEliminarSeleccionado.UseVisualStyleBackColor = false;
            btnEliminarSeleccionado.Click += btnEliminarSeleccionado_Click;
            // 
            // txtNroCompra
            // 
            txtNroCompra.Location = new Point(82, 6);
            txtNroCompra.Name = "txtNroCompra";
            txtNroCompra.ReadOnly = true;
            txtNroCompra.Size = new Size(92, 23);
            txtNroCompra.TabIndex = 48;
            // 
            // FormRegistrarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 468);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tabControl1);
            Controls.Add(lblTotalCompra);
            Controls.Add(panelDetalles);
            Controls.Add(panelSuperior);
            Name = "FormRegistrarCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrarCompra";
            Load += FormRegistrarCompra_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelDetalles.ResumeLayout(false);
            panelDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSuperior;
        private Panel panelDetalles;
        private Label label12;
        private ComboBox cmbProveedor;
        private TextBox txtProductoSeleccionado;
        private Button btnBuscarProducto;
        private Label label8;
        private TextBox txtMargen;
        private Button btnPrecioVenta;
        private TextBox txtPrecioVenta;
        private Label label4;
        private Label label3;
        private Label lblTotalCompra;
        private DataGridView dgvCarrito;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn Producto;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnFinalizarCompra;
        private NumericUpDown NumericCantidad;
        private Button btnAgregarProducto;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAgregaMarca;
        private TextBox txtPrecioCompra;
        private TextBox txtObservaciones;
        private TextBox txtFactura;
        private Button btnEliminarSeleccionado;
        private Label label2;
        private Label label1;
        private TextBox txtNroCompra;
    }
}
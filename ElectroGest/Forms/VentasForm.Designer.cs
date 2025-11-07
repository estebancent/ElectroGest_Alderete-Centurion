namespace ElectroGest.Forms
{
    partial class VentasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasForm));
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtObservaciones = new TextBox();
            btnLimpiarCliente = new Button();
            lblDireccionCliente = new Label();
            lblEmailCliente = new Label();
            lblDniCliente = new Label();
            lblTelefonoCliente = new Label();
            lblNombreCliente = new Label();
            btnNuevoCliente = new Button();
            LbBusqueda = new Label();
            btnBuscarCliente = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBuscarDni = new Button();
            txtDniBuscar = new TextBox();
            btnLimpiarProducto = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            label11 = new Label();
            btnCalcularTotalFinal = new Button();
            lblTotalFinal = new Label();
            lblNombreVendedorDetalle = new Label();
            lblNombreClienteDetalle = new Label();
            btnFinalizarVenta = new Button();
            lblTotalVenta = new Label();
            cmbMetodoPago = new ComboBox();
            label17 = new Label();
            label16 = new Label();
            txtRecargo = new TextBox();
            label15 = new Label();
            txtDescuento = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            lblTotal = new Label();
            dgvCarrito = new DataGridView();
            groupBox2 = new GroupBox();
            btnSeleccionarProducto = new Button();
            label19 = new Label();
            txtCodProd = new TextBox();
            txtCantidad = new TextBox();
            label18 = new Label();
            btnAgregarCarrito = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnBuscarProducto = new Button();
            txtCodProductoBuscar = new TextBox();
            txtPrecio = new TextBox();
            txtStockDisponible = new TextBox();
            txtNombreProducto = new TextBox();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            FechaVenta = new DataGridViewTextBoxColumn();
            TotalVenta = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            groupBox2.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtObservaciones);
            groupBox1.Controls.Add(btnLimpiarCliente);
            groupBox1.Controls.Add(lblDireccionCliente);
            groupBox1.Controls.Add(lblEmailCliente);
            groupBox1.Controls.Add(lblDniCliente);
            groupBox1.Controls.Add(lblTelefonoCliente);
            groupBox1.Controls.Add(lblNombreCliente);
            groupBox1.Controls.Add(btnNuevoCliente);
            groupBox1.Controls.Add(LbBusqueda);
            groupBox1.Controls.Add(btnBuscarCliente);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBuscarDni);
            groupBox1.Controls.Add(txtDniBuscar);
            groupBox1.Location = new Point(16, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1015, 146);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(583, 57);
            label6.Name = "label6";
            label6.Size = new Size(87, 17);
            label6.TabIndex = 22;
            label6.Text = "Observacion:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(583, 77);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(426, 52);
            txtObservaciones.TabIndex = 21;
            // 
            // btnLimpiarCliente
            // 
            btnLimpiarCliente.BackColor = Color.Transparent;
            btnLimpiarCliente.Cursor = Cursors.Hand;
            btnLimpiarCliente.FlatAppearance.BorderSize = 0;
            btnLimpiarCliente.Image = (Image)resources.GetObject("btnLimpiarCliente.Image");
            btnLimpiarCliente.Location = new Point(807, 14);
            btnLimpiarCliente.Name = "btnLimpiarCliente";
            btnLimpiarCliente.Size = new Size(40, 36);
            btnLimpiarCliente.TabIndex = 20;
            btnLimpiarCliente.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarCliente.UseVisualStyleBackColor = false;
            btnLimpiarCliente.Click += btnLimpiarCliente_Click;
            // 
            // lblDireccionCliente
            // 
            lblDireccionCliente.AutoSize = true;
            lblDireccionCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            lblDireccionCliente.Location = new Point(72, 112);
            lblDireccionCliente.Name = "lblDireccionCliente";
            lblDireccionCliente.Size = new Size(8, 17);
            lblDireccionCliente.TabIndex = 19;
            lblDireccionCliente.Text = "\r\n";
            // 
            // lblEmailCliente
            // 
            lblEmailCliente.AutoSize = true;
            lblEmailCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            lblEmailCliente.Location = new Point(320, 89);
            lblEmailCliente.Name = "lblEmailCliente";
            lblEmailCliente.Size = new Size(0, 17);
            lblEmailCliente.TabIndex = 18;
            // 
            // lblDniCliente
            // 
            lblDniCliente.AutoSize = true;
            lblDniCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            lblDniCliente.Location = new Point(46, 89);
            lblDniCliente.Name = "lblDniCliente";
            lblDniCliente.Size = new Size(8, 17);
            lblDniCliente.TabIndex = 17;
            lblDniCliente.Text = "\r\n";
            lblDniCliente.Click += lblDniCliente_Click;
            // 
            // lblTelefonoCliente
            // 
            lblTelefonoCliente.AutoSize = true;
            lblTelefonoCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            lblTelefonoCliente.Location = new Point(340, 57);
            lblTelefonoCliente.Name = "lblTelefonoCliente";
            lblTelefonoCliente.Size = new Size(0, 17);
            lblTelefonoCliente.TabIndex = 16;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            lblNombreCliente.Location = new Point(63, 57);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(0, 17);
            lblNombreCliente.TabIndex = 15;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.Transparent;
            btnNuevoCliente.Cursor = Cursors.Hand;
            btnNuevoCliente.FlatAppearance.BorderSize = 0;
            btnNuevoCliente.Image = (Image)resources.GetObject("btnNuevoCliente.Image");
            btnNuevoCliente.Location = new Point(853, 14);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(40, 36);
            btnNuevoCliente.TabIndex = 14;
            btnNuevoCliente.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // LbBusqueda
            // 
            LbBusqueda.AutoSize = true;
            LbBusqueda.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LbBusqueda.ForeColor = Color.FromArgb(64, 64, 64);
            LbBusqueda.Location = new Point(6, 26);
            LbBusqueda.Name = "LbBusqueda";
            LbBusqueda.Size = new Size(107, 17);
            LbBusqueda.TabIndex = 12;
            LbBusqueda.Text = "Ingrese Nro Dni:";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.BackColor = Color.LightGray;
            btnBuscarCliente.Cursor = Cursors.Hand;
            btnBuscarCliente.FlatAppearance.BorderSize = 0;
            btnBuscarCliente.Image = (Image)resources.GetObject("btnBuscarCliente.Image");
            btnBuscarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarCliente.Location = new Point(663, 14);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(138, 36);
            btnBuscarCliente.TabIndex = 13;
            btnBuscarCliente.Text = "Seleccionar Cliente";
            btnBuscarCliente.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(272, 57);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 10;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 9;
            label4.Text = "Direccion: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(272, 89);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 8;
            label3.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(6, 89);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 7;
            label2.Text = "DNI:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(6, 57);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.Cursor = Cursors.Hand;
            btnBuscarDni.Location = new Point(502, 21);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(75, 23);
            btnBuscarDni.TabIndex = 5;
            btnBuscarDni.Text = "Buscar";
            btnBuscarDni.UseVisualStyleBackColor = true;
            btnBuscarDni.Click += btnBuscarDni_Click;
            // 
            // txtDniBuscar
            // 
            txtDniBuscar.Location = new Point(136, 22);
            txtDniBuscar.Name = "txtDniBuscar";
            txtDniBuscar.PlaceholderText = "Ingrese DNI del cliente";
            txtDniBuscar.Size = new Size(360, 23);
            txtDniBuscar.TabIndex = 0;
            // 
            // btnLimpiarProducto
            // 
            btnLimpiarProducto.BackColor = Color.BurlyWood;
            btnLimpiarProducto.Cursor = Cursors.Hand;
            btnLimpiarProducto.FlatAppearance.BorderSize = 0;
            btnLimpiarProducto.FlatStyle = FlatStyle.Flat;
            btnLimpiarProducto.Image = (Image)resources.GetObject("btnLimpiarProducto.Image");
            btnLimpiarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarProducto.Location = new Point(838, 52);
            btnLimpiarProducto.Name = "btnLimpiarProducto";
            btnLimpiarProducto.Size = new Size(140, 34);
            btnLimpiarProducto.TabIndex = 16;
            btnLimpiarProducto.Text = "Limpiar Campos";
            btnLimpiarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarProducto.UseVisualStyleBackColor = false;
            btnLimpiarProducto.Click += btnLimpiarProducto_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1045, 644);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1037, 616);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registrar venta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(btnCalcularTotalFinal);
            groupBox3.Controls.Add(lblTotalFinal);
            groupBox3.Controls.Add(lblNombreVendedorDetalle);
            groupBox3.Controls.Add(lblNombreClienteDetalle);
            groupBox3.Controls.Add(btnFinalizarVenta);
            groupBox3.Controls.Add(lblTotalVenta);
            groupBox3.Controls.Add(cmbMetodoPago);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(txtRecargo);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(txtDescuento);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(lblTotal);
            groupBox3.Controls.Add(dgvCarrito);
            groupBox3.Location = new Point(16, 286);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1015, 324);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Venta";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(102, 281);
            label11.Name = "label11";
            label11.Size = new Size(101, 25);
            label11.TabIndex = 20;
            label11.Text = "Total Final:";
            // 
            // btnCalcularTotalFinal
            // 
            btnCalcularTotalFinal.Cursor = Cursors.Hand;
            btnCalcularTotalFinal.Location = new Point(6, 284);
            btnCalcularTotalFinal.Name = "btnCalcularTotalFinal";
            btnCalcularTotalFinal.Size = new Size(90, 25);
            btnCalcularTotalFinal.TabIndex = 19;
            btnCalcularTotalFinal.Text = "Calcular";
            btnCalcularTotalFinal.UseVisualStyleBackColor = true;
            btnCalcularTotalFinal.Click += btnCalcularTotalFinal_Click;
            // 
            // lblTotalFinal
            // 
            lblTotalFinal.AutoSize = true;
            lblTotalFinal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalFinal.Location = new Point(199, 281);
            lblTotalFinal.Name = "lblTotalFinal";
            lblTotalFinal.Size = new Size(0, 25);
            lblTotalFinal.TabIndex = 18;
            // 
            // lblNombreVendedorDetalle
            // 
            lblNombreVendedorDetalle.AutoSize = true;
            lblNombreVendedorDetalle.Location = new Point(320, 23);
            lblNombreVendedorDetalle.Name = "lblNombreVendedorDetalle";
            lblNombreVendedorDetalle.Size = new Size(51, 15);
            lblNombreVendedorDetalle.TabIndex = 17;
            lblNombreVendedorDetalle.Text = "Nombre";
            // 
            // lblNombreClienteDetalle
            // 
            lblNombreClienteDetalle.AutoSize = true;
            lblNombreClienteDetalle.Location = new Point(61, 23);
            lblNombreClienteDetalle.Name = "lblNombreClienteDetalle";
            lblNombreClienteDetalle.Size = new Size(51, 15);
            lblNombreClienteDetalle.TabIndex = 16;
            lblNombreClienteDetalle.Text = "Nombre";
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.BackColor = Color.FromArgb(50, 50, 85);
            btnFinalizarVenta.Cursor = Cursors.Hand;
            btnFinalizarVenta.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnFinalizarVenta.FlatAppearance.BorderSize = 2;
            btnFinalizarVenta.ForeColor = SystemColors.ButtonFace;
            btnFinalizarVenta.Image = (Image)resources.GetObject("btnFinalizarVenta.Image");
            btnFinalizarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizarVenta.Location = new Point(872, 249);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(137, 51);
            btnFinalizarVenta.TabIndex = 15;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.TextAlign = ContentAlignment.MiddleRight;
            btnFinalizarVenta.UseVisualStyleBackColor = false;
            btnFinalizarVenta.Click += btnFinalizarVenta_Click;
            // 
            // lblTotalVenta
            // 
            lblTotalVenta.AutoSize = true;
            lblTotalVenta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalVenta.Location = new Point(629, 284);
            lblTotalVenta.Name = "lblTotalVenta";
            lblTotalVenta.Size = new Size(0, 25);
            lblTotalVenta.TabIndex = 14;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(93, 241);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(145, 23);
            cmbMetodoPago.TabIndex = 13;
            cmbMetodoPago.SelectedIndexChanged += cmbMetodoPago_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(0, 244);
            label17.Name = "label17";
            label17.Size = new Size(90, 15);
            label17.TabIndex = 12;
            label17.Text = "Forma de pago:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(244, 249);
            label16.Name = "label16";
            label16.Size = new Size(65, 15);
            label16.TabIndex = 11;
            label16.Text = "Recarga: %";
            // 
            // txtRecargo
            // 
            txtRecargo.Location = new Point(311, 241);
            txtRecargo.Name = "txtRecargo";
            txtRecargo.Size = new Size(43, 23);
            txtRecargo.TabIndex = 10;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(360, 249);
            label15.Name = "label15";
            label15.Size = new Size(79, 15);
            label15.TabIndex = 9;
            label15.Text = "Descuento: %";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(445, 241);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(44, 23);
            txtDescuento.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(253, 23);
            label14.Name = "label14";
            label14.Size = new Size(63, 15);
            label14.TabIndex = 6;
            label14.Text = "Vendedor: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 23);
            label13.Name = "label13";
            label13.Size = new Size(50, 15);
            label13.TabIndex = 5;
            label13.Text = "Cliente: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 50);
            label12.Name = "label12";
            label12.Size = new Size(184, 15);
            label12.TabIndex = 4;
            label12.Text = "Lista de productos seleccionados:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(629, 291);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 25);
            lblTotal.TabIndex = 3;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(6, 68);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.Size = new Size(1003, 163);
            dgvCarrito.TabIndex = 2;
            dgvCarrito.CellContentClick += dgvCarrito_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSeleccionarProducto);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(txtCodProd);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(btnAgregarCarrito);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(btnLimpiarProducto);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnBuscarProducto);
            groupBox2.Controls.Add(txtCodProductoBuscar);
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(txtStockDisponible);
            groupBox2.Controls.Add(txtNombreProducto);
            groupBox2.Location = new Point(16, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1015, 122);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Producto";
            // 
            // btnSeleccionarProducto
            // 
            btnSeleccionarProducto.BackColor = Color.LightGray;
            btnSeleccionarProducto.Cursor = Cursors.Hand;
            btnSeleccionarProducto.FlatAppearance.BorderSize = 0;
            btnSeleccionarProducto.Image = (Image)resources.GetObject("btnSeleccionarProducto.Image");
            btnSeleccionarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeleccionarProducto.Location = new Point(663, 10);
            btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            btnSeleccionarProducto.Size = new Size(149, 36);
            btnSeleccionarProducto.TabIndex = 23;
            btnSeleccionarProducto.Text = "Seleccionar Producto";
            btnSeleccionarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnSeleccionarProducto.UseVisualStyleBackColor = false;
            btnSeleccionarProducto.Click += btnSeleccionarProducto_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(544, 62);
            label19.Name = "label19";
            label19.Size = new Size(84, 15);
            label19.TabIndex = 22;
            label19.Text = "Cod. Producto";
            // 
            // txtCodProd
            // 
            txtCodProd.Font = new Font("Segoe UI", 9.75F);
            txtCodProd.Location = new Point(676, 52);
            txtCodProd.Name = "txtCodProd";
            txtCodProd.ReadOnly = true;
            txtCodProd.Size = new Size(100, 25);
            txtCodProd.TabIndex = 21;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(676, 83);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 20;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(544, 91);
            label18.Name = "label18";
            label18.Size = new Size(126, 15);
            label18.TabIndex = 19;
            label18.Text = "Cantidad seleccionada";
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.BackColor = Color.DarkSeaGreen;
            btnAgregarCarrito.Cursor = Cursors.Hand;
            btnAgregarCarrito.FlatAppearance.BorderSize = 0;
            btnAgregarCarrito.FlatStyle = FlatStyle.Flat;
            btnAgregarCarrito.Image = (Image)resources.GetObject("btnAgregarCarrito.Image");
            btnAgregarCarrito.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarCarrito.Location = new Point(838, 10);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(140, 34);
            btnAgregarCarrito.TabIndex = 17;
            btnAgregarCarrito.Text = "Agregar al carrito";
            btnAgregarCarrito.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarCarrito.UseVisualStyleBackColor = false;
            btnAgregarCarrito.Click += btnAgregarCarrito_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(253, 91);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 18;
            label10.Text = "Precio por unidad";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 86);
            label9.Name = "label9";
            label9.Size = new Size(94, 15);
            label9.TabIndex = 17;
            label9.Text = "Stock disponible";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 60);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 16;
            label8.Text = "Nombre de Producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 19);
            label7.Name = "label7";
            label7.Size = new Size(155, 15);
            label7.TabIndex = 15;
            label7.Text = "Buscar producto por codigo";
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Cursor = Cursors.Hand;
            btnBuscarProducto.Location = new Point(544, 15);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(75, 23);
            btnBuscarProducto.TabIndex = 14;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // txtCodProductoBuscar
            // 
            txtCodProductoBuscar.Location = new Point(178, 14);
            txtCodProductoBuscar.Name = "txtCodProductoBuscar";
            txtCodProductoBuscar.PlaceholderText = "Ingrese codigo del producto";
            txtCodProductoBuscar.Size = new Size(360, 23);
            txtCodProductoBuscar.TabIndex = 13;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 9.75F);
            txtPrecio.Location = new Point(360, 83);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(178, 25);
            txtPrecio.TabIndex = 8;
            // 
            // txtStockDisponible
            // 
            txtStockDisponible.Font = new Font("Segoe UI", 9.75F);
            txtStockDisponible.Location = new Point(117, 83);
            txtStockDisponible.Name = "txtStockDisponible";
            txtStockDisponible.ReadOnly = true;
            txtStockDisponible.Size = new Size(130, 25);
            txtStockDisponible.TabIndex = 7;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Font = new Font("Segoe UI", 9.75F);
            txtNombreProducto.Location = new Point(142, 54);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.ReadOnly = true;
            txtNombreProducto.Size = new Size(396, 25);
            txtNombreProducto.TabIndex = 6;
            txtNombreProducto.TextChanged += textBox9_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1037, 616);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lista de Ventas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { FechaVenta, TotalVenta });
            dataGridView2.Location = new Point(18, 107);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1002, 150);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // FechaVenta
            // 
            FechaVenta.HeaderText = "Fecha";
            FechaVenta.Name = "FechaVenta";
            // 
            // TotalVenta
            // 
            TotalVenta.HeaderText = "Total";
            TotalVenta.Name = "TotalVenta";
            // 
            // VentasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1060, 660);
            Controls.Add(tabControl1);
            Name = "VentasForm";
            Text = "VentasForm";
            Load += VentasForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDniBuscar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvCarrito;
        private GroupBox groupBox2;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBuscarDni;
        private TextBox txtPrecio;
        private TextBox txtStockDisponible;
        private TextBox txtNombreProducto;
        private Label LbBusqueda;
        private Label label7;
        private Button btnBuscarProducto;
        private TextBox txtCodProductoBuscar;
        private Label label9;
        private Label label8;
        private Label label10;
        private Button btnLimpiarProducto;
        private Button btnBuscarCliente;
        private GroupBox groupBox3;
        private Button btnNuevoCliente;
        private Label label12;
        private Label lblTotal;
        private Label label14;
        private Label label13;
        private Button btnAgregarCarrito;
        private Label label17;
        private Label label16;
        private TextBox txtRecargo;
        private Label label15;
        private TextBox txtDescuento;
        private ComboBox cmbMetodoPago;
        private Label label19;
        private TextBox txtCodProd;
        private TextBox txtCantidad;
        private Label label18;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn FechaVenta;
        private DataGridViewTextBoxColumn TotalVenta;
        private Label lblEmailCliente;
        private Label lblDniCliente;
        private Label lblTelefonoCliente;
        private Label lblNombreCliente;
        private Label lblDireccionCliente;
        private Button btnLimpiarCliente;
        private Label lblTotalVenta;
        private TextBox txtObservaciones;
        private Button btnFinalizarVenta;
        private Label label6;
        private Button btnSeleccionarProducto;
        private Label lblNombreVendedorDetalle;
        private Label lblNombreClienteDetalle;
        private Label lblTotalFinal;
        private Button btnCalcularTotalFinal;
        private Label label11;
    }
}
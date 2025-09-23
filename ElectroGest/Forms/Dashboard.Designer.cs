namespace ElectroGest.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btnCerrarSesion = new Button();
            btnUsuarios = new Button();
            panelSidebar = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            welcomeuser = new Label();
            userrol = new Label();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnInicio = new Button();
            btnReportes = new Button();
            btnBackup = new Button();
            btnProductos = new Button();
            btnProveedor = new Button();
            btnVentas = new Button();
            btnClientes = new Button();
            panel1 = new Panel();
            panelPrimario = new Panel();
            panelContenedor = new Panel();
            panelSidebar.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panelPrimario.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(100, 192, 60, 100);
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 192, 60, 130);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = SystemColors.ButtonFace;
            btnCerrarSesion.Image = Properties.Resources.icons8_cierre_de_sesión_redondeado_hacia_la_izquierda_48;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(3, 435);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(209, 48);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(100, 80, 80, 100);
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUsuarios.ForeColor = SystemColors.ButtonFace;
            btnUsuarios.Image = Properties.Resources.icons8_usuarios_48;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(3, 57);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(209, 48);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.AutoSize = true;
            panelSidebar.BackColor = Color.FromArgb(45, 45, 45);
            panelSidebar.Controls.Add(panel4);
            panelSidebar.Controls.Add(panel3);
            panelSidebar.Controls.Add(flowLayoutPanel1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(221, 626);
            panelSidebar.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(welcomeuser);
            panel4.Controls.Add(userrol);
            panel4.Location = new Point(3, 567);
            panel4.Name = "panel4";
            panel4.Size = new Size(215, 56);
            panel4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_punto_y_final_24;
            pictureBox1.Location = new Point(6, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // welcomeuser
            // 
            welcomeuser.AutoSize = true;
            welcomeuser.Font = new Font("Myanmar Text", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeuser.ForeColor = SystemColors.ButtonFace;
            welcomeuser.ImageAlign = ContentAlignment.MiddleLeft;
            welcomeuser.Location = new Point(27, 16);
            welcomeuser.Name = "welcomeuser";
            welcomeuser.Size = new Size(0, 20);
            welcomeuser.TabIndex = 0;
            welcomeuser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // userrol
            // 
            userrol.AutoSize = true;
            userrol.ForeColor = SystemColors.ActiveCaption;
            userrol.Location = new Point(30, 42);
            userrol.Name = "userrol";
            userrol.Size = new Size(0, 15);
            userrol.TabIndex = 0;
            userrol.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 68);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSeaGreen;
            label1.Location = new Point(53, 21);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 3;
            label1.Text = "Electrogest Alderete Cent";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_neo_cryptocurrency_48;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(212, 62);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnInicio);
            flowLayoutPanel1.Controls.Add(btnUsuarios);
            flowLayoutPanel1.Controls.Add(btnReportes);
            flowLayoutPanel1.Controls.Add(btnBackup);
            flowLayoutPanel1.Controls.Add(btnProductos);
            flowLayoutPanel1.Controls.Add(btnProveedor);
            flowLayoutPanel1.Controls.Add(btnVentas);
            flowLayoutPanel1.Controls.Add(btnClientes);
            flowLayoutPanel1.Controls.Add(btnCerrarSesion);
            flowLayoutPanel1.Location = new Point(3, 71);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(212, 489);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(100, 80, 80, 100);
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnInicio.ForeColor = SystemColors.ButtonFace;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(3, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(209, 48);
            btnInicio.TabIndex = 4;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(100, 80, 80, 100);
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnReportes.ForeColor = SystemColors.ButtonFace;
            btnReportes.Image = Properties.Resources.icons8_analistica_web_483;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(3, 111);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(209, 48);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.FromArgb(100, 80, 80, 100);
            btnBackup.FlatAppearance.BorderSize = 0;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnBackup.ForeColor = SystemColors.ButtonFace;
            btnBackup.Image = Properties.Resources.icons8_database_48;
            btnBackup.ImageAlign = ContentAlignment.MiddleLeft;
            btnBackup.Location = new Point(3, 165);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(209, 48);
            btnBackup.TabIndex = 6;
            btnBackup.Text = "Backup";
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(100, 80, 80, 100);
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnProductos.ForeColor = SystemColors.ButtonFace;
            btnProductos.Image = Properties.Resources.icons8_carrito_2_48;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(3, 219);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(209, 48);
            btnProductos.TabIndex = 5;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.BackColor = Color.FromArgb(100, 80, 80, 100);
            btnProveedor.FlatAppearance.BorderSize = 0;
            btnProveedor.FlatStyle = FlatStyle.Flat;
            btnProveedor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnProveedor.ForeColor = SystemColors.ButtonFace;
            btnProveedor.Image = (Image)resources.GetObject("btnProveedor.Image");
            btnProveedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedor.Location = new Point(3, 273);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(209, 48);
            btnProveedor.TabIndex = 8;
            btnProveedor.Text = "Proveedores";
            btnProveedor.UseVisualStyleBackColor = false;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(100, 80, 80, 100);
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnVentas.ForeColor = SystemColors.ButtonFace;
            btnVentas.Image = Properties.Resources.icons8_ventas_481;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(3, 327);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(209, 48);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(100, 80, 80, 100);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnClientes.ForeColor = SystemColors.ButtonFace;
            btnClientes.Image = Properties.Resources.icons8_crítico_hombre_48;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(3, 381);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(209, 48);
            btnClientes.TabIndex = 7;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(45, 45, 50);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 0);
            panel1.TabIndex = 0;
            // 
            // panelPrimario
            // 
            panelPrimario.AutoSize = true;
            panelPrimario.Controls.Add(panelContenedor);
            panelPrimario.Dock = DockStyle.Fill;
            panelPrimario.Location = new Point(221, 0);
            panelPrimario.Name = "panelPrimario";
            panelPrimario.Size = new Size(973, 626);
            panelPrimario.TabIndex = 9;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(224, 224, 224);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(973, 626);
            panelContenedor.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(50, 50, 60);
            ClientSize = new Size(1194, 626);
            Controls.Add(panelPrimario);
            Controls.Add(panelSidebar);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panelSidebar.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panelPrimario.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCerrarSesion;
        private Button btnUsuarios;
        private Panel panelSidebar;
        private Button btnVentas;
        private Button btnReportes;
        private Button btnInicio;
        private Button btnProductos;
        private Button btnBackup;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label welcomeuser;
        private Label userrol;
        private Panel panelPrimario;
        private Button btnClientes;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel4;
        private Panel panelContenedor;
        private PictureBox pictureBox1;
        private Button btnProveedor;
    }
}
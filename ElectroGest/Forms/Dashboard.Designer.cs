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
            btnCerrarSesion = new Button();
            btnUsuarios = new Button();
            panelSidebar = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            userrol = new Label();
            welcomeuser = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnInicio = new Button();
            btnReportes = new Button();
            btnBackup = new Button();
            btnProductos = new Button();
            btnVentas = new Button();
            btnClientes = new Button();
            panel1 = new Panel();
            panelContenedor = new Panel();
            panelSidebar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(100, 192, 60, 100);
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = SystemColors.ButtonFace;
            btnCerrarSesion.Image = Properties.Resources.icons8_cierre_de_sesión_redondeado_hacia_la_izquierda_48;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(3, 409);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(209, 52);
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
            btnUsuarios.Location = new Point(3, 61);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(209, 52);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.AutoSize = true;
            panelSidebar.BackColor = Color.FromArgb(45, 45, 45);
            panelSidebar.Controls.Add(panel2);
            panelSidebar.Controls.Add(flowLayoutPanel1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(215, 711);
            panelSidebar.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(userrol);
            panel2.Controls.Add(welcomeuser);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 90);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_usuario_48__1_;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // userrol
            // 
            userrol.AutoSize = true;
            userrol.ForeColor = SystemColors.ActiveCaption;
            userrol.Location = new Point(58, 38);
            userrol.Name = "userrol";
            userrol.Size = new Size(0, 15);
            userrol.TabIndex = 0;
            userrol.TextAlign = ContentAlignment.MiddleRight;
            // 
            // welcomeuser
            // 
            welcomeuser.AutoSize = true;
            welcomeuser.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeuser.ForeColor = SystemColors.ButtonFace;
            welcomeuser.Location = new Point(49, 9);
            welcomeuser.Name = "welcomeuser";
            welcomeuser.Size = new Size(0, 29);
            welcomeuser.TabIndex = 0;
            welcomeuser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnInicio);
            flowLayoutPanel1.Controls.Add(btnUsuarios);
            flowLayoutPanel1.Controls.Add(btnReportes);
            flowLayoutPanel1.Controls.Add(btnBackup);
            flowLayoutPanel1.Controls.Add(btnProductos);
            flowLayoutPanel1.Controls.Add(btnVentas);
            flowLayoutPanel1.Controls.Add(btnClientes);
            flowLayoutPanel1.Controls.Add(btnCerrarSesion);
            flowLayoutPanel1.Location = new Point(0, 96);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(212, 496);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(100, 80, 80, 100);
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnInicio.ForeColor = SystemColors.ButtonFace;
            btnInicio.Image = Properties.Resources.icons8_página_principal_482;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(3, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(209, 52);
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
            btnReportes.Location = new Point(3, 119);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(209, 52);
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
            btnBackup.Image = Properties.Resources.icons8_base_de_datos_48;
            btnBackup.ImageAlign = ContentAlignment.MiddleLeft;
            btnBackup.Location = new Point(3, 177);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(209, 52);
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
            btnProductos.Location = new Point(3, 235);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(209, 52);
            btnProductos.TabIndex = 5;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
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
            btnVentas.Location = new Point(3, 293);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(209, 52);
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
            btnClientes.Location = new Point(3, 351);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(209, 52);
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
            panel1.Size = new Size(1089, 0);
            panel1.TabIndex = 0;
            // 
            // panelContenedor
            // 
            panelContenedor.AutoSize = true;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(215, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(874, 711);
            panelContenedor.TabIndex = 9;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 60);
            ClientSize = new Size(1089, 711);
            Controls.Add(panelContenedor);
            Controls.Add(panelSidebar);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panelSidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
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
        private Panel panelContenedor;
        private Button btnClientes;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}
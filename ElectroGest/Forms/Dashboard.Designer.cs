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
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.ForeColor = SystemColors.ButtonFace;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(3, 444);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(197, 50);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.ForeColor = SystemColors.ButtonFace;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(3, 60);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(197, 55);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.AutoSize = true;
            panelSidebar.BackColor = Color.FromArgb(45, 45, 45);
            panelSidebar.Controls.Add(userrol);
            panelSidebar.Controls.Add(welcomeuser);
            panelSidebar.Controls.Add(flowLayoutPanel1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(215, 604);
            panelSidebar.TabIndex = 2;
            // 
            // userrol
            // 
            userrol.AutoSize = true;
            userrol.ForeColor = SystemColors.ActiveCaption;
            userrol.Location = new Point(15, 42);
            userrol.Name = "userrol";
            userrol.Size = new Size(0, 15);
            userrol.TabIndex = 0;
            // 
            // welcomeuser
            // 
            welcomeuser.AutoSize = true;
            welcomeuser.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeuser.ForeColor = SystemColors.ButtonFace;
            welcomeuser.Location = new Point(0, 0);
            welcomeuser.Name = "welcomeuser";
            welcomeuser.Size = new Size(0, 29);
            welcomeuser.TabIndex = 0;
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
            flowLayoutPanel1.Location = new Point(12, 96);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 496);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btnInicio
            // 
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.ForeColor = SystemColors.ButtonFace;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(3, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(197, 51);
            btnInicio.TabIndex = 4;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnReportes
            // 
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.ForeColor = SystemColors.ButtonFace;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(3, 121);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(197, 59);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Reportes";
            btnReportes.Click += btnReportes_Click;
            // 
            // btnBackup
            // 
            btnBackup.FlatAppearance.BorderSize = 0;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.ForeColor = SystemColors.ButtonFace;
            btnBackup.Image = (Image)resources.GetObject("btnBackup.Image");
            btnBackup.ImageAlign = ContentAlignment.MiddleLeft;
            btnBackup.Location = new Point(3, 186);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(197, 59);
            btnBackup.TabIndex = 6;
            btnBackup.Text = "Backup";
            btnBackup.Click += btnBackup_Click;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.ForeColor = SystemColors.ButtonFace;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(3, 251);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(197, 61);
            btnProductos.TabIndex = 5;
            btnProductos.Text = "Productos";
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = SystemColors.ButtonFace;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(3, 318);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(197, 57);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.Click += btnVentas_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.ForeColor = SystemColors.ButtonFace;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(3, 381);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(197, 57);
            btnClientes.TabIndex = 7;
            btnClientes.Text = "Clientes";
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
            panelContenedor.Size = new Size(874, 604);
            panelContenedor.TabIndex = 9;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 60);
            ClientSize = new Size(1089, 604);
            Controls.Add(panelContenedor);
            Controls.Add(panelSidebar);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
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
    }
}
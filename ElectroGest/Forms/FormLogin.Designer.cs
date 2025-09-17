namespace ElectroGest.Forms
{
    partial class FormLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            bindingSource1 = new BindingSource(components);
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pnlError = new Panel();
            btnCerrarError = new Button();
            lblError = new Label();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            panel2 = new Panel();
            btnVisible = new Button();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            label4 = new Label();
            imageList1 = new ImageList(components);
            timerError = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            pnlError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(717, 411);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pnlError);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 411);
            panel1.TabIndex = 15;
            // 
            // pnlError
            // 
            pnlError.BackColor = Color.FromArgb(100, 30, 0, 0);
            pnlError.Controls.Add(btnCerrarError);
            pnlError.Controls.Add(lblError);
            pnlError.Location = new Point(25, 274);
            pnlError.Name = "pnlError";
            pnlError.Size = new Size(310, 63);
            pnlError.TabIndex = 22;
            // 
            // btnCerrarError
            // 
            btnCerrarError.BackColor = Color.Transparent;
            btnCerrarError.Cursor = Cursors.Hand;
            btnCerrarError.FlatAppearance.BorderSize = 0;
            btnCerrarError.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCerrarError.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCerrarError.FlatStyle = FlatStyle.Flat;
            btnCerrarError.ForeColor = SystemColors.ButtonHighlight;
            btnCerrarError.Image = (Image)resources.GetObject("btnCerrarError.Image");
            btnCerrarError.Location = new Point(256, 12);
            btnCerrarError.Name = "btnCerrarError";
            btnCerrarError.Size = new Size(51, 41);
            btnCerrarError.TabIndex = 22;
            btnCerrarError.UseVisualStyleBackColor = false;
            btnCerrarError.Click += btnCerrarError_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.Transparent;
            lblError.ForeColor = Color.MistyRose;
            lblError.Location = new Point(14, 25);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(100, 0, 0, 0);
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(25, 210);
            label6.Name = "label6";
            label6.Size = new Size(310, 34);
            label6.TabIndex = 20;
            label6.Text = "\"Todo lo que necesitás para organizar tus ventas\r\n y productos está aquí. Iniciá sesión para empezar.\"";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(25, 59);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 49);
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(100, 0, 0, 0);
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(109, 126);
            label5.Name = "label5";
            label5.Size = new Size(77, 17);
            label5.TabIndex = 18;
            label5.Text = "ElectroGest\r\n";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.Controls.Add(btnVisible);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(388, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 295);
            panel2.TabIndex = 17;
            // 
            // btnVisible
            // 
            btnVisible.BackColor = Color.Transparent;
            btnVisible.Cursor = Cursors.Hand;
            btnVisible.FlatAppearance.BorderSize = 0;
            btnVisible.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 0, 0, 0);
            btnVisible.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
            btnVisible.FlatStyle = FlatStyle.Flat;
            btnVisible.ForeColor = SystemColors.ActiveCaption;
            btnVisible.Image = Properties.Resources.icons8_invisible_24;
            btnVisible.Location = new Point(263, 149);
            btnVisible.Name = "btnVisible";
            btnVisible.Size = new Size(36, 23);
            btnVisible.TabIndex = 20;
            btnVisible.UseVisualStyleBackColor = false;
            btnVisible.Click += btnVisible_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(92, 15);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 7;
            label1.Text = "Iniciar Sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(31, 45);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 12;
            label2.Text = "Direccion de Correo:";
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnLogin.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ActiveCaption;
            btnLogin.Location = new Point(64, 215);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 40);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = SystemColors.HotTrack;
            linkLabel1.Location = new Point(77, 184);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(128, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Olvido su contraseña?";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 77);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(37, 149);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(228, 23);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyDown += TextBoxes_KeyDown;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(37, 77);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(228, 23);
            txtUsuario.TabIndex = 8;
            txtUsuario.KeyDown += TextBoxes_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(31, 120);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 13;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(100, 0, 0, 0);
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(25, 126);
            label4.Name = "label4";
            label4.Size = new Size(282, 68);
            label4.TabIndex = 16;
            label4.Text = "\"Bienvenido a \r\nel sistema de gestión de ventas que te permite\r\n administrar usuarios y productos\r\n de manera segura y eficiente.\"";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-visible-24.png");
            imageList1.Images.SetKeyName(1, "icons8-invisible-24.png");
            // 
            // timerError
            // 
            timerError.Tick += TimerError_Tick;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(717, 411);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlError.ResumeLayout(false);
            pnlError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSource1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label3;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel linkLabel1;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Label label5;
        private Button btnVisible;
        private Label label6;
        private ImageList imageList1;
        private Label lblError;
        private Panel pnlError;
        private Button btnCerrarError;
        private System.Windows.Forms.Timer timerError;
    }
}
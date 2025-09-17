namespace ElectroGest.Forms
{
    partial class GestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtNombre = new Label();
            txtEmail = new Label();
            txtTelefono = new Label();
            txtPassword = new Label();
            txt = new Label();
            BoxNombre = new TextBox();
            BoxEmail = new TextBox();
            BoxTelefono = new TextBox();
            BoxPassword = new TextBox();
            usuarioBindingSource = new BindingSource(components);
            chkActivo = new CheckBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnProbar = new Button();
            dgvUsuarios = new DataGridView();
            CbmRol = new ComboBox();
            personaBindingSource1 = new BindingSource(components);
            personaBindingSource = new BindingSource(components);
            label1 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            lblConfirmarPassword = new Label();
            BoxDni = new TextBox();
            lblDni = new Label();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            txtNombre.Location = new Point(3, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(112, 15);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "Nombre de usuario:";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.ForeColor = SystemColors.ActiveCaptionText;
            txtEmail.Location = new Point(5, 69);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(115, 15);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "Direccion de Correo:";
            // 
            // txtTelefono
            // 
            txtTelefono.AutoSize = true;
            txtTelefono.ForeColor = SystemColors.ActiveCaptionText;
            txtTelefono.Location = new Point(5, 116);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(55, 15);
            txtTelefono.TabIndex = 3;
            txtTelefono.Text = "Telefono:";
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.ForeColor = SystemColors.ActiveCaptionText;
            txtPassword.Location = new Point(396, 15);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(70, 15);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Contraseña:";
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.ForeColor = SystemColors.ActiveCaptionText;
            txt.Location = new Point(5, 220);
            txt.Name = "txt";
            txt.Size = new Size(27, 15);
            txt.TabIndex = 5;
            txt.Text = "Rol:";
            // 
            // BoxNombre
            // 
            BoxNombre.Location = new Point(38, 37);
            BoxNombre.Name = "BoxNombre";
            BoxNombre.Size = new Size(277, 23);
            BoxNombre.TabIndex = 6;
            // 
            // BoxEmail
            // 
            BoxEmail.Location = new Point(38, 87);
            BoxEmail.Name = "BoxEmail";
            BoxEmail.Size = new Size(277, 23);
            BoxEmail.TabIndex = 7;
            // 
            // BoxTelefono
            // 
            BoxTelefono.Location = new Point(38, 134);
            BoxTelefono.Name = "BoxTelefono";
            BoxTelefono.Size = new Size(277, 23);
            BoxTelefono.TabIndex = 8;
            // 
            // BoxPassword
            // 
            BoxPassword.Location = new Point(394, 37);
            BoxPassword.Name = "BoxPassword";
            BoxPassword.Size = new Size(220, 23);
            BoxPassword.TabIndex = 9;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.ForeColor = SystemColors.ActiveCaptionText;
            chkActivo.Location = new Point(255, 220);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 12;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAgregar);
            flowLayoutPanel1.Controls.Add(btnEditar);
            flowLayoutPanel1.Controls.Add(btnEliminar);
            flowLayoutPanel1.Controls.Add(btnLimpiar);
            flowLayoutPanel1.Controls.Add(btnProbar);
            flowLayoutPanel1.Location = new Point(8, 264);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(490, 46);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // btnProbar
            // 
            btnProbar.BackColor = Color.FromArgb(192, 192, 255);
            btnProbar.FlatAppearance.BorderSize = 0;
            btnProbar.FlatStyle = FlatStyle.Flat;
            btnProbar.Location = new Point(391, 3);
            btnProbar.Name = "btnProbar";
            btnProbar.Size = new Size(75, 34);
            btnProbar.TabIndex = 20;
            btnProbar.Text = "Refresh";
            btnProbar.UseVisualStyleBackColor = false;
            btnProbar.Click += btnProbar_Click;
            // 
            // dgvUsuarios
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsuarios.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.Cursor = Cursors.Hand;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.Location = new Point(8, 37);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuarios.RowTemplate.DefaultCellStyle.BackColor = SystemColors.ActiveCaption;
            dgvUsuarios.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.Size = new Size(919, 133);
            dgvUsuarios.TabIndex = 18;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // CbmRol
            // 
            CbmRol.FormattingEnabled = true;
            CbmRol.Location = new Point(38, 218);
            CbmRol.Name = "CbmRol";
            CbmRol.Size = new Size(166, 23);
            CbmRol.TabIndex = 19;
            // 
            // personaBindingSource1
            // 
            personaBindingSource1.DataSource = typeof(Models.Persona);
            // 
            // personaBindingSource
            // 
            personaBindingSource.DataSource = typeof(Models.Persona);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(372, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 21;
            label1.Text = "Gestion de Usuarios";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblConfirmarPassword);
            panel1.Controls.Add(BoxDni);
            panel1.Controls.Add(lblDni);
            panel1.Controls.Add(BoxNombre);
            panel1.Controls.Add(BoxEmail);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(CbmRol);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(chkActivo);
            panel1.Controls.Add(BoxTelefono);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(BoxPassword);
            panel1.Controls.Add(txt);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(0, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 314);
            panel1.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(394, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 23;
            // 
            // lblConfirmarPassword
            // 
            lblConfirmarPassword.AutoSize = true;
            lblConfirmarPassword.BackColor = Color.Transparent;
            lblConfirmarPassword.ForeColor = SystemColors.ActiveCaptionText;
            lblConfirmarPassword.Location = new Point(394, 68);
            lblConfirmarPassword.Name = "lblConfirmarPassword";
            lblConfirmarPassword.Size = new Size(127, 15);
            lblConfirmarPassword.TabIndex = 22;
            lblConfirmarPassword.Text = "Confirmar Contraseña:";
            // 
            // BoxDni
            // 
            BoxDni.Location = new Point(38, 177);
            BoxDni.Name = "BoxDni";
            BoxDni.Size = new Size(277, 23);
            BoxDni.TabIndex = 21;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.ForeColor = SystemColors.ActiveCaptionText;
            lblDni.Location = new Point(5, 160);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 20;
            lblDni.Text = "DNI:";
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(939, 490);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Name = "GestionUsuarios";
            Text = "GestionUsuarios";
            Load += GestionUsuarios_Load;
            Click += GestionUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label txtNombre;
        private Label txtEmail;
        private Label txtTelefono;
        private Label txtPassword;
        private Label txt;
        private TextBox BoxNombre;
        private TextBox BoxEmail;
        private TextBox BoxTelefono;
        private TextBox BoxPassword;
        private CheckBox chkActivo;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private FlowLayoutPanel flowLayoutPanel1;
        private BindingSource usuarioBindingSource;
        private DataGridView dgvUsuarios;
        private ComboBox CbmRol;
        private BindingSource personaBindingSource1;
        private BindingSource personaBindingSource;
        private Button btnProbar;
        private Label label1;
        private Panel panel1;
        private TextBox BoxDni;
        private Label lblDni;
        private TextBox textBox1;
        private Label lblConfirmarPassword;
    }
}
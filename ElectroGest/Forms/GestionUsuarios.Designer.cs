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
            dgvUsuarios = new DataGridView();
            CbmRol = new ComboBox();
            personaBindingSource1 = new BindingSource(components);
            personaBindingSource = new BindingSource(components);
            btnProbar = new Button();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Location = new Point(23, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(112, 15);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "Nombre de usuario:";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Location = new Point(23, 75);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(115, 15);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "Direccion de Correo:";
            // 
            // txtTelefono
            // 
            txtTelefono.AutoSize = true;
            txtTelefono.Location = new Point(38, 115);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(55, 15);
            txtTelefono.TabIndex = 3;
            txtTelefono.Text = "Telefono:";
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Location = new Point(28, 155);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(70, 15);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Contraseña:";
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(28, 200);
            txt.Name = "txt";
            txt.Size = new Size(27, 15);
            txt.TabIndex = 5;
            txt.Text = "Rol:";
            // 
            // BoxNombre
            // 
            BoxNombre.Location = new Point(144, 37);
            BoxNombre.Name = "BoxNombre";
            BoxNombre.Size = new Size(220, 23);
            BoxNombre.TabIndex = 6;
            // 
            // BoxEmail
            // 
            BoxEmail.Location = new Point(144, 72);
            BoxEmail.Name = "BoxEmail";
            BoxEmail.Size = new Size(220, 23);
            BoxEmail.TabIndex = 7;
            // 
            // BoxTelefono
            // 
            BoxTelefono.Location = new Point(145, 112);
            BoxTelefono.Name = "BoxTelefono";
            BoxTelefono.Size = new Size(219, 23);
            BoxTelefono.TabIndex = 8;
            // 
            // BoxPassword
            // 
            BoxPassword.Location = new Point(144, 152);
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
            chkActivo.Location = new Point(304, 195);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 12;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.ForestGreen;
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
            btnEditar.BackColor = Color.DarkOrange;
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
            btnEliminar.BackColor = Color.Firebrick;
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
            flowLayoutPanel1.Location = new Point(23, 242);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(388, 46);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = SystemColors.ActiveCaption;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(0, 305);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(939, 150);
            dgvUsuarios.TabIndex = 18;
            // 
            // CbmRol
            // 
            CbmRol.FormattingEnabled = true;
            CbmRol.Location = new Point(144, 195);
            CbmRol.Name = "CbmRol";
            CbmRol.Size = new Size(154, 23);
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
            // btnProbar
            // 
            btnProbar.Location = new Point(412, 165);
            btnProbar.Name = "btnProbar";
            btnProbar.Size = new Size(75, 23);
            btnProbar.TabIndex = 20;
            btnProbar.Text = "Probar tabla";
            btnProbar.UseVisualStyleBackColor = true;
            btnProbar.Click += btnProbar_Click;
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(939, 490);
            Controls.Add(btnProbar);
            Controls.Add(CbmRol);
            Controls.Add(dgvUsuarios);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(chkActivo);
            Controls.Add(BoxPassword);
            Controls.Add(BoxTelefono);
            Controls.Add(BoxEmail);
            Controls.Add(BoxNombre);
            Controls.Add(txt);
            Controls.Add(txtPassword);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Name = "GestionUsuarios";
            Text = "GestionUsuarios";
            Load += GestionUsuarios_Load;
            Click += GestionUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
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
    }
}
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
            btnLimpiar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnEliminar = new Button();
            btnProbar = new Button();
            dgvUsuarios = new DataGridView();
            CbmRol = new ComboBox();
            personaBindingSource1 = new BindingSource(components);
            personaBindingSource = new BindingSource(components);
            panel1 = new Panel();
            panel2 = new Panel();
            BoxDni = new TextBox();
            lblDni = new Label();
            panel3 = new Panel();
            BoxConfirmarPassword = new TextBox();
            lblConfirmarPassword = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnBuscar = new Button();
            txtBuscarUsuario = new TextBox();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            btnExportarPdf = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnExportarExcel = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            txtNombre.Location = new Point(5, 9);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(112, 15);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "Nombre de usuario:";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.ForeColor = SystemColors.ActiveCaptionText;
            txtEmail.Location = new Point(5, 66);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(115, 15);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "Direccion de Correo:";
            // 
            // txtTelefono
            // 
            txtTelefono.AutoSize = true;
            txtTelefono.ForeColor = SystemColors.ActiveCaptionText;
            txtTelefono.Location = new Point(18, 9);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(55, 15);
            txtTelefono.TabIndex = 3;
            txtTelefono.Text = "Telefono:";
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.BackColor = Color.Transparent;
            txtPassword.ForeColor = SystemColors.ActiveCaptionText;
            txtPassword.Location = new Point(18, 66);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(70, 15);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Contraseña:";
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.ForeColor = SystemColors.ActiveCaptionText;
            txt.Location = new Point(8, 158);
            txt.Name = "txt";
            txt.Size = new Size(27, 15);
            txt.TabIndex = 5;
            txt.Text = "Rol:";
            // 
            // BoxNombre
            // 
            BoxNombre.BackColor = Color.White;
            BoxNombre.BorderStyle = BorderStyle.FixedSingle;
            BoxNombre.Location = new Point(8, 28);
            BoxNombre.Name = "BoxNombre";
            BoxNombre.PlaceholderText = "Ej: Juan ";
            BoxNombre.Size = new Size(277, 23);
            BoxNombre.TabIndex = 0;
            // 
            // BoxEmail
            // 
            BoxEmail.Location = new Point(8, 84);
            BoxEmail.Name = "BoxEmail";
            BoxEmail.PlaceholderText = "Ej: taller.2025@gmail.com";
            BoxEmail.Size = new Size(277, 23);
            BoxEmail.TabIndex = 1;
            // 
            // BoxTelefono
            // 
            BoxTelefono.Location = new Point(19, 27);
            BoxTelefono.Name = "BoxTelefono";
            BoxTelefono.PlaceholderText = "Ej: 3794123456 (10–11 dígitos, sin espacios)";
            BoxTelefono.Size = new Size(277, 23);
            BoxTelefono.TabIndex = 3;
            BoxTelefono.KeyPress += BoxTelefono_KeyPress;
            // 
            // BoxPassword
            // 
            BoxPassword.Location = new Point(19, 84);
            BoxPassword.Name = "BoxPassword";
            BoxPassword.PlaceholderText = "Mínimo 4 caracteres";
            BoxPassword.Size = new Size(277, 23);
            BoxPassword.TabIndex = 4;
            BoxPassword.UseSystemPasswordChar = true;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.FlatAppearance.BorderColor = Color.YellowGreen;
            chkActivo.FlatAppearance.CheckedBackColor = Color.Lime;
            chkActivo.ForeColor = SystemColors.ActiveCaptionText;
            chkActivo.Location = new Point(19, 181);
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
            btnAgregar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAgregar.Image = Properties.Resources.icons8_añadir_32;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(3, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(91, 34);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Guardar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Goldenrod;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
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
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.RosyBrown;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLimpiar.Image = Properties.Resources.icons8_limpiar_32;
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
            flowLayoutPanel1.Location = new Point(38, 264);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(431, 46);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
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
            // btnProbar
            // 
            btnProbar.BackColor = Color.Silver;
            btnProbar.FlatAppearance.BorderSize = 0;
            btnProbar.FlatStyle = FlatStyle.Flat;
            btnProbar.Image = Properties.Resources.icons8_emoji_de_flechas_en_sentido_contrario_a_las_agujas_del_reloj_48;
            btnProbar.Location = new Point(391, 3);
            btnProbar.Name = "btnProbar";
            btnProbar.Size = new Size(35, 34);
            btnProbar.TabIndex = 20;
            btnProbar.TextAlign = ContentAlignment.MiddleRight;
            btnProbar.UseVisualStyleBackColor = false;
            btnProbar.Click += btnProbar_Click;
            // 
            // dgvUsuarios
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsuarios.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.Cursor = Cursors.Hand;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.Location = new Point(3, 3);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            dgvUsuarios.Size = new Size(933, 227);
            dgvUsuarios.TabIndex = 18;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // CbmRol
            // 
            CbmRol.FormattingEnabled = true;
            CbmRol.Location = new Point(8, 177);
            CbmRol.Name = "CbmRol";
            CbmRol.Size = new Size(166, 23);
            CbmRol.TabIndex = 3;
            // 
            // personaBindingSource1
            // 
            personaBindingSource1.DataSource = typeof(Models.Persona);
            // 
            // personaBindingSource
            // 
            personaBindingSource.DataSource = typeof(Models.Persona);
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(7, 305);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 334);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(BoxNombre);
            panel2.Controls.Add(BoxDni);
            panel2.Controls.Add(CbmRol);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(lblDni);
            panel2.Controls.Add(txt);
            panel2.Controls.Add(BoxEmail);
            panel2.Location = new Point(38, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(352, 218);
            panel2.TabIndex = 26;
            // 
            // BoxDni
            // 
            BoxDni.Location = new Point(8, 129);
            BoxDni.Name = "BoxDni";
            BoxDni.PlaceholderText = "Ej: 12345678 (8 dígitos)";
            BoxDni.Size = new Size(277, 23);
            BoxDni.TabIndex = 2;
            BoxDni.KeyPress += BoxDni_KeyPress;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.ForeColor = SystemColors.ActiveCaptionText;
            lblDni.Location = new Point(5, 114);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 20;
            lblDni.Text = "DNI:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(BoxPassword);
            panel3.Controls.Add(BoxConfirmarPassword);
            panel3.Controls.Add(chkActivo);
            panel3.Controls.Add(lblConfirmarPassword);
            panel3.Controls.Add(BoxTelefono);
            panel3.Controls.Add(txtTelefono);
            panel3.Location = new Point(450, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(352, 218);
            panel3.TabIndex = 25;
            // 
            // BoxConfirmarPassword
            // 
            BoxConfirmarPassword.Location = new Point(18, 141);
            BoxConfirmarPassword.Name = "BoxConfirmarPassword";
            BoxConfirmarPassword.PlaceholderText = "Repite la contraseña";
            BoxConfirmarPassword.Size = new Size(277, 23);
            BoxConfirmarPassword.TabIndex = 5;
            BoxConfirmarPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmarPassword
            // 
            lblConfirmarPassword.AutoSize = true;
            lblConfirmarPassword.BackColor = Color.Transparent;
            lblConfirmarPassword.ForeColor = SystemColors.ActiveCaptionText;
            lblConfirmarPassword.Location = new Point(18, 114);
            lblConfirmarPassword.Name = "lblConfirmarPassword";
            lblConfirmarPassword.Size = new Size(127, 15);
            lblConfirmarPassword.TabIndex = 22;
            lblConfirmarPassword.Text = "Confirmar Contraseña:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(3, 46);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(947, 261);
            tabControl1.TabIndex = 24;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvUsuarios);
            tabPage1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = Color.FromArgb(64, 64, 64);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(939, 233);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lista de Usuarios";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(618, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Location = new Point(3, 3);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.PlaceholderText = "Buscar por dni, nombre, rol ...";
            txtBuscarUsuario.Size = new Size(197, 23);
            txtBuscarUsuario.TabIndex = 25;
            txtBuscarUsuario.TextChanged += txtBuscarUsuario_TextChanged;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(412, 3);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.ShowCheckBox = true;
            dtpHasta.Size = new Size(200, 23);
            dtpHasta.TabIndex = 27;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(206, 3);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.ShowCheckBox = true;
            dtpDesde.Size = new Size(200, 23);
            dtpDesde.TabIndex = 26;
            // 
            // btnExportarPdf
            // 
            btnExportarPdf.Cursor = Cursors.Hand;
            btnExportarPdf.FlatAppearance.BorderSize = 0;
            btnExportarPdf.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExportarPdf.FlatStyle = FlatStyle.Flat;
            btnExportarPdf.Image = Properties.Resources.icons8_pdf_32;
            btnExportarPdf.Location = new Point(3, 3);
            btnExportarPdf.Name = "btnExportarPdf";
            btnExportarPdf.Size = new Size(30, 29);
            btnExportarPdf.TabIndex = 29;
            btnExportarPdf.UseVisualStyleBackColor = true;
            btnExportarPdf.Click += btnExportarPdf_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(txtBuscarUsuario);
            flowLayoutPanel2.Controls.Add(dtpDesde);
            flowLayoutPanel2.Controls.Add(dtpHasta);
            flowLayoutPanel2.Controls.Add(btnBuscar);
            flowLayoutPanel2.Location = new Point(7, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(703, 28);
            flowLayoutPanel2.TabIndex = 27;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Cursor = Cursors.Hand;
            btnExportarExcel.FlatAppearance.BorderSize = 0;
            btnExportarExcel.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExportarExcel.FlatStyle = FlatStyle.Flat;
            btnExportarExcel.Image = Properties.Resources.icons8_ms_excel_26;
            btnExportarExcel.Location = new Point(39, 3);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(31, 29);
            btnExportarExcel.TabIndex = 28;
            btnExportarExcel.UseVisualStyleBackColor = true;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(btnExportarPdf);
            flowLayoutPanel3.Controls.Add(btnExportarExcel);
            flowLayoutPanel3.Location = new Point(862, 4);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(81, 36);
            flowLayoutPanel3.TabIndex = 19;
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(962, 661);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
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
        private Button btnLimpiar;
        private FlowLayoutPanel flowLayoutPanel1;
        private BindingSource usuarioBindingSource;
        private DataGridView dgvUsuarios;
        private ComboBox CbmRol;
        private BindingSource personaBindingSource1;
        private BindingSource personaBindingSource;
        private Panel panel1;
        private TextBox BoxDni;
        private Label lblDni;
        private TextBox BoxConfirmarPassword;
        private Label lblConfirmarPassword;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnEliminar;
        private Button btnProbar;
        private Panel panel3;
        private Panel panel2;
        private Button btnBuscar;
        private TextBox txtBuscarUsuario;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Button btnExportarPdf;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnExportarExcel;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}
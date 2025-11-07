namespace ElectroGest.Forms
{
    partial class GestionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionClientes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            BoxDireccion = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BoxTelefono = new TextBox();
            BoxDni = new TextBox();
            BoxEmail = new TextBox();
            BoxNombre = new TextBox();
            button1 = new Button();
            txtBuscarDni = new TextBox();
            label7 = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEstado = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvClientes = new DataGridView();
            btnLimpiar = new Button();
            txtIdCliente = new TextBox();
            chkActivo = new CheckBox();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BoxDireccion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BoxTelefono);
            groupBox1.Controls.Add(BoxDni);
            groupBox1.Controls.Add(BoxEmail);
            groupBox1.Controls.Add(BoxNombre);
            groupBox1.Location = new Point(12, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(562, 186);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del cliente";
            // 
            // BoxDireccion
            // 
            BoxDireccion.Location = new Point(68, 145);
            BoxDireccion.Name = "BoxDireccion";
            BoxDireccion.Size = new Size(437, 23);
            BoxDireccion.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 153);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 8;
            label6.Text = "Direcciòn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 120);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 7;
            label5.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 74);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 74);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 5;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 34);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // BoxTelefono
            // 
            BoxTelefono.Location = new Point(68, 66);
            BoxTelefono.Name = "BoxTelefono";
            BoxTelefono.Size = new Size(181, 23);
            BoxTelefono.TabIndex = 3;
            // 
            // BoxDni
            // 
            BoxDni.Location = new Point(324, 66);
            BoxDni.Name = "BoxDni";
            BoxDni.Size = new Size(181, 23);
            BoxDni.TabIndex = 2;
            // 
            // BoxEmail
            // 
            BoxEmail.Location = new Point(68, 112);
            BoxEmail.Name = "BoxEmail";
            BoxEmail.Size = new Size(437, 23);
            BoxEmail.TabIndex = 1;
            // 
            // BoxNombre
            // 
            BoxNombre.Location = new Point(68, 26);
            BoxNombre.Name = "BoxNombre";
            BoxNombre.Size = new Size(437, 23);
            BoxNombre.TabIndex = 0;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(467, 29);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtBuscarDni
            // 
            txtBuscarDni.Location = new Point(101, 29);
            txtBuscarDni.Name = "txtBuscarDni";
            txtBuscarDni.PlaceholderText = "Ingrese DNI del cliente";
            txtBuscarDni.Size = new Size(341, 23);
            txtBuscarDni.TabIndex = 4;
            txtBuscarDni.TextChanged += txtBuscarDni_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 37);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 5;
            label7.Text = "Buscar cliente:";
            // 
            // btnAgregar
            // 
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(618, 78);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 37);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(618, 130);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(127, 37);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEstado
            // 
            btnEstado.Location = new Point(618, 182);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(127, 37);
            btnEstado.TabIndex = 8;
            btnEstado.TextAlign = ContentAlignment.MiddleRight;
            btnEstado.UseVisualStyleBackColor = true;
            btnEstado.Click += btnEstado_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 270);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(893, 238);
            tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvClientes);
            tabPage1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = Color.FromArgb(64, 64, 64);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(885, 210);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lista de Clientes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.Cursor = Cursors.Hand;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Location = new Point(3, 3);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.RowTemplate.DefaultCellStyle.BackColor = SystemColors.ActiveCaption;
            dgvClientes.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvClientes.Size = new Size(879, 204);
            dgvClientes.TabIndex = 18;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(618, 231);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(127, 37);
            btnLimpiar.TabIndex = 26;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(613, 43);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(132, 23);
            txtIdCliente.TabIndex = 27;
            txtIdCliente.Visible = false;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(774, 46);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(15, 14);
            chkActivo.TabIndex = 28;
            chkActivo.UseVisualStyleBackColor = true;
            chkActivo.Visible = false;
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(917, 520);
            Controls.Add(chkActivo);
            Controls.Add(txtIdCliente);
            Controls.Add(btnLimpiar);
            Controls.Add(tabControl1);
            Controls.Add(btnEstado);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(label7);
            Controls.Add(txtBuscarDni);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "GestionClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionClientes";
            Load += GestionClientes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox BoxTelefono;
        private TextBox BoxDni;
        private TextBox BoxEmail;
        private TextBox BoxNombre;
        private TextBox BoxDireccion;
        private Label label6;
        private Button button1;
        private TextBox txtBuscarDni;
        private Label label7;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEstado;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvClientes;
        private Button btnLimpiar;
        private TextBox txtIdCliente;
        private CheckBox chkActivo;
    }
}
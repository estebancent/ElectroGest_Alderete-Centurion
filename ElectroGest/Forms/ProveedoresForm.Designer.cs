namespace ElectroGest.Forms
{
    partial class ProveedoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedoresForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewProveedores = new DataGridView();
            label3 = new Label();
            btnEditar = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCuit = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            btnEliminar = new Button();
            txtDireccion = new TextBox();
            label7 = new Label();
            chkActivo = new CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(50, 50, 80);
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.ForeColor = SystemColors.ButtonFace;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(319, 220);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(93, 38);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(50, 50, 80);
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.ForeColor = SystemColors.ButtonFace;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(33, 221);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 37);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(50, 60, 50);
            label2.Location = new Point(33, 60);
            label2.Name = "label2";
            label2.Size = new Size(147, 21);
            label2.TabIndex = 10;
            label2.Text = "Añadir proveedores";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 274);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(894, 265);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewProveedores);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(886, 237);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Proveedores";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProveedores
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProveedores.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewProveedores.BorderStyle = BorderStyle.None;
            dataGridViewProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 100, 150);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProveedores.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewProveedores.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProveedores.Dock = DockStyle.Fill;
            dataGridViewProveedores.EnableHeadersVisualStyles = false;
            dataGridViewProveedores.Location = new Point(3, 3);
            dataGridViewProveedores.Name = "dataGridViewProveedores";
            dataGridViewProveedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SteelBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewProveedores.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewProveedores.RowTemplate.DefaultCellStyle.BackColor = SystemColors.ActiveCaption;
            dataGridViewProveedores.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewProveedores.Size = new Size(880, 231);
            dataGridViewProveedores.TabIndex = 20;
            dataGridViewProveedores.CellClick += dataGridViewProveedores_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(50, 60, 50);
            label3.Location = new Point(33, 103);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 14;
            label3.Text = "Nombre/Empresa:";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(50, 50, 80);
            btnEditar.ForeColor = SystemColors.ButtonFace;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(131, 221);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 39);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(140, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(261, 23);
            txtNombre.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(50, 60, 50);
            label1.Location = new Point(85, 25);
            label1.Name = "label1";
            label1.Size = new Size(212, 25);
            label1.TabIndex = 9;
            label1.Text = "Gestion de Proveedores";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(50, 60, 50);
            label4.Location = new Point(408, 103);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 17;
            label4.Text = "DNI/CUIT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(50, 60, 50);
            label5.Location = new Point(33, 147);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 18;
            label5.Text = "Telefono:";
            // 
            // txtCuit
            // 
            txtCuit.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCuit.Location = new Point(471, 100);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(261, 23);
            txtCuit.TabIndex = 19;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(140, 144);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(261, 23);
            txtTelefono.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(471, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 23);
            txtEmail.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(50, 60, 50);
            label6.Location = new Point(408, 150);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 22;
            label6.Text = "Email:\r\n";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(50, 50, 80);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Image = Properties.Resources.iconDesactivar;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(225, 221);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 39);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(140, 181);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(261, 23);
            txtDireccion.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(50, 60, 50);
            label7.Location = new Point(33, 184);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 24;
            label7.Text = "Direccion:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.FlatStyle = FlatStyle.System;
            chkActivo.Location = new Point(471, 185);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(66, 20);
            chkActivo.TabIndex = 26;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // ProveedoresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 566);
            Controls.Add(chkActivo);
            Controls.Add(txtDireccion);
            Controls.Add(label7);
            Controls.Add(btnEliminar);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtCuit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(tabControl1);
            Controls.Add(label3);
            Controls.Add(btnEditar);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "ProveedoresForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProveedoresForm";
            Load += ProveedoresForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnAgregar;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private Button btnEditar;
        private TextBox txtNombre;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox txtCuit;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Label label6;
        private Button btnEliminar;
        private DataGridView dataGridViewProveedores;
        private TextBox txtDireccion;
        private Label label7;
        private CheckBox chkActivo;
    }
}
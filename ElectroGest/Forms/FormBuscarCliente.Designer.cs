namespace ElectroGest.Forms
{
    partial class FormBuscarCliente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtBuscar = new TextBox();
            btnSeleccionar = new Button();
            btnCancelar = new Button();
            tabControl3 = new TabControl();
            tabPage7 = new TabPage();
            dgvClientes = new DataGridView();
            tabControl3.SuspendLayout();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 27);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(292, 23);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(12, 390);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(102, 48);
            btnSeleccionar.TabIndex = 1;
            btnSeleccionar.Text = "Agregar Cliente ";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(120, 390);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 48);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(tabPage7);
            tabControl3.Location = new Point(12, 72);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(854, 294);
            tabControl3.TabIndex = 27;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(dgvClientes);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(846, 266);
            tabPage7.TabIndex = 0;
            tabPage7.Text = "Clientes";
            tabPage7.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.RowTemplate.DefaultCellStyle.BackColor = SystemColors.ActiveCaption;
            dgvClientes.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvClientes.Size = new Size(840, 260);
            dgvClientes.TabIndex = 19;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // FormBuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 450);
            Controls.Add(tabControl3);
            Controls.Add(btnCancelar);
            Controls.Add(btnSeleccionar);
            Controls.Add(txtBuscar);
            Name = "FormBuscarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBuscarCliente";
            Load += FormBuscarCliente_Load;
            tabControl3.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Button btnSeleccionar;
        private Button btnCancelar;
        private TabControl tabControl3;
        private TabPage tabPage7;
        private DataGridView dgvClientes;
    }
}
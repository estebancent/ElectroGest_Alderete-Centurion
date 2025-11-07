namespace ElectroGest.Forms
{
    partial class FormCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoria));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label2 = new Label();
            label3 = new Label();
            txtCategoria = new TextBox();
            label1 = new Label();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            btnEditar = new Button();
            label4 = new Label();
            txtDescripcion = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkBoxActivar = new CheckBox();
            tabControlCategorias = new TabControl();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tabControlCategorias.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(50, 60, 50);
            label2.Location = new Point(31, 44);
            label2.Name = "label2";
            label2.Size = new Size(321, 21);
            label2.TabIndex = 31;
            label2.Text = "Añadir Categorias de productos Tecnologicos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(50, 60, 50);
            label3.Location = new Point(31, 81);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 33;
            label3.Text = "Nombre de la categoria:";
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(31, 99);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(261, 23);
            txtCategoria.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(50, 60, 50);
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 30;
            label1.Text = "Gestion de Categorias";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(50, 50, 80);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(195, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 39);
            btnEliminar.TabIndex = 43;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(50, 50, 80);
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.ForeColor = SystemColors.ButtonFace;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(289, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(93, 38);
            btnLimpiar.TabIndex = 41;
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
            btnAgregar.Location = new Point(3, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 37);
            btnAgregar.TabIndex = 39;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 100, 150);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SteelBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = SystemColors.ActiveCaption;
            dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Size = new Size(761, 155);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(50, 50, 80);
            btnEditar.ForeColor = SystemColors.ButtonFace;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(101, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 39);
            btnEditar.TabIndex = 40;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(50, 60, 50);
            label4.Location = new Point(323, 81);
            label4.Name = "label4";
            label4.Size = new Size(183, 15);
            label4.TabIndex = 44;
            label4.Text = "Agrega descripcion de la seccion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(323, 99);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(417, 56);
            txtDescripcion.TabIndex = 45;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAgregar);
            flowLayoutPanel1.Controls.Add(btnEditar);
            flowLayoutPanel1.Controls.Add(btnEliminar);
            flowLayoutPanel1.Controls.Add(btnLimpiar);
            flowLayoutPanel1.Location = new Point(28, 161);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(389, 48);
            flowLayoutPanel1.TabIndex = 47;
            // 
            // checkBoxActivar
            // 
            checkBoxActivar.AutoSize = true;
            checkBoxActivar.FlatAppearance.BorderSize = 0;
            checkBoxActivar.FlatAppearance.CheckedBackColor = Color.Lime;
            checkBoxActivar.FlatStyle = FlatStyle.Popup;
            checkBoxActivar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxActivar.Location = new Point(34, 136);
            checkBoxActivar.Name = "checkBoxActivar";
            checkBoxActivar.Size = new Size(61, 19);
            checkBoxActivar.TabIndex = 48;
            checkBoxActivar.Text = "Activar";
            checkBoxActivar.UseVisualStyleBackColor = true;
            // 
            // tabControlCategorias
            // 
            tabControlCategorias.Controls.Add(tabPage2);
            tabControlCategorias.Location = new Point(28, 215);
            tabControlCategorias.Name = "tabControlCategorias";
            tabControlCategorias.SelectedIndex = 0;
            tabControlCategorias.Size = new Size(775, 189);
            tabControlCategorias.TabIndex = 49;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage2.ForeColor = Color.FromArgb(64, 64, 64);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(767, 161);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Lista de categorias ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 449);
            Controls.Add(tabControlCategorias);
            Controls.Add(checkBoxActivar);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtCategoria);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            Load += FormCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tabControlCategorias.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private TextBox txtCategoria;
        private Label label1;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnAgregar;
        private Button btnEditar;
        private Label label4;
        private TextBox txtDescripcion;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBoxActivar;
        private DataGridView dataGridView1;
        private TabControl tabControlCategorias;
        private TabPage tabPage2;
    }
}
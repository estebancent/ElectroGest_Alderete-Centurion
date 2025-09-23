namespace ElectroGest.Forms
{
    partial class BackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
            textBox1 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label1 = new Label();
            tabPage1 = new TabPage();
            tabControl1 = new TabControl();
            Usuario = new DataGridViewTextBoxColumn();
            Ubicacion = new DataGridViewTextBoxColumn();
            Archivo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            label2 = new Label();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(66, 155);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(287, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "C:Backups/TallerProgramacion/2025";
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(364, 149);
            button2.Name = "button2";
            button2.Size = new Size(88, 33);
            button2.TabIndex = 4;
            button2.Text = "Examinar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(50, 60, 50);
            label3.Location = new Point(61, 131);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 5;
            label3.Text = "Seleccion lugar de destino:\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(50, 60, 50);
            label1.Location = new Point(61, 44);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Backup";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(519, 106);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Historial de Backups";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(59, 304);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(527, 134);
            tabControl1.TabIndex = 8;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            // 
            // Ubicacion
            // 
            Ubicacion.HeaderText = "Ubicacion";
            Ubicacion.Name = "Ubicacion";
            // 
            // Archivo
            // 
            Archivo.HeaderText = "Archivo";
            Archivo.Name = "Archivo";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, Archivo, Ubicacion, Usuario });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(513, 100);
            dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(50, 50, 50);
            button3.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Gainsboro;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(242, 212);
            button3.Name = "button3";
            button3.Size = new Size(106, 54);
            button3.TabIndex = 6;
            button3.Text = "Restaurar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 50, 80);
            button1.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(63, 212);
            button1.Name = "button1";
            button1.Size = new Size(150, 54);
            button1.TabIndex = 2;
            button1.Text = "Generar Backup";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(50, 60, 50);
            label2.Location = new Point(61, 86);
            label2.Name = "label2";
            label2.Size = new Size(525, 21);
            label2.TabIndex = 1;
            label2.Text = "“Aquí puede realizar copias de seguridad y restaurarlas en caso necesario”.";
            // 
            // BackupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            ForeColor = Color.Black;
            Name = "BackupForm";
            Text = "buckup";
            Load += BackupForm_Load;
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button2;
        private Label label3;
        private Label label1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Archivo;
        private DataGridViewTextBoxColumn Ubicacion;
        private DataGridViewTextBoxColumn Usuario;
        private TabControl tabControl1;
        private Button button3;
        private Button button1;
        private Label label2;
    }
}
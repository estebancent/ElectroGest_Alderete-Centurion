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
            txtRuta = new TextBox();
            btnExaminar = new Button();
            label3 = new Label();
            label1 = new Label();
            tabPage1 = new TabPage();
            dgvHistorialBackups = new DataGridView();
            tabControl1 = new TabControl();
            btnGenerarBackup = new Button();
            label2 = new Label();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialBackups).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // txtRuta
            // 
            txtRuta.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtRuta.Location = new Point(66, 155);
            txtRuta.Name = "txtRuta";
            txtRuta.ReadOnly = true;
            txtRuta.Size = new Size(287, 23);
            txtRuta.TabIndex = 3;
            // 
            // btnExaminar
            // 
            btnExaminar.ForeColor = Color.Black;
            btnExaminar.Image = (Image)resources.GetObject("btnExaminar.Image");
            btnExaminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnExaminar.Location = new Point(364, 149);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(88, 33);
            btnExaminar.TabIndex = 4;
            btnExaminar.Text = "Examinar";
            btnExaminar.TextAlign = ContentAlignment.MiddleRight;
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
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
            tabPage1.Controls.Add(dgvHistorialBackups);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(721, 106);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Historial de Backups";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvHistorialBackups
            // 
            dgvHistorialBackups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialBackups.Dock = DockStyle.Fill;
            dgvHistorialBackups.Location = new Point(3, 3);
            dgvHistorialBackups.Name = "dgvHistorialBackups";
            dgvHistorialBackups.Size = new Size(715, 100);
            dgvHistorialBackups.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(59, 304);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(729, 134);
            tabControl1.TabIndex = 8;
            // 
            // btnGenerarBackup
            // 
            btnGenerarBackup.BackColor = Color.FromArgb(50, 50, 80);
            btnGenerarBackup.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnGenerarBackup.FlatAppearance.BorderSize = 2;
            btnGenerarBackup.FlatStyle = FlatStyle.Flat;
            btnGenerarBackup.ForeColor = Color.Gainsboro;
            btnGenerarBackup.Image = (Image)resources.GetObject("btnGenerarBackup.Image");
            btnGenerarBackup.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerarBackup.Location = new Point(63, 212);
            btnGenerarBackup.Name = "btnGenerarBackup";
            btnGenerarBackup.Size = new Size(150, 54);
            btnGenerarBackup.TabIndex = 2;
            btnGenerarBackup.Text = "Generar Backup";
            btnGenerarBackup.TextAlign = ContentAlignment.MiddleRight;
            btnGenerarBackup.UseVisualStyleBackColor = false;
            btnGenerarBackup.Click += btnGenerarBackup_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(50, 60, 50);
            label2.Location = new Point(61, 86);
            label2.Name = "label2";
            label2.Size = new Size(301, 21);
            label2.TabIndex = 1;
            label2.Text = "“Aquí puede realizar copias de seguridad”.";
            // 
            // BackupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label3);
            Controls.Add(btnExaminar);
            Controls.Add(txtRuta);
            Controls.Add(btnGenerarBackup);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            ForeColor = Color.Black;
            Name = "BackupForm";
            Text = "buckup";
            Load += BackupForm_Load;
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialBackups).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRuta;
        private Button btnExaminar;
        private Label label3;
        private Label label1;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private Button btnGenerarBackup;
        private Label label2;
        private DataGridView dgvHistorialBackups;
    }
}
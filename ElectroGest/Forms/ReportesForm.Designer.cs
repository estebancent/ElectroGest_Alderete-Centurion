namespace ElectroGest.Forms
{
    partial class ReportesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesForm));
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            VentasCount = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            label5 = new Label();
            groupBox6 = new GroupBox();
            label7 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label8 = new Label();
            groupBox5 = new GroupBox();
            label6 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            pictureBox4 = new PictureBox();
            dataGridView1 = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Vendedor = new DataGridViewTextBoxColumn();
            CantidadProd = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            dateTimePicker3 = new DateTimePicker();
            label9 = new Label();
            dateTimePicker4 = new DateTimePicker();
            comboBox2 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            tabPage3 = new TabPage();
            pictureBox5 = new PictureBox();
            button3 = new Button();
            pictureBox6 = new PictureBox();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dateTimePicker5 = new DateTimePicker();
            label12 = new Label();
            dateTimePicker6 = new DateTimePicker();
            comboBox3 = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            button4 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(51, 18);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(236, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(330, 18);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(240, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 26);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 26);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Hasta:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.RoyalBlue;
            groupBox1.Controls.Add(VentasCount);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(15, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 69);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cantidad de ventas:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // VentasCount
            // 
            VentasCount.AutoSize = true;
            VentasCount.Font = new Font("Cascadia Mono SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VentasCount.ForeColor = SystemColors.ControlLightLight;
            VentasCount.Location = new Point(64, 23);
            VentasCount.Name = "VentasCount";
            VentasCount.Size = new Size(70, 32);
            VentasCount.TabIndex = 0;
            VentasCount.Text = "1500";
            VentasCount.Click += VentasCount_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 355);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(448, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(493, 355);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(414, 219);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MediumSeaGreen;
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(214, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(155, 69);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cantidad de Clientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono SemiBold", 18F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(54, 32);
            label3.Name = "label3";
            label3.Size = new Size(56, 32);
            label3.TabIndex = 0;
            label3.Text = "240";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Orange;
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox3.ForeColor = SystemColors.ControlLightLight;
            groupBox3.Location = new Point(415, 70);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(155, 69);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ingresos totales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.CausesValidation = false;
            label4.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(17, 32);
            label4.Name = "label4";
            label4.Size = new Size(136, 21);
            label4.TabIndex = 0;
            label4.Text = "$89.450.093,50";
            label4.Click += label4_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.MediumAquamarine;
            groupBox4.Controls.Add(label5);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox4.ForeColor = SystemColors.ControlLightLight;
            groupBox4.Location = new Point(407, 155);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(161, 69);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ganancia Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(13, 37);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 0;
            label5.Text = "$42.447.092,61";
            label5.Click += label5_Click;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.Salmon;
            groupBox6.Controls.Add(label7);
            groupBox6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox6.ForeColor = SystemColors.ControlLightLight;
            groupBox6.Location = new Point(214, 70);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(161, 69);
            groupBox6.TabIndex = 11;
            groupBox6.TabStop = false;
            groupBox6.Text = "Dinero Invertido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold);
            label7.Location = new Point(6, 37);
            label7.Name = "label7";
            label7.Size = new Size(136, 21);
            label7.TabIndex = 0;
            label7.Text = "$47.003.000,89";
            // 
            // button1
            // 
            button1.Location = new Point(769, 317);
            button1.Name = "button1";
            button1.Size = new Size(138, 32);
            button1.TabIndex = 12;
            button1.Text = "Exportar PDF";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Teclados", "Mouses", "Laptos", "Celurares", "Auriculares", "Cargadores", "Cables", "Monitores", "Gpu", "Cpu", "Motherboard", "RAM", "Memoria", "Mouse pad" });
            comboBox1.Location = new Point(643, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 23);
            comboBox1.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(576, 24);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 14;
            label8.Text = "Categoria:";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.CornflowerBlue;
            groupBox5.Controls.Add(label6);
            groupBox5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupBox5.ForeColor = SystemColors.ControlLightLight;
            groupBox5.Location = new Point(15, 155);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(161, 69);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Cantidad de productos";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Mono SemiBold", 18F, FontStyle.Bold);
            label6.Location = new Point(48, 37);
            label6.Name = "label6";
            label6.Size = new Size(56, 32);
            label6.TabIndex = 0;
            label6.Text = "450";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(921, 621);
            tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox6);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(groupBox5);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(913, 593);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(dateTimePicker3);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(dateTimePicker4);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label11);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(913, 593);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ventas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(493, 368);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(414, 219);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(769, 330);
            button2.Name = "button2";
            button2.Size = new Size(138, 32);
            button2.TabIndex = 24;
            button2.Text = "Exportar PDF";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(15, 368);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(448, 219);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cliente, Fecha, Vendedor, CantidadProd, Total });
            dataGridView1.Location = new Point(20, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(880, 51);
            dataGridView1.TabIndex = 21;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Vendedor
            // 
            Vendedor.HeaderText = "Vendedor";
            Vendedor.Name = "Vendedor";
            // 
            // CantidadProd
            // 
            CantidadProd.HeaderText = "Cantidad Productos";
            CantidadProd.Name = "CantidadProd";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(366, 27);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(240, 23);
            dateTimePicker3.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(612, 35);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 20;
            label9.Text = "Categoria:";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(73, 27);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(236, 23);
            dateTimePicker4.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Teclados", "Mouses", "Laptos", "Celurares", "Auriculares", "Cargadores", "Cables", "Monitores", "Gpu", "Cpu", "Motherboard", "RAM", "Memoria", "Mouse pad" });
            comboBox2.Location = new Point(684, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(216, 23);
            comboBox2.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 35);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 17;
            label10.Text = "Desde:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(315, 35);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 18;
            label11.Text = "Hasta:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(pictureBox5);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(pictureBox6);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(dateTimePicker5);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(dateTimePicker6);
            tabPage3.Controls.Add(comboBox3);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label14);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(913, 593);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Compras";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(493, 368);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(414, 219);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(769, 330);
            button3.Name = "button3";
            button3.Size = new Size(138, 32);
            button3.TabIndex = 25;
            button3.Text = "Exportar PDF";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(15, 368);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(448, 219);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView2.Location = new Point(15, 106);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(880, 51);
            dataGridView2.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Usuario";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Proveedor";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Cantidad Productos";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Total";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Location = new Point(361, 19);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(240, 23);
            dateTimePicker5.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(607, 27);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 20;
            label12.Text = "Categoria:";
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Location = new Point(68, 19);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(236, 23);
            dateTimePicker6.TabIndex = 15;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Teclados", "Mouses", "Laptos", "Celurares", "Auriculares", "Cargadores", "Cables", "Monitores", "Gpu", "Cpu", "Motherboard", "RAM", "Memoria", "Mouse pad" });
            comboBox3.Location = new Point(679, 19);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(216, 23);
            comboBox3.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 27);
            label13.Name = "label13";
            label13.Size = new Size(42, 15);
            label13.TabIndex = 17;
            label13.Text = "Desde:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(310, 27);
            label14.Name = "label14";
            label14.Size = new Size(40, 15);
            label14.TabIndex = 18;
            label14.Text = "Hasta:";
            // 
            // button4
            // 
            button4.Location = new Point(814, 16);
            button4.Name = "button4";
            button4.Size = new Size(93, 25);
            button4.TabIndex = 15;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // ReportesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(945, 645);
            Controls.Add(tabControl1);
            Name = "ReportesForm";
            Text = "ReportesForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label VentasCount;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button button1;
        private ComboBox comboBox1;
        private Label label8;
        private GroupBox groupBox5;
        private Label label6;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DateTimePicker dateTimePicker3;
        private Label label9;
        private DateTimePicker dateTimePicker4;
        private ComboBox comboBox2;
        private Label label10;
        private Label label11;
        private TabPage tabPage3;
        private DateTimePicker dateTimePicker5;
        private Label label12;
        private DateTimePicker dateTimePicker6;
        private ComboBox comboBox3;
        private Label label13;
        private Label label14;
        private DataGridView dataGridView1;
        private PictureBox pictureBox3;
        private Button button2;
        private PictureBox pictureBox4;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Vendedor;
        private DataGridViewTextBoxColumn CantidadProd;
        private DataGridViewTextBoxColumn Total;
        private PictureBox pictureBox5;
        private Button button3;
        private PictureBox pictureBox6;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button button4;
    }
}
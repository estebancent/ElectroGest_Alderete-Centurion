namespace ElectroGest.Forms
{
    partial class VentasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasForm));
            groupBox1 = new GroupBox();
            btnEditar = new Button();
            LbBusqueda = new Label();
            textBox11 = new TextBox();
            btnAgregar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnLimpiar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            comboBox1 = new ComboBox();
            label17 = new Label();
            label16 = new Label();
            textBox12 = new TextBox();
            label15 = new Label();
            textBox6 = new TextBox();
            button3 = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            dataGridView1 = new DataGridView();
            codProd = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            button4 = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            button2 = new Button();
            textBox10 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            tabPage2 = new TabPage();
            label18 = new Label();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            label19 = new Label();
            dataGridView2 = new DataGridView();
            FechaVenta = new DataGridViewTextBoxColumn();
            TotalVenta = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(LbBusqueda);
            groupBox1.Controls.Add(textBox11);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(16, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1015, 146);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Goldenrod;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(871, 72);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(118, 34);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar cliente";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // LbBusqueda
            // 
            LbBusqueda.AutoSize = true;
            LbBusqueda.Location = new Point(6, 26);
            LbBusqueda.Name = "LbBusqueda";
            LbBusqueda.Size = new Size(124, 15);
            LbBusqueda.TabIndex = 12;
            LbBusqueda.Text = "Buscar cliente por DNI";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(63, 112);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(677, 23);
            textBox11.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkSeaGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(871, 21);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(118, 34);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Seleccionar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(502, 62);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 10;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 91);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 8;
            label3.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 91);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 7;
            label2.Text = "DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 57);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // button1
            // 
            button1.Location = new Point(502, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(379, 83);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(361, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(562, 54);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(178, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(63, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(237, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(63, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(433, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 22);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese DNI del cliente";
            textBox1.Size = new Size(360, 23);
            textBox1.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.BurlyWood;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(849, 67);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 34);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar datos";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1045, 644);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1037, 616);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registrar venta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(textBox12);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(16, 286);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1015, 324);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Venta";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Efectivo", "Transferencia", "Tarjeta de debito\t", "Tarjeta de credito", "QR" });
            comboBox1.Location = new Point(102, 291);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 297);
            label17.Name = "label17";
            label17.Size = new Size(90, 15);
            label17.TabIndex = 12;
            label17.Text = "Forma de pago:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(272, 297);
            label16.Name = "label16";
            label16.Size = new Size(65, 15);
            label16.TabIndex = 11;
            label16.Text = "Recarga: %";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(343, 289);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(60, 23);
            textBox12.TabIndex = 10;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(417, 297);
            label15.Name = "label15";
            label15.Size = new Size(79, 15);
            label15.TabIndex = 9;
            label15.Text = "Descuento: %";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(502, 289);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(60, 23);
            textBox6.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(878, 291);
            button3.Name = "button3";
            button3.Size = new Size(131, 23);
            button3.TabIndex = 7;
            button3.Text = "Confirmar compra";
            button3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(150, 23);
            label14.Name = "label14";
            label14.Size = new Size(150, 15);
            label14.TabIndex = 6;
            label14.Text = "Vendedor: Luciano Romero";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 23);
            label13.Name = "label13";
            label13.Size = new Size(105, 15);
            label13.TabIndex = 5;
            label13.Text = "Cliente: Juan Perez";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 50);
            label12.Name = "label12";
            label12.Size = new Size(184, 15);
            label12.TabIndex = 4;
            label12.Text = "Lista de productos seleccionados:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(725, 297);
            label11.Name = "label11";
            label11.Size = new Size(134, 15);
            label11.TabIndex = 3;
            label11.Text = "Total a pagar: $10.000,00";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codProd, Producto, Cantidad, Precio, Total });
            dataGridView1.Location = new Point(6, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1003, 199);
            dataGridView1.TabIndex = 2;
            // 
            // codProd
            // 
            codProd.HeaderText = "Codigo Producto";
            codProd.Name = "codProd";
            // 
            // Producto
            // 
            Producto.HeaderText = "Nombre producto";
            Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio por unidad";
            Precio.Name = "Precio";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(textBox14);
            groupBox2.Controls.Add(textBox13);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(btnLimpiar);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Location = new Point(16, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1015, 122);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Producto";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSeaGreen;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(849, 15);
            button4.Name = "button4";
            button4.Size = new Size(140, 34);
            button4.TabIndex = 17;
            button4.Text = "Agregar al carrito";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(253, 91);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 18;
            label10.Text = "Precio por unidad";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 86);
            label9.Name = "label9";
            label9.Size = new Size(94, 15);
            label9.TabIndex = 17;
            label9.Text = "Stock disponible";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 60);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 16;
            label8.Text = "Nombre de Producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 19);
            label7.Name = "label7";
            label7.Size = new Size(155, 15);
            label7.TabIndex = 15;
            label7.Text = "Buscar producto por codigo";
            // 
            // button2
            // 
            button2.Location = new Point(544, 15);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(178, 14);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "Ingrese codigo del producto";
            textBox10.Size = new Size(360, 23);
            textBox10.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(360, 83);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(178, 23);
            textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(117, 83);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(130, 23);
            textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(142, 54);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(396, 23);
            textBox9.TabIndex = 6;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1037, 616);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lista de Ventas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(544, 91);
            label18.Name = "label18";
            label18.Size = new Size(126, 15);
            label18.TabIndex = 19;
            label18.Text = "Cantidad seleccionada";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(676, 83);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(100, 23);
            textBox13.TabIndex = 20;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(676, 52);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(100, 23);
            textBox14.TabIndex = 21;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(544, 62);
            label19.Name = "label19";
            label19.Size = new Size(84, 15);
            label19.TabIndex = 22;
            label19.Text = "Cod. Producto";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { FechaVenta, TotalVenta });
            dataGridView2.Location = new Point(18, 107);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1002, 150);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // FechaVenta
            // 
            FechaVenta.HeaderText = "Fecha";
            FechaVenta.Name = "FechaVenta";
            // 
            // TotalVenta
            // 
            TotalVenta.HeaderText = "Total";
            TotalVenta.Name = "TotalVenta";
            // 
            // VentasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1060, 660);
            Controls.Add(tabControl1);
            Name = "VentasForm";
            Text = "VentasForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox11;
        private Label LbBusqueda;
        private Label label7;
        private Button button2;
        private TextBox textBox10;
        private Label label9;
        private Label label8;
        private Label label10;
        private Button btnLimpiar;
        private Button btnAgregar;
        private GroupBox groupBox3;
        private Button btnEditar;
        private Label label12;
        private Label label11;
        private Button button3;
        private Label label14;
        private Label label13;
        private Button button4;
        private DataGridViewTextBoxColumn codProd;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total;
        private Label label17;
        private Label label16;
        private TextBox textBox12;
        private Label label15;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private Label label19;
        private TextBox textBox14;
        private TextBox textBox13;
        private Label label18;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn FechaVenta;
        private DataGridViewTextBoxColumn TotalVenta;
    }
}
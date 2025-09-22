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
            label6 = new Label();
            textBox11 = new TextBox();
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
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
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(label6);
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
            groupBox1.Location = new Point(16, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(854, 146);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 26);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 12;
            label6.Text = "Buscar cliente por DNI";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(63, 112);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(677, 23);
            textBox11.TabIndex = 11;
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1008, 567);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1000, 539);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registrar venta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidad, Precio, Total });
            dataGridView1.Location = new Point(16, 348);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(835, 185);
            dataGridView1.TabIndex = 2;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Location = new Point(16, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(835, 122);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Producto";
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
            label9.Location = new Point(17, 91);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 17;
            label9.Text = "Cantidad disponible";
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
            textBox8.Location = new Point(142, 83);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(105, 23);
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1000, 539);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lista de Ventas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkSeaGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(757, 15);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(91, 34);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Goldenrod;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(660, 16);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(91, 34);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(757, 62);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 34);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.BurlyWood;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(757, 106);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 34);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // VentasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1032, 591);
            Controls.Add(tabControl1);
            Name = "VentasForm";
            Text = "VentasForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total;
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
        private Label label6;
        private Label label7;
        private Button button2;
        private TextBox textBox10;
        private Label label9;
        private Label label8;
        private Label label10;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnAgregar;
    }
}
namespace ElectroGest.Forms
{
    partial class FormFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactura));
            dgvDetalleVentas = new DataGridView();
            lblNumeroFactura = new Label();
            lblFecha = new Label();
            lblCliente = new Label();
            lblVendedor = new Label();
            lblTotal = new Label();
            lblEstado = new Label();
            lblObservaciones = new Label();
            btnExportarPdf = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblFormaPago = new Label();
            lblTotalFinal = new Label();
            label9 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVentas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDetalleVentas
            // 
            dgvDetalleVentas.BackgroundColor = SystemColors.ButtonFace;
            dgvDetalleVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVentas.Location = new Point(1, 130);
            dgvDetalleVentas.Name = "dgvDetalleVentas";
            dgvDetalleVentas.Size = new Size(797, 243);
            dgvDetalleVentas.TabIndex = 0;
            // 
            // lblNumeroFactura
            // 
            lblNumeroFactura.AutoSize = true;
            lblNumeroFactura.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblNumeroFactura.ForeColor = Color.FromArgb(50, 50, 55);
            lblNumeroFactura.Location = new Point(116, 40);
            lblNumeroFactura.Name = "lblNumeroFactura";
            lblNumeroFactura.Size = new Size(40, 17);
            lblNumeroFactura.TabIndex = 1;
            lblNumeroFactura.Text = "fecha";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblFecha.ForeColor = Color.FromArgb(50, 50, 55);
            lblFecha.Location = new Point(70, 11);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(40, 17);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "fecha";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblCliente.ForeColor = Color.FromArgb(50, 50, 55);
            lblCliente.Location = new Point(80, 72);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 17);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "cliente";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblVendedor.ForeColor = Color.FromArgb(50, 50, 55);
            lblVendedor.Location = new Point(360, 11);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(66, 17);
            lblVendedor.TabIndex = 4;
            lblVendedor.Text = "vendedor";
            lblVendedor.Click += lblVendedor_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(648, 380);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 17);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblEstado.ForeColor = Color.FromArgb(50, 50, 55);
            lblEstado.Location = new Point(343, 72);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(49, 17);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "estado";
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblObservaciones.ForeColor = Color.FromArgb(50, 50, 55);
            lblObservaciones.Location = new Point(530, 28);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(82, 17);
            lblObservaciones.TabIndex = 8;
            lblObservaciones.Text = "observacion";
            // 
            // btnExportarPdf
            // 
            btnExportarPdf.Cursor = Cursors.Hand;
            btnExportarPdf.FlatAppearance.BorderSize = 0;
            btnExportarPdf.FlatStyle = FlatStyle.Flat;
            btnExportarPdf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportarPdf.Image = (Image)resources.GetObject("btnExportarPdf.Image");
            btnExportarPdf.ImageAlign = ContentAlignment.MiddleRight;
            btnExportarPdf.Location = new Point(12, 391);
            btnExportarPdf.Name = "btnExportarPdf";
            btnExportarPdf.Size = new Size(184, 47);
            btnExportarPdf.TabIndex = 9;
            btnExportarPdf.Text = "Exportar Factura";
            btnExportarPdf.TextAlign = ContentAlignment.MiddleLeft;
            btnExportarPdf.UseVisualStyleBackColor = true;
            btnExportarPdf.Click += BtnExportarPDF_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(27, 40);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 10;
            label1.Text = "Nro Factura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(27, 11);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 11;
            label2.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(27, 72);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 12;
            label3.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(286, 11);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 13;
            label4.Text = "Vendedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(286, 40);
            label5.Name = "label5";
            label5.Size = new Size(104, 17);
            label5.TabIndex = 14;
            label5.Text = "Forma de Pago:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(285, 72);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 15;
            label6.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.Location = new Point(512, 11);
            label7.Name = "label7";
            label7.Size = new Size(100, 17);
            label7.TabIndex = 16;
            label7.Text = "Observaciones:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(593, 376);
            label8.Name = "label8";
            label8.Size = new Size(49, 21);
            label8.TabIndex = 17;
            label8.Text = "Total:";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblFormaPago.ForeColor = Color.FromArgb(50, 50, 55);
            lblFormaPago.Location = new Point(396, 40);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(39, 17);
            lblFormaPago.TabIndex = 18;
            lblFormaPago.Text = "pago";
            // 
            // lblTotalFinal
            // 
            lblTotalFinal.AutoSize = true;
            lblTotalFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalFinal.Location = new Point(642, 406);
            lblTotalFinal.Name = "lblTotalFinal";
            lblTotalFinal.Size = new Size(42, 21);
            lblTotalFinal.TabIndex = 19;
            lblTotalFinal.Text = "Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(392, 405);
            label9.Name = "label9";
            label9.Size = new Size(250, 21);
            label9.TabIndex = 20;
            label9.Text = "Total Final Descuentos/Recargos:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblNumeroFactura);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblFormaPago);
            panel1.Controls.Add(lblCliente);
            panel1.Controls.Add(lblVendedor);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblEstado);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblObservaciones);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 100);
            panel1.TabIndex = 21;
            // 
            // FormFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(lblTotalFinal);
            Controls.Add(label8);
            Controls.Add(btnExportarPdf);
            Controls.Add(lblTotal);
            Controls.Add(dgvDetalleVentas);
            Name = "FormFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle de Venta";
            Load += FormFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVentas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDetalleVentas;
        private Label lblNumeroFactura;
        private Label lblFecha;
        private Label lblCliente;
        private Label lblVendedor;
        private Label lblTotal;
        private Label lblEstado;
        private Label lblObservaciones;
        private Button btnExportarPdf;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblFormaPago;
        private Label lblTotalFinal;
        private Label label9;
        private Panel panel1;
    }
}
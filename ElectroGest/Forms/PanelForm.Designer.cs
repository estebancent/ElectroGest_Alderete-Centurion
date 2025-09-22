namespace ElectroGest.Forms
{
    partial class PanelForm
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            colorDialog1 = new ColorDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 788);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(269, 352);
            label4.Name = "label4";
            label4.Size = new Size(337, 30);
            label4.TabIndex = 7;
            label4.Text = " productos, clientes y muchos màs.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 313);
            label3.Name = "label3";
            label3.Size = new Size(718, 30);
            label3.TabIndex = 6;
            label3.Text = "Bienvenido a Electrogest Alderete Cent, tu sistema para gestionar tus ventas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSeaGreen;
            label1.Location = new Point(369, 251);
            label1.Name = "label1";
            label1.Size = new Size(184, 19);
            label1.TabIndex = 4;
            label1.Text = "Electrogest Alderete Cent";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_neo_cryptocurrency_48;
            pictureBox2.Location = new Point(322, 237);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(242, 55);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // PanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1000, 788);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "PanelForm";
            Text = "PanelForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ColorDialog colorDialog1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label1;
        private Label label4;
    }
}
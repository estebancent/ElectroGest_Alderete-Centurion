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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_neo_cryptocurrency_48;
            pictureBox1.Location = new Point(227, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 47);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(275, 281);
            label2.Name = "label2";
            label2.Size = new Size(436, 21);
            label2.TabIndex = 3;
            label2.Text = "“Aquí puede realizar gestion de usuarios, productos y ventas”.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(313, 226);
            label5.Name = "label5";
            label5.Size = new Size(341, 25);
            label5.TabIndex = 2;
            label5.Text = "Bienvenido a ElectroGest Alderete Cent";
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
            BackColor = Color.FromArgb(50, 50, 60);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1000, 788);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "PanelForm";
            Text = "PanelForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColorDialog colorDialog1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
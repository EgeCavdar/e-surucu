namespace WinFormsApp1
{
    partial class Form0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(563, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(546, 34);
            label1.TabIndex = 0;
            label1.Text = "E-Sürücü Sistemi Ana Sayfasına Hoşgeldiniz";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(189, 515);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(259, 302);
            button1.TabIndex = 2;
            button1.Text = "SÜRÜCÜ\r\nADAYI\r\n\r\nGİRİŞİ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            button1.MouseMove += button1_MouseMove;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(563, 515);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(259, 302);
            button2.TabIndex = 3;
            button2.Text = "SÜRÜCÜ\r\nKURSU\r\n\r\nGİRİŞİ\r\n";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            button3.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(940, 515);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(259, 302);
            button3.TabIndex = 4;
            button3.Text = "MEB\r\n\r\nGİRİŞİ\r\n";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(1289, 515);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(259, 302);
            button4.TabIndex = 5;
            button4.Text = "T.C.\r\nNÜFUS MÜDÜRLÜĞÜ\r\n\r\nGİRİŞİ\r\n";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightCyan;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(189, 120);
            label2.Name = "label2";
            label2.Size = new Size(1209, 360);
            label2.TabIndex = 7;
            label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1466, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // Form0
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 44, 52);
            BackgroundImage = Properties.Resources.timthumb;
            ClientSize = new Size(1597, 816);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form0";
            Text = "E-Sürücü";
            Load += Form0_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}
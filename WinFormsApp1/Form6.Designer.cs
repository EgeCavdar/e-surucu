namespace WinFormsApp1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            listBox2 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            button4 = new Button();
            richTextBox2 = new RichTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(503, 9);
            label2.Name = "label2";
            label2.Padding = new Padding(1);
            label2.Size = new Size(324, 74);
            label2.TabIndex = 10;
            label2.Text = "MEB Girişi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(27, 103);
            label1.Name = "label1";
            label1.Size = new Size(305, 41);
            label1.TabIndex = 12;
            label1.Text = "Sürücü Aday Bilgileri";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = Color.Black;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(27, 148);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(547, 619);
            listBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(603, 147);
            button1.Name = "button1";
            button1.Size = new Size(269, 264);
            button1.TabIndex = 15;
            button1.Text = "SINAV SONUÇLARINI GİR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(897, 147);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(490, 264);
            listBox2.TabIndex = 16;
            // 
            // button2
            // 
            button2.Location = new Point(603, 429);
            button2.Name = "button2";
            button2.Size = new Size(205, 338);
            button2.TabIndex = 17;
            button2.Text = "T.C. NÜFUS MÜDÜRLÜĞÜ'NDEN ONAY İSTE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(837, 555);
            button3.Name = "button3";
            button3.Size = new Size(269, 212);
            button3.TabIndex = 18;
            button3.Text = "YENİ TEORİK SINAV TARİHİNİ  BELİRLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(837, 429);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(269, 120);
            richTextBox1.TabIndex = 19;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // button4
            // 
            button4.Location = new Point(1131, 555);
            button4.Name = "button4";
            button4.Size = new Size(269, 212);
            button4.TabIndex = 20;
            button4.Text = "YENİ DİREKSİYON SINAV TARİHİNİ BELİRLE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(1131, 429);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(269, 120);
            richTextBox2.TabIndex = 21;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1412, 767);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox2);
            Controls.Add(button4);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label label2;
        private Label label1;
        public ListBox listBox1;
        private Button button1;
        private ListBox listBox2;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox1;
        private Button button4;
        private RichTextBox richTextBox2;
        private PictureBox pictureBox1;
    }
}
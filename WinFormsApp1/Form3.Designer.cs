namespace WinFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            comboBoxsehir = new ComboBox();
            label1 = new Label();
            comboBoxilce = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox1 = new CheckBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // comboBoxsehir
            // 
            comboBoxsehir.BackColor = Color.White;
            comboBoxsehir.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxsehir.ForeColor = SystemColors.WindowText;
            comboBoxsehir.FormattingEnabled = true;
            comboBoxsehir.Location = new Point(299, 128);
            comboBoxsehir.Margin = new Padding(3, 2, 3, 2);
            comboBoxsehir.Name = "comboBoxsehir";
            comboBoxsehir.Size = new Size(288, 50);
            comboBoxsehir.TabIndex = 0;
            comboBoxsehir.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 131);
            label1.Name = "label1";
            label1.Size = new Size(186, 42);
            label1.TabIndex = 1;
            label1.Text = "İl Seçiniz :";
            label1.Click += label1_Click;
            // 
            // comboBoxilce
            // 
            comboBoxilce.BackColor = Color.White;
            comboBoxilce.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxilce.ForeColor = SystemColors.WindowText;
            comboBoxilce.FormattingEnabled = true;
            comboBoxilce.Location = new Point(299, 194);
            comboBoxilce.Margin = new Padding(3, 2, 3, 2);
            comboBoxilce.Name = "comboBoxilce";
            comboBoxilce.Size = new Size(288, 50);
            comboBoxilce.TabIndex = 2;
            comboBoxilce.SelectedIndexChanged += comboBoxilce_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 197);
            label2.Name = "label2";
            label2.Size = new Size(226, 42);
            label2.TabIndex = 3;
            label2.Text = "İlçe Seçiniz :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(621, 88);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(192, 156);
            button1.TabIndex = 4;
            button1.Text = "SORGULA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Teal;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = SystemColors.ButtonHighlight;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 45;
            listBox1.Location = new Point(0, 280);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(839, 182);
            listBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(34, 481);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(220, 220);
            button2.TabIndex = 6;
            button2.Text = "KAYIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Calibri", 21.75F, FontStyle.Underline, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(835, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(769, 656);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Teorik Eğitimler";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(390, 487);
            label8.Name = "label8";
            label8.Size = new Size(370, 76);
            label8.TabIndex = 17;
            label8.Text = resources.GetString("label8.Text");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(390, 451);
            label7.Name = "label7";
            label7.Size = new Size(257, 23);
            label7.TabIndex = 16;
            label7.Text = "MOTOR VE ARAÇ TEKNİĞİ DERSİ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(390, 98);
            label5.Name = "label5";
            label5.Size = new Size(345, 133);
            label5.TabIndex = 15;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(390, 53);
            label6.Name = "label6";
            label6.Size = new Size(212, 23);
            label6.TabIndex = 14;
            label6.Text = "İLK YARDIM BİLGİSİ DERSİ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(389, 297);
            label4.Name = "label4";
            label4.Size = new Size(378, 114);
            label4.TabIndex = 13;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(389, 250);
            label3.Name = "label3";
            label3.Size = new Size(253, 23);
            label3.TabIndex = 12;
            label3.Text = "TRAFİK VE ÇEVRE BİLGİSİ DERSİ\r\n";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(652, 456);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 10;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox3.Location = new Point(609, 58);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(15, 14);
            checkBox3.TabIndex = 11;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(649, 256);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 9;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.timthumb__3_;
            pictureBox3.Location = new Point(31, 451);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(353, 190);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(31, 250);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(353, 186);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(132, 110);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(266, 486);
            label9.Name = "label9";
            label9.Size = new Size(563, 147);
            label9.TabIndex = 9;
            label9.Text = resources.GetString("label9.Text");
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.gradientcolors;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1616, 715);
            Controls.Add(label9);
            Controls.Add(pictureBox4);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBoxilce);
            Controls.Add(label1);
            Controls.Add(comboBoxsehir);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "E-Sürücü";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxsehir;
        private Label label1;
        private ComboBox comboBoxilce;
        private Label label2;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox1;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label9;
    }
}
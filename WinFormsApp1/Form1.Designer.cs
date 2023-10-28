namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(19, 560);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(206, 127);
            button1.TabIndex = 0;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(123, 258);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.MaxLength = 11;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 32);
            textBox1.TabIndex = 1;
            textBox1.Text = "TCKN Giriniz...";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.MouseHover += textBox1_MouseHover;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" });
            comboBox1.Location = new Point(104, 115);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(143, 33);
            comboBox1.TabIndex = 2;
            comboBox1.KeyPress += comboBox1_KeyPress;
            comboBox1.Validating += comboBox1_Validating;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBox2.Location = new Point(104, 58);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(102, 33);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox2.KeyPress += comboBox2_KeyPress;
            comboBox2.Validating += comboBox2_Validating;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(104, 173);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 2005, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1881, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(166, 32);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 2005, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(19, 313);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(373, 243);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doğum Tarihi Bilgisi";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(38, 173);
            label7.Name = "label7";
            label7.Size = new Size(44, 25);
            label7.TabIndex = 7;
            label7.Text = "Yıl :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(38, 116);
            label6.Name = "label6";
            label6.Size = new Size(45, 25);
            label6.TabIndex = 6;
            label6.Text = "Ay :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 58);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 5;
            label5.Text = "Gün :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(728, 32);
            label1.Name = "label1";
            label1.Padding = new Padding(1);
            label1.Size = new Size(451, 61);
            label1.TabIndex = 6;
            label1.Text = "Sürücü Adayı Girişi";
            // 
            // toolTip2
            // 
            toolTip2.Popup += toolTip2_Popup;
            // 
            // label2
            // 
            label2.BackColor = Color.Teal;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(539, 434);
            label2.Name = "label2";
            label2.Size = new Size(1000, 30);
            label2.TabIndex = 7;
            label2.Text = "*Girdiğiniz bilgilerin doğruluğunu kontrol ediniz, girişinizi yaptıktan sonra başka bir sayfaya aktarılacaksınız.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(539, 502);
            label3.Name = "label3";
            label3.Size = new Size(905, 30);
            label3.TabIndex = 8;
            label3.Text = "*Sürücü kursunuza kayıt olmadan önce herhangi bir sağlık merkezinden sağlık raporunuzu alınız.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(42, 261);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 9;
            label4.Text = "TCKN :";
            label4.Click += label4_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.timthumb__1_;
            pictureBox2.Location = new Point(414, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1258, 712);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(123, 133);
            label8.Name = "label8";
            label8.Size = new Size(96, 42);
            label8.TabIndex = 14;
            label8.Text = "label8";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(123, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 33);
            textBox3.TabIndex = 15;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(5, 213);
            label9.Name = "label9";
            label9.Size = new Size(108, 25);
            label9.TabIndex = 16;
            label9.Text = "Sayı Girişi :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1672, 707);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "E-Sürücü";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private Label label2;
        private Label label3;
        private Label label4;
        private ErrorProvider errorProvider1;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
    }
}
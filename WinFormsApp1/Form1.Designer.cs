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
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            groupBox2 = new GroupBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox9 = new PictureBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            listBox1 = new ListBox();
            button2 = new Button();
            label2 = new Label();
            comboBoxilce = new ComboBox();
            label3 = new Label();
            comboBoxsehir = new ComboBox();
            groupBox3 = new GroupBox();
            button3 = new Button();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(14, 779);
            button1.Name = "button1";
            button1.Size = new Size(213, 105);
            button1.TabIndex = 0;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(169, 227);
            textBox1.MaxLength = 11;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 38);
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
            comboBox1.Location = new Point(119, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 39);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.KeyPress += comboBox1_KeyPress;
            comboBox1.Validating += comboBox1_Validating;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBox2.Location = new Point(119, 73);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(116, 39);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox2.KeyPress += comboBox2_KeyPress;
            comboBox2.Validating += comboBox2_Validating;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(119, 231);
            numericUpDown1.Maximum = new decimal(new int[] { 2005, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1881, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(190, 38);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 2005, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
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
            groupBox1.Location = new Point(23, 292);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 324);
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
            label7.Location = new Point(43, 231);
            label7.Name = "label7";
            label7.Size = new Size(54, 31);
            label7.TabIndex = 7;
            label7.Text = "Yıl :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(43, 155);
            label6.Name = "label6";
            label6.Size = new Size(54, 31);
            label6.TabIndex = 6;
            label6.Text = "Ay :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 77);
            label5.Name = "label5";
            label5.Size = new Size(70, 31);
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
            label1.Location = new Point(760, 12);
            label1.Name = "label1";
            label1.Padding = new Padding(1);
            label1.Size = new Size(562, 74);
            label1.TabIndex = 6;
            label1.Text = "Sürücü Adayı Girişi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(65, 229);
            label4.Name = "label4";
            label4.Size = new Size(91, 32);
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
            pictureBox1.Location = new Point(-2, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(158, 76);
            label8.Name = "label8";
            label8.Size = new Size(122, 52);
            label8.TabIndex = 14;
            label8.Text = "label8";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(169, 162);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 39);
            textBox3.TabIndex = 15;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(23, 165);
            label9.Name = "label9";
            label9.Size = new Size(140, 32);
            label9.TabIndex = 16;
            label9.Text = "Sayı Girişi :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(pictureBox8);
            groupBox2.Controls.Add(pictureBox7);
            groupBox2.Controls.Add(pictureBox6);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox9);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton8);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(599, 132);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(511, 804);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ehliyet Tipini Seçiniz";
            groupBox2.UseCompatibleTextRendering = true;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = SystemColors.ButtonHighlight;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(232, 669);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(103, 96);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 27;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = SystemColors.ButtonHighlight;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(231, 585);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(103, 100);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 26;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ButtonHighlight;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(231, 485);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(103, 100);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ButtonHighlight;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(231, 389);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(103, 100);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonHighlight;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(232, 52);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(103, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(232, 296);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(103, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(232, 211);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = SystemColors.ButtonHighlight;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(232, 121);
            pictureBox9.Margin = new Padding(3, 4, 3, 4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(103, 100);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 21;
            pictureBox9.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Font = new Font("Calibri", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.ForeColor = SystemColors.ButtonHighlight;
            radioButton3.Location = new Point(23, 145);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(77, 68);
            radioButton3.TabIndex = 15;
            radioButton3.Text = "B";
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.Font = new Font("Calibri", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton4.ForeColor = SystemColors.ButtonHighlight;
            radioButton4.Location = new Point(23, 300);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(76, 68);
            radioButton4.TabIndex = 16;
            radioButton4.Text = "C";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.BackColor = Color.Transparent;
            radioButton5.Font = new Font("Calibri", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton5.ForeColor = SystemColors.ButtonHighlight;
            radioButton5.Location = new Point(23, 399);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(107, 68);
            radioButton5.TabIndex = 17;
            radioButton5.Text = "D1";
            radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.BackColor = Color.Transparent;
            radioButton6.Font = new Font("Calibri", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton6.ForeColor = SystemColors.ButtonHighlight;
            radioButton6.Location = new Point(23, 485);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(81, 68);
            radioButton6.TabIndex = 18;
            radioButton6.Text = "D";
            radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.BackColor = Color.Transparent;
            radioButton7.Font = new Font("Calibri", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton7.ForeColor = SystemColors.ButtonHighlight;
            radioButton7.Location = new Point(23, 585);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(72, 68);
            radioButton7.TabIndex = 19;
            radioButton7.Text = "F";
            radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.BackColor = Color.Transparent;
            radioButton8.Font = new Font("Calibri", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton8.ForeColor = SystemColors.ButtonHighlight;
            radioButton8.Location = new Point(23, 663);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(93, 68);
            radioButton8.TabIndex = 20;
            radioButton8.Text = "M";
            radioButton8.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Calibri", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(23, 223);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(102, 68);
            radioButton2.TabIndex = 14;
            radioButton2.Text = "C1";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Calibri", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(23, 68);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(106, 68);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "A2";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(40, 107, 113);
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = SystemColors.ButtonHighlight;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 57;
            listBox1.Location = new Point(1151, 513);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(632, 401);
            listBox1.TabIndex = 23;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(2079, 200);
            button2.Name = "button2";
            button2.Size = new Size(219, 208);
            button2.TabIndex = 22;
            button2.Text = "SORGULA";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1151, 404);
            label2.Name = "label2";
            label2.Size = new Size(284, 54);
            label2.TabIndex = 21;
            label2.Text = "İlçe Seçiniz :";
            // 
            // comboBoxilce
            // 
            comboBoxilce.BackColor = Color.White;
            comboBoxilce.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxilce.ForeColor = SystemColors.WindowText;
            comboBoxilce.FormattingEnabled = true;
            comboBoxilce.Location = new Point(1454, 418);
            comboBoxilce.Name = "comboBoxilce";
            comboBoxilce.Size = new Size(329, 39);
            comboBoxilce.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1151, 316);
            label3.Name = "label3";
            label3.Size = new Size(234, 54);
            label3.TabIndex = 19;
            label3.Text = "İl Seçiniz :";
            // 
            // comboBoxsehir
            // 
            comboBoxsehir.BackColor = Color.White;
            comboBoxsehir.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxsehir.ForeColor = SystemColors.WindowText;
            comboBoxsehir.FormattingEnabled = true;
            comboBoxsehir.Location = new Point(1454, 330);
            comboBoxsehir.Name = "comboBoxsehir";
            comboBoxsehir.Size = new Size(329, 39);
            comboBoxsehir.TabIndex = 18;
            comboBoxsehir.SelectedIndexChanged += comboBoxsehir_SelectedIndexChanged_1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(14, 131);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(538, 641);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kişisel Bilgiler";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(272, 779);
            button3.Name = "button3";
            button3.Size = new Size(219, 105);
            button3.TabIndex = 25;
            button3.Text = "SORGULA";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Font = new Font("Monotype Corsiva", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(1151, 155);
            label10.Name = "label10";
            label10.Size = new Size(286, 99);
            label10.TabIndex = 26;
            label10.Text = "TUTAR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1911, 1051);
            Controls.Add(label10);
            Controls.Add(button3);
            Controls.Add(groupBox3);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(comboBoxilce);
            Controls.Add(label3);
            Controls.Add(comboBoxsehir);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "E-Sürücü";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private Label label4;
        private ErrorProvider errorProvider1;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
        private GroupBox groupBox2;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox9;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox3;
        private ListBox listBox1;
        private Button button2;
        private Label label2;
        private ComboBox comboBoxilce;
        private Label label3;
        private ComboBox comboBoxsehir;
        private Button button3;
        private Label label10;
    }
}
namespace WinFormsApp1
{
    partial class Form7
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
            button1 = new Button();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(260, 224);
            button1.Name = "button1";
            button1.Size = new Size(143, 67);
            button1.TabIndex = 17;
            button1.Text = "MEB SAYFASINA GERİ DÖN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "GEÇTİ", "KALDI", "-" });
            comboBox4.Location = new Point(260, 178);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 16;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "GİRDİ", "GİRMEDİ", "-" });
            comboBox3.Location = new Point(260, 137);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "GEÇTİ", "KALDI" });
            comboBox2.Location = new Point(260, 94);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "GİRDİ", "GİRMEDİ" });
            comboBox1.Location = new Point(260, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 181);
            label4.Name = "label4";
            label4.Size = new Size(176, 20);
            label4.TabIndex = 12;
            label4.Text = "Direksiyon Sınavı Sonucu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 140);
            label3.Name = "label3";
            label3.Size = new Size(201, 20);
            label3.TabIndex = 11;
            label3.Text = "Direksiyon Sınavına Girdi Mi?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 97);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 10;
            label2.Text = "Teorik Sınav Sonucu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 54);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 9;
            label1.Text = "Teorik Sınava Girdi Mi?";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 359);
            Controls.Add(button1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Button button1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
namespace WinFormsApp1
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            listBox1 = new ListBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(24, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(780, 44);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(24, 62);
            button1.Name = "button1";
            button1.Size = new Size(244, 210);
            button1.TabIndex = 1;
            button1.Text = "ONAY";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(24, 291);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(464, 92);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "ÜSTTE T.C. KİMLİK NUMARASI YAZILI ŞAHIS SÜRÜCÜ BELGESİNİ ALMAYA HAK KAZANMIŞTIR.\nİKÂMET ETTİĞİNİZ İLÇENİN NÜFUS MÜDÜRLÜĞÜNDEN SÜRÜCÜ BELGENİZİ ALABİLİRSİNİZ.";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(852, 383);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            ForeColor = SystemColors.ControlText;
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ResumeLayout(false);
        }
        #endregion
        private ListBox listBox1;
        private Button button1;
        private RichTextBox richTextBox1;
    }
}
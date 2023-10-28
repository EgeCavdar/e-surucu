using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
        }
        private void Form2_Shown(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = true;
            radioButton3.Checked = true;
            radioButton4.Checked = true;
            radioButton5.Checked = true;
            radioButton6.Checked = true;
            radioButton7.Checked = true;
            radioButton8.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxONAY.Checked == false)
            {
                MessageBox.Show("Lütfen onay kutusunu işaretleyiniz.");
            }
            if (radioButton1.Checked == true && checkBoxONAY.Checked == true)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            if (radioButton2.Checked == true && checkBoxONAY.Checked == true)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            if (radioButton3.Checked == true && checkBoxONAY.Checked == true)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            if (radioButton4.Checked == true && checkBoxONAY.Checked == true)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            if (radioButton5.Checked == true && checkBoxONAY.Checked == true)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            if (radioButton6.Checked == true && checkBoxONAY.Checked == true)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            if (radioButton7.Checked == true && checkBoxONAY.Checked == true)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            if (radioButton8.Checked == true && checkBoxONAY.Checked == true)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonhesapla_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label2.Text = "12000 TL";
            }
            else if (radioButton2.Checked == true)
            {
                label2.Text = "9000 TL";
            }
            else if (radioButton3.Checked == true)
            {
                label2.Text = "11000 TL";
            }
            else if (radioButton4.Checked == true)
            {
                label2.Text = "10000 TL";
            }
            else if (radioButton5.Checked == true)
            {
                label2.Text = "10500 TL";
            }
            else if (radioButton6.Checked == true)
            {
                label2.Text = "9500 TL";
            }
            else if (radioButton7.Checked == true)
            {
                label2.Text = "12500 TL";
            }
            else if (radioButton8.Checked == true)
            {
                label2.Text = "8000 TL";
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void buttonhesapla_MouseHover(object sender, EventArgs e)
        {
            buttonhesapla.Cursor = Cursors.Hand;
        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form0 form0 = new Form0();
            form0.Show();
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Sinav : Form
    {
        public static int puan;

        public Sinav()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            if (radioButton1.Checked)
            {
                puan += 20;
            }
            else if (radioButton2.Checked)
            {
                puan += 0;
            }
            if (radioButton3.Checked)
            {
                puan += 20;
            }
            else if (radioButton4.Checked)
            {
                puan += 0;
            }
            if (radioButton5.Checked)
            {
                puan += 20;
            }
            else if (radioButton6.Checked)
            {
                puan += 0;
            }
            if (radioButton7.Checked)
            {
                puan += 20;
            }
            else if (radioButton8.Checked)
            {
                puan += 0;
            }
           if (radioButton9.Checked)
            {
             puan += 20;
            }
            else if (radioButton10.Checked)
            {
             puan += 0;
            }
      
            this.Hide();

        }

        private void Sinav_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(" TCKN : " + Form1.TextBox1Bilgisi);
            listBox1.Items.Add(" DOĞUM TARİHİ : " + Form1.ComboBox2Bilgisi + " " + Form1.ComboBox1Bilgisi + " " + Form1.NumericUpDownBilgisi);
            listBox1.Items.Add(" EHLİYET TİPİ : " + Form1.radioButtonBilgisi);
            listBox1.Items.Add(" İKAMETGÂH : " + Form1.ComboBox4Bilgisi + " / " + Form1.ComboBox3Bilgisi);
            listBox1.Items.Add("------------------------------------------------------------------------- ");
        }
    }
}

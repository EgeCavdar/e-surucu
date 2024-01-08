using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static WinFormsApp1.Form1;
namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public static string textToDisplay;
        public Form5()
        {
            InitializeComponent();
            {
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
        }
        public void AddItem(string item)
        {
            listBox1.Items.Add(item);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Form5_Load_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(" TCKN : " + Form1.TextBox1Bilgisi);
            listBox1.Items.Add(" DOĞUM TARİHİ : " + Form1.ComboBox2Bilgisi + " " + Form1.ComboBox1Bilgisi + " " + Form1.NumericUpDownBilgisi);
            listBox1.Items.Add(" EHLİYET TİPİ : " + Form1.radioButtonBilgisi);
            listBox1.Items.Add(" İKAMETGÂH : " + Form1.ComboBox4Bilgisi + " / " + Form1.ComboBox3Bilgisi);
            listBox1.Items.Add("------------------------------------------------------------------------- ");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                textToDisplay = richTextBox1.Text;

                this.Hide();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textToDisplay = richTextBox2.Text;

            this.Hide();
        }
    }
}
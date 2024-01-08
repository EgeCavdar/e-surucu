using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace WinFormsApp1
{

    public partial class Form6 : Form
    {
        public static string textToDisplayx;
        public static string TextBox1Bilgisix;
        public static int puan;
        public Form6()
        {
            InitializeComponent();


        }



        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(" TCKN : " + Form1.TextBox1Bilgisi);
            listBox1.Items.Add(" DOĞUM TARİHİ : " + Form1.ComboBox2Bilgisi + " " + Form1.ComboBox1Bilgisi + " " + Form1.NumericUpDownBilgisi);
            listBox1.Items.Add(" EHLİYET TİPİ : " + Form1.radioButtonBilgisi);
            listBox1.Items.Add(" İKAMETGÂH : " + Form1.ComboBox4Bilgisi + " / " + Form1.ComboBox3Bilgisi);
            listBox1.Items.Add(" SINAV PUANI: " + Sinav.puan);
            listBox1.Items.Add("------------------------------------------------------------------------- ");
            listBox2.Items.Add(" TEORİK SINAV SONUCU : " + Form7.Girdi1Bilgisi + " " + Form7.Sonuc1Bilgisi);
            listBox2.Items.Add(" DİREKSİYON SINAVI SONUCU : : " + Form7.Girdi2Bilgisi + " " + Form7.Sonuc2Bilgisi);

            listBox2.Items.Add("------------------------------------------------------------------------- ");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TextBox1Bilgisix = richTextBox1.Text;
            Form7 form7 = new Form7();
            form7.Show();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            textToDisplayx = richTextBox1.Text;
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textToDisplayx = richTextBox2.Text;

            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}

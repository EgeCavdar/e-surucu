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
    public partial class Form7 : Form
    {
        public static string Girdi1Bilgisi;
        public static string Sonuc1Bilgisi;
        public static string Girdi2Bilgisi;
        public static string Sonuc2Bilgisi;
        private Random random = new Random();
        public Form7()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Girdi1Bilgisi = comboBox1.SelectedItem.ToString();
            Sonuc1Bilgisi = comboBox2.SelectedItem.ToString();
            Girdi2Bilgisi = comboBox3.SelectedItem.ToString();
            Sonuc2Bilgisi = comboBox4.SelectedItem.ToString();
            
            
            this.Hide();
        }
    }
}

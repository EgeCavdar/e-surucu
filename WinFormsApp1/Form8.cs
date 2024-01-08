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
    public partial class Form8 : Form
    {
        public static string textToDisplayz;
        public static string TextBox1Bilgisiz;
        public Form8()
        {
            InitializeComponent();
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            {
                listBox1.Items.Add("MEB'den onay isteniyor, TCKN:" + Form1.TextBox1Bilgisi + " olan şahıs Sürücü Belgesi almaya hak kazanmıştır");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textToDisplayz = richTextBox1.Text;
            this.Hide();
        }
    }
}

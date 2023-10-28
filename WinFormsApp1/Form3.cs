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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // Başlangıçta ilk butonu devre dışı bırak
            button2.Enabled = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBoxsehir.Items.Add("Adana");
            comboBoxsehir.Items.Add("Adıyaman");
            comboBoxsehir.Items.Add("Afyonkarahisar");
            comboBoxsehir.Items.Add("Ağrı");
            comboBoxsehir.Items.Add("Artvin");
            comboBoxsehir.Items.Add("Ankara");
            comboBoxsehir.Items.Add("Antalya");
            comboBoxsehir.Items.Add("Muğla");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxilce.SelectedIndex = -1;
            if (comboBoxsehir.Text == "Adana")
            {
                comboBoxilce.Items.Clear();
                comboBoxilce.Items.Add("Aladağ");
                comboBoxilce.Items.Add("Ceyhan");
                comboBoxilce.Items.Add("Çukurova");
                comboBoxilce.Items.Add("Feke");
                comboBoxilce.Items.Add("İmamoğlu");
                comboBoxilce.Items.Add("Karaisalı");
                comboBoxilce.Items.Add("Karataş");
                comboBoxilce.Items.Add("Kozan");
                comboBoxilce.Items.Add("Pozantı");
                comboBoxilce.Items.Add("Saimbeyli");
                comboBoxilce.Items.Add("Sarıçam");
                comboBoxilce.Items.Add("Seyhan");
                comboBoxilce.Items.Add("Tufanbeyli");
                comboBoxilce.Items.Add("Yumurtalık");
            }
            else if (comboBoxsehir.Text == "Muğla")
            {
                comboBoxilce.Items.Clear();
                comboBoxilce.Items.Add("Bodrum");
                comboBoxilce.Items.Add("Dalaman");
                comboBoxilce.Items.Add("Datça");
                comboBoxilce.Items.Add("Fethiye");
                comboBoxilce.Items.Add("Kavaklıdere");
                comboBoxilce.Items.Add("Köyceğiz");
                comboBoxilce.Items.Add("Marmaris");
                comboBoxilce.Items.Add("Menteşe");
                comboBoxilce.Items.Add("Milas");
                comboBoxilce.Items.Add("Ortaca");
                comboBoxilce.Items.Add("Seydikemer");
                comboBoxilce.Items.Add("Ula");
                comboBoxilce.Items.Add("Yatağan");

            }
            else if (comboBoxsehir.Text == "Adıyaman")
            {
                comboBoxilce.Items.Clear();
                comboBoxilce.Items.Add("Adıyaman (İl merkezi)");
                comboBoxilce.Items.Add("Besni");
                comboBoxilce.Items.Add("Çelikhan");
                comboBoxilce.Items.Add("Gerger");
                comboBoxilce.Items.Add("Gölbaşı");
                comboBoxilce.Items.Add("Kâhta");
                comboBoxilce.Items.Add("Samsat");
                comboBoxilce.Items.Add("Sincik");
                comboBoxilce.Items.Add("Tut");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("İL :" + comboBoxsehir.Text + " | İLÇE :" + comboBoxilce.Text);
        }

        private void comboBoxilce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            // İkinci butona tıklandığında, ilk butonu etkinleştir
            button1.Enabled = true;
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                MessageBox.Show("Kayıt Alınmıştır. Sürücü Kursu Tarafından Onay Bekleyiniz.");
                Form0 form0 = new Form0();
                form0.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Lütfen Teorik Ders Seçimini Tamamlayınız.");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form0 form0 = new Form0();
            form0.Show();
            this.Hide();
        }
    }
}

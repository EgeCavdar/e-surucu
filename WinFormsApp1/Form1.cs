using System;
using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
                if (textBox3.Text == label8.Text)
                    if (textBox1.Text.Length == 11)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                    else if (textBox1.Text.Length != 11)
                    {
                        MessageBox.Show("Yanlýþ TCKN giriþi yapýldý!");
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
            if (textBox3.Text != label8.Text)
            {
                MessageBox.Show("Hatalý Giriþ Yapýldý! Tekrar Deneyiniz.");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            GenerateRandomNumber();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateRandomNumber();
        }
        private void GenerateRandomNumber()
        {
            string randomNumber = "";
            for (int i = 0; i < 4; i++)
                randomNumber += random.Next(0, 10).ToString();

            label8.Text = randomNumber;
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Yalnýzca 11 haneli, rakam giriþi yapýnýz.", textBox1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                e.Cancel = true;
                comboBox2.Focus();
                errorProvider1.SetError(comboBox2, "Lütfen doðum gününüzü giriniz.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox2, null);

            }
        }

        private void comboBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                e.Cancel = true;
                comboBox1.Focus();
                errorProvider1.SetError(comboBox1, "Lütfen doðum ayýnýzý giriniz.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox1, null);

            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form0 form0 = new Form0();
            form0.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
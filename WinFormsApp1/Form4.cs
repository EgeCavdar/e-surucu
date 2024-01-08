using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
namespace WinFormsApp1
{
   
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
            if (button2.Enabled)
            {
                button5.Enabled = false;
            }
            if (button1.Enabled)
            {
                button2.Enabled = false;
            }
            if (button3.Enabled = false)
            {
                button4.Enabled = false;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Form0_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
        }

        Queue<string> notifications = new Queue<string>();

        void AddNotification(string notification)
        {
            // Yeni bir bildirim ekleyin
            notifications.Enqueue(notification);
        }

        void button1_Click(object sender, EventArgs e)
        {
            // Kuyruktan bir bildirim alın ve görüntüleyin
            if (notifications.Count > 0)
            {
                string notificationToShow = notifications.Dequeue();
                MessageBox.Show(notificationToShow, "Bildirim");
            }

            {
                Form1 form1 = new Form1();
                form1.Show();
            }

            if (button1.Enabled == true)
            {
                button2.Enabled = true;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Red;
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Default;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
        private void buttonkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Enabled = true)
            {
                button5.Enabled = true;
            }
            Form5 form5 = new Form5();
            form5.Show();

        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Enabled = true)
            {
                button4.Enabled = true;
            }
            Form6 form6 = new Form6();
            form6.Show();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Enabled = true)
            {
                button3.Enabled = true;
            }
            Sinav Sinav = new Sinav();
            Sinav.Show();
        }
    }
}

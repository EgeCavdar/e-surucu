using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static WinFormsApp1.Form6;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static string TextBox1Bilgisi;
        public static string ComboBox1Bilgisi;
        public static string ComboBox2Bilgisi;
        public static string ComboBox3Bilgisi;
        public static string ComboBox4Bilgisi;
        public static string NumericUpDownBilgisi;
        public static string radioButtonBilgisi;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TextBox1Bilgisi = textBox1.Text;
            if (ValidateChildren(ValidationConstraints.Enabled))
                if (textBox3.Text == label8.Text)
                    if (textBox1.Text.Length == 11)
                    {
                        MessageBox.Show("Kay�t ba�vurunuz al�nm��t�r. Ana sayfaya y�nlendiriliyorsunuz.");

                        this.Hide();

                        TextBox1Bilgisi = textBox1.Text;
                        ComboBox1Bilgisi = comboBox1.SelectedItem.ToString();
                        ComboBox2Bilgisi = comboBox2.SelectedItem.ToString();
                        ComboBox3Bilgisi = comboBoxsehir.SelectedItem.ToString();
                        ComboBox4Bilgisi = comboBoxilce.SelectedItem.ToString();
                        NumericUpDownBilgisi = numericUpDown1.Value.ToString();
                        if (radioButton1.Checked)
                        {
                            radioButtonBilgisi = radioButton1.Text;
                        }
                        else if (radioButton2.Checked)
                        {
                            radioButtonBilgisi = radioButton2.Text;
                        }
                        else if (radioButton3.Checked)
                        {
                            radioButtonBilgisi = radioButton3.Text;
                        }
                        else if (radioButton4.Checked)
                        {
                            radioButtonBilgisi = radioButton4.Text;
                        }
                        else if (radioButton5.Checked)
                        {
                            radioButtonBilgisi = radioButton5.Text;
                        }
                        else if (radioButton6.Checked)
                        {
                            radioButtonBilgisi = radioButton6.Text;
                        }
                        else if (radioButton7.Checked)
                        {
                            radioButtonBilgisi = radioButton7.Text;
                        }
                        else if (radioButton8.Checked)
                        {
                            radioButtonBilgisi = radioButton8.Text;
                        }
                    }
            if (textBox1.Text.Length != 11)
            {
                MessageBox.Show("Yanl�� TCKN giri�i yap�ld�!");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            if (textBox3.Text != label8.Text)
            {
                MessageBox.Show("Hatal� Giri� Yap�ld�! Tekrar Deneyiniz.");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sehirler = { "ADANA", "ADIYAMAN", "AFYONKARAH�SAR", "A�RI", "AMASYA", "ANKARA", "ANTALYA", "ARTV�N", "AYDIN", "BALIKES�R", "B�LEC�K", "B�NG�L", "B�TL�S", "BOLU", "BURDUR", "BURSA", "�ANAKKALE", "�ANKIRI", "�ORUM", "DEN�ZL�", "D�YARBAKIR", "ED�RNE", "ELAZI�", "ERZ�NCAN", "ERZURUM", "ESK��EH�R", "GAZ�ANTEP", "G�RESUN", "G�M��HANE", "HAKKAR�", "HATAY", "ISPARTA", "MERS�N", "�STANBUL", "�ZM�R", "KARS", "KASTAMONU", "KAYSER�", "KIRKLAREL�", "KIR�EH�R", "KOCAEL�", "KONYA", "K�TAHYA", "MALATYA", "MAN�SA", "KAHRAMANMARA�", "MARD�N", "MU�LA", "MU�", "NEV�EH�R", "N��DE", "ORDU", "R�ZE", "SAKARYA", "SAMSUN", "S��RT", "S�NOP", "S�VAS", "TEK�RDA�", "TOKAT", "TRABZON", "TUNCEL�", "�ANLIURFA", "U�AK", "VAN", "YOZGAT", "ZONGULDAK", "AKSARAY", "BAYBURT", "KARAMAN", "KIRIKKALE", "BATMAN", "�IRNAK", "BARTIN", "ARDAHAN", "I�DIR", "YALOVA", "KARAB�K", "K�L�S", "OSMAN�YE", "D�ZCE" };
            foreach (string sehir in sehirler)
            {
                comboBoxsehir.Items.Add(sehir);
            }
        
            if (!string.IsNullOrEmpty(Form5.textToDisplay))
            {
                DialogResult result = MessageBox.Show(Form5.textToDisplay, Form1.TextBox1Bilgisi, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            if (!string.IsNullOrEmpty(Form6.textToDisplayx))
            {
                var result = MessageBox.Show(Form6.textToDisplayx, Form1.TextBox1Bilgisi, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            if (!string.IsNullOrEmpty(Form8.textToDisplayz))
            {
                var result = MessageBox.Show(Form8.textToDisplayz, Form1.TextBox1Bilgisi, MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
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
            toolTip1.Show("Yaln�zca 11 haneli, rakam giri�i yap�n�z.", textBox1);
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
                errorProvider1.SetError(comboBox2, "L�tfen do�um g�n�n�z� giriniz.");
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
                errorProvider1.SetError(comboBox1, "L�tfen do�um ay�n�z� giriniz.");
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBoxsehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxilce.SelectedIndex = -1;
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(" TCKN : " + textBox1.Text);
            listBox1.Items.Add(" D. TAR�H� : " + comboBox2.Text + " " + comboBox1.Text + " " + numericUpDown1.Value);
            listBox1.Items.Add(" �L : " + comboBoxsehir.Text);
            listBox1.Items.Add(" �L�E : " + comboBoxilce.Text);
            if (radioButton1.Checked)
            {
                listBox1.Items.Add(" EHL�YET T�P� : " + radioButton1.Text);
            }
            if (radioButton2.Checked)
            {
                listBox1.Items.Add(" EHL�YET T�P� : " + radioButton2.Text);
            }
            if (radioButton3.Checked)
            {
                listBox1.Items.Add(" EHL�YET T�P� : " + radioButton3.Text);
            }
            if (radioButton4.Checked)
            {
                listBox1.Items.Add(" EHL�YET T�P� : " + radioButton4.Text);
            }
            if (radioButton5.Checked)
            {
                listBox1.Items.Add(" EHL�YET T�P� : " + radioButton5.Text);
            }
            if (radioButton6.Checked)
            {
                listBox1.Items.Add(" EHL�YET T�P� : " + radioButton6.Text);
            }
            if (radioButton7.Checked)
            {
                listBox1.Items.Add(" EHL�YET T�P� : " + radioButton7.Text);
            }
            if (radioButton8.Checked)
            {
                listBox1.Items.Add(" EHL�YET T�P� : " + radioButton8.Text);
            }
            if (radioButton1.Checked == true)
            {
                label10.Text = "22000 TL";
            }
            else if (radioButton2.Checked == true)
            {
                label10.Text = "19000 TL";
            }
            else if (radioButton3.Checked == true)
            {
                label10.Text = "21000 TL";
            }
            else if (radioButton4.Checked == true)
            {
                label10.Text = "20000 TL";
            }
            else if (radioButton5.Checked == true)
            {
                label10.Text = "20500 TL";
            }
            else if (radioButton6.Checked == true)
            {
                label10.Text = "16500 TL";
            }
            else if (radioButton7.Checked == true)
            {
                label10.Text = "22500 TL";
            }
            else if (radioButton8.Checked == true)
            {
                label10.Text = "15000 TL";
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton1 = sender as RadioButton;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton3 = sender as RadioButton;
        }
        private void comboBoxsehir_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBoxilce.Items.Clear();
            switch (comboBoxsehir.Text)
            {
                case "ADANA":
                    comboBoxilce.Items.AddRange(new string[] { "ALADA�", "CEYHAN", "�UKUROVA", "FEKE", "�MAMO�LU", "KARA�SALI", "KARATA�", "KOZAN", "POZANTI", "SA�MBEYL�", "SARI�AM", "SEYHAN", "TUFANBEYL�", "YUMURTALIK", "Y�RE��R" });
                    break;
                case "ADIYAMAN":
                    comboBoxilce.Items.AddRange(new string[] { "BESN�", "�EL�KHAN", "GERGER", "G�LBA�I", "KAHTA", "SAMSAT", "S�NC�K", "TUT" });
                    break;
                case "AFYONKARAH�SAR":
                    comboBoxilce.Items.AddRange(new string[] { "BA�MAK�I", "BAYAT", "BOLVAD�N", "�AY", "�OBANLAR", "D�NAR", "EM�RDA�", "EVC�LER", "HOCALAR", "�HSAN�YE", "�SCEH�SAR", "KIZIL�REN", "SANDIKLI", "S�NANPA�A", "SULTANDA�I", "�UHUT" });
                    break;
                case "A�RI":
                    comboBoxilce.Items.AddRange(new string[] { "D�YAD�N", "DO�UBEYAZIT", "ELE�K�RT", "HAMUR", "PATNOS", "TA�LI�AY", "TUTAK" });
                    break;
                case "AMASYA":
                    comboBoxilce.Items.AddRange(new string[] { "G�YN�CEK", "G�M��HACIK�Y", "HAMAM�Z�", "MERZ�FON", "SULUOVA", "TA�OVA" });
                    break;
                case "ANKARA":
                    comboBoxilce.Items.AddRange(new string[] { "AKYURT", "ALTINDA�", "AYA�", "BALA", "BEYPAZARI", "�AMLIDERE", "�ANKAYA", "�UBUK", "ELMADA�", "ET�MESGUT", "EVREN", "G�LBA�I", "G�D�L", "HAYMANA", "KAHRAMANKAZAN", "KALEC�K", "KE���REN", "KIZILCAHAMAM", "MAMAK", "NALLIHAN", "POLATLI", "PURSAKLAR", "S�NCAN", "�EREFL�KO�H�SAR", "YEN�MAHALLE" });
                    break;
                case "ANTALYA":
                    comboBoxilce.Items.AddRange(new string[] { "AKSEK�", "AKSU", "ALANYA", "DEMRE", "D��EMEALTI", "ELMALI", "F�N�KE", "GAZ�PA�A", "G�NDO�MU�", "�BRADI", "KALE", "KA�", "KEMER", "KEPEZ", "KONYAALTI", "KORKUTEL�", "KUMLUCA", "MANAVGAT", "MURATPA�A", "SER�K" });
                    break;
                case "ARTV�N":
                    comboBoxilce.Items.AddRange(new string[] { "ARHAV�", "BOR�KA", "HOPA", "MURGUL", "�AV�AT", "YUSUFEL�" });
                    break;
                case "AYDIN":
                    comboBoxilce.Items.AddRange(new string[] { "BOZDO�AN", "BUHARKENT", "��NE", "D�D�M", "EFELER", "GERMENC�K", "�NC�RL�OVA", "KARACASU", "KO�ARLI", "K��K", "KU�ADASI", "KUYUCAK", "NAZ�LL�", "S�KE", "SULTANH�SAR", "YEN�PAZAR" });
                    break;
                case "BALIKES�R":
                    comboBoxilce.Items.AddRange(new string[] { "ALTIEYL�L", "AYVALIK", "BANDIRMA", "B�GAD��", "BURHAN�YE", "DURSUNBEY", "EDREM�T", "ERDEK", "G�ME�", "HAVRAN", "�VR�ND�", "KARES�", "KEPSUT", "MANYAS", "MARMARA", "SAVA�TEPE", "SINDIRGI", "SUSURLUK" });
                    break;
                case "B�LEC�K":
                    comboBoxilce.Items.AddRange(new string[] { "BOZ�Y�K", "G�LPAZARI", "�NH�SAR", "OSMANEL�", "PAZARYER�", "S���T", "YEN�PAZAR" });
                    break;
                case "B�NG�L":
                    comboBoxilce.Items.AddRange(new string[] { "ADAKLI", "GEN�", "KARLIOVA", "K��I", "SOLHAN", "YAYLADERE", "YED�SU" });
                    break;
                case "B�TL�S":
                    comboBoxilce.Items.AddRange(new string[] { "AD�LCEVAZ", "AHLAT", "G�ROYMAK", "H�ZAN", "MUTK�", "TATVAN" });
                    break;
                case "BOLU":
                    comboBoxilce.Items.AddRange(new string[] { "D�RTD�VAN", "GEREDE", "G�YN�K", "KIBRISCIK", "MENGEN", "MUDURNU", "SEBEN", "YEN��A�A" });
                    break;
                case "BURDUR":
                    comboBoxilce.Items.AddRange(new string[] { "A�LASUN", "ALTINYAYLA", "BUCAK", "�AVDIR", "�ELT�K��", "G�LH�SAR", "KARAMANLI", "KEMER", "TEFENN�", "YE��LOVA" });
                    break;
                case "BURSA":
                    comboBoxilce.Items.AddRange(new string[] { "B�Y�KORHAN", "GEML�K", "G�RSU", "HARMANCIK", "�NEG�L", "�ZN�K", "KARACABEY", "KELES", "KESTEL", "MUDANYA", "MUSTAFAKEMALPA�A", "N�L�FER", "ORHANEL�", "ORHANGAZ�", "OSMANGAZ�", "YILDIRIM" });
                    break;
                case "�ANAKKALE":
                    comboBoxilce.Items.AddRange(new string[] { "AYVACIK", "BAYRAM��", "B�GA", "BOZCAADA", "�AN", "ECEABAT", "EZ�NE", "GEL�BOLU", "G�K�EADA", "LAPSEK�", "YEN�CE" });
                    break;
                case "�ANKIRI":
                    comboBoxilce.Items.AddRange(new string[] { "ATKARACALAR", "BAYRAM�REN", "�ERKE�", "ELD�VAN", "ILGAZ", "KIZILIRMAK", "KORGUN", "KUR�UNLU", "ORTA", "�ABAN�Z�", "YAPRAKLI" });
                    break;
                case "�ORUM":
                    comboBoxilce.Items.AddRange(new string[] { "ALACA", "BAYAT", "BO�AZKALE", "DODURGA", "�SK�L�P", "KARGI", "LA��N", "MEC�T�Z�", "O�UZLAR", "ORTAK�Y", "OSMANCIK", "SUNGURLU", "U�URLUDA�" });
                    break;
                case "DEN�ZL�":
                    comboBoxilce.Items.AddRange(new string[] { "ACIPAYAM", "BABADA�", "BAKLAN", "BEK�LL�", "BEYA�A�", "BOZKURT", "BULDAN", "�AL", "�AMEL�", "�ARDAK", "��VR�L", "G�NEY", "HONAZ", "KALE", "MERKEZEFEND�", "PAMUKKALE", "SARAYK�Y", "SER�NH�SAR", "TAVAS" });
                    break;
                case "D�YARBAKIR":
                    comboBoxilce.Items.AddRange(new string[] { "BA�LAR", "B�SM�L", "�ERM�K", "�INAR", "��NG��", "D�CLE", "E��L", "ERGAN�", "HAN�", "HAZRO", "KAYAPINAR", "KOCAK�Y", "KULP", "L�CE", "S�LVAN", "SUR", "YEN��EH�R" });
                    break;
                case "ED�RNE":
                    comboBoxilce.Items.AddRange(new string[] { "ENEZ", "HAVSA", "�PSALA", "KE�AN", "LALAPA�A", "MER��", "S�LO�LU", "UZUNK�PR�" });
                    break;
                case "ELAZI�":
                    comboBoxilce.Items.AddRange(new string[] { "A�IN", "ALACAKAYA", "ARICAK", "BASK�L", "KARAKO�AN", "KEBAN", "KOVANCILAR", "MADEN", "PALU", "S�VR�CE" });
                    break;
                case "ERZ�NCAN":
                    comboBoxilce.Items.AddRange(new string[] { "�AYIRLI", "�L��", "KEMAH", "KEMAL�YE", "OTLUKBEL�", "REFAH�YE", "TERCAN", "�Z�ML�" });
                    break;
                case "ERZURUM":
                    comboBoxilce.Items.AddRange(new string[] { "A�KALE", "AZ�Z�YE", "�AT", "HINIS", "HORASAN", "�SP�R", "KARA�OBAN", "KARAYAZI", "K�PR�K�Y", "NARMAN", "OLTU", "OLUR", "PALAND�KEN", "PAS�NLER", "PAZARYOLU", "�ENKAYA", "TEKMAN", "TORTUM", "YAKUT�YE" });
                    break;
                case "ESK��EH�R":
                    comboBoxilce.Items.AddRange(new string[] { "ALPU", "BEYL�KOVA", "��FTELER", "G�NY�Z�", "HAN", "�N�N�", "MAHMUD�YE", "M�HALGAZ�", "M�HALI��IK", "ODUNPAZARI", "SARICAKAYA", "SEY�TGAZ�", "S�VR�H�SAR", "TEPEBA�I" });
                    break;
                case "GAZ�ANTEP":
                    comboBoxilce.Items.AddRange(new string[] { "ARABAN", "KARKAMI�", "N�Z�P", "OGUZEL�", "�AH�NBEY", "�EH�TKAM�L", "YAVUZEL�" });
                    break;
                case "G�RESUN":
                    comboBoxilce.Items.AddRange(new string[] { "ALUCRA", "BULANCAK", "�AMOLUK", "�ANAK�I", "DEREL�", "DO�ANKENT", "ESP�YE", "EYNES�L", "G�RELE", "G�CE", "KE�AP", "P�RAZ�Z", "�EB�NKARAH�SAR", "T�REBOLU", "YA�LIDERE" });
                    break;
                case "G�M��HANE":
                    comboBoxilce.Items.AddRange(new string[] { "KELK�T", "K�SE", "K�RT�N", "��RAN", "TORUL" });
                    break;
                case "HAKKAR�":
                    comboBoxilce.Items.AddRange(new string[] { "�UKURCA", "�EMD�NL�", "Y�KSEKOVA" });
                    break;
                case "HATAY":
                    comboBoxilce.Items.AddRange(new string[] { "ALTIN�Z�", "ANTAKYA", "ARSUZ", "BELEN", "DEFNE", "D�RTYOL", "ERZ�N", "HASSA", "�SKENDERUN", "KIRIKHAN", "KUMLU", "PAYAS", "REYHANLI", "SAMANDA�", "YAYLADA�I" });
                    break;
                case "ISPARTA":
                    comboBoxilce.Items.AddRange(new string[] { "AKSU", "ATABEY", "E��RD�R", "GELENDOST", "G�NEN", "KE��BORLU", "SEN�RKENT", "S�T��LER", "�ARK�KARAA�A�", "ULUBORLU", "YALVA�", "YEN��ARBADEML�" });
                    break;
                case "MERS�N":
                    comboBoxilce.Items.AddRange(new string[] { "AKDEN�Z", "ANAMUR", "AYDINCIK", "BOZYAZI", "�AMLIYAYLA", "ERDEML�", "G�LNAR", "MEZ�TL�", "MUT", "S�L�FKE", "TARSUS", "TOROSLAR", "YEN��EH�R" });
                    break;
                case "�STANBUL":
                    comboBoxilce.Items.AddRange(new string[] { "ADALAR", "ARNAVUTK�Y", "ATA�EH�R", "AVCILAR", "BA�CILAR", "BAH�EL�EVLER", "BAKIRK�Y", "BA�AK�EH�R", "BAYRAMPA�A", "BE��KTA�", "BEYKOZ", "BEYL�KD�Z�", "BEYO�LU", "B�Y�K�EKMECE", "�ATALCA", "�EKMEK�Y", "ESENLER", "ESENYURT", "EY�PSULTAN", "FAT�H", "GAZ�OSMANPA�A", "G�NG�REN", "KADIK�Y", "KA�ITHANE", "KARTAL", "K���K�EKMECE", "MALTEPE", "PEND�K", "SANCAKTEPE", "SARIYER", "��LE", "���L�", "SULTANBEYL�", "SULTANGAZ�", "TUZLA", "�MRAN�YE", "�SK�DAR", "ZEYT�NBURNU" });
                    break;
                case "�ZM�R":
                    comboBoxilce.Items.AddRange(new string[] { "AL�A�A", "BAL�OVA", "BAYINDIR", "BAYRAKLI", "BERGAMA", "BEYDA�", "BORNOVA", "BUCA", "�E�ME", "���L�", "D�K�L�", "FO�A", "GAZ�EM�R", "G�ZELBAH�E", "KARABA�LAR", "KARABURUN", "KAR�IYAKA", "KEMALPA�A", "KINIK", "K�RAZ", "KONAK", "MENDERES", "MENEMEN", "NARLIDERE", "�DEM��", "SEFER�H�SAR", "SEL�UK", "T�RE", "TORBALI", "URLA" });
                    break;
                case "KARS":
                    comboBoxilce.Items.AddRange(new string[] { "AKYAKA", "ARPA�AY", "D�GOR", "KA�IZMAN", "SARIKAMI�", "SEL�M", "SUSUZ" });
                    break;
                case "KASTAMONU":
                    comboBoxilce.Items.AddRange(new string[] { "ABANA", "A�LI", "ARA�", "AZDAVAY", "BOZKURT", "C�DE", "�ATALZEYT�N", "DADAY", "DEVREKAN�", "DO�ANYURT", "HAN�N�", "�HSANGAZ�", "�NEBOLU", "K�RE", "MERKEZ", "PINARBA�I", "SEYD�LER", "�ENPAZAR", "TA�K�PR�", "TOSYA" });
                    break;
                case "KAYSER�":
                    comboBoxilce.Items.AddRange(new string[] { "AKKI�LA", "B�NYAN", "DEVEL�", "FELAH�YE", "HACILAR", "�NCESU", "KOCAS�NAN", "MEL�KGAZ�", "�ZVATAN", "PINARBA�I", "SARIO�LAN", "SARIZ", "TALAS", "TOMARZA", "YAHYALI", "YE��LH�SAR" });
                    break;
                case "KIRKLAREL�":
                    comboBoxilce.Items.AddRange(new string[] { "BABAESK�", "DEM�RK�Y", "KOF�AZ", "L�LEBURGAZ", "MERKEZ", "PEHL�VANK�Y", "PINARH�SAR", "V�ZE" });
                    break;
                case "KIR�EH�R":
                    comboBoxilce.Items.AddRange(new string[] { "AK�AKENT", "AKPINAR", "BOZTEPE", "���EKDA�I", "KAMAN", "MERKEZ", "MUCUR" });
                    break;
                case "KOCAEL�":
                    comboBoxilce.Items.AddRange(new string[] { "BA��SKELE", "�AYIROVA", "DARICA", "DER�NCE", "D�LOVASI", "GEBZE", "G�LC�K", "�ZM�T", "KANDIRA", "KARAM�RSEL", "KARTEPE", "K�RFEZ" });
                    break;
                case "KONYA":
                    comboBoxilce.Items.AddRange(new string[] { "AH�LER", "AK�REN", "AK�EH�R", "ALTINEK�N", "BEY�EH�R", "BOZKIR", "C�HANBEYL�", "�ELT�K", "�UMRA", "DERBENT", "DEREBUCAK", "DO�ANH�SAR", "EM�RGAZ�", "ERE�L�", "G�NEYSINIR", "HAD�M", "HALKAPINAR", "H�Y�K", "ILGIN", "KADINHANI", "KARAPINAR", "KARATAY", "KULU", "MERAM", "SARAY�N�", "SEL�UKLU", "SEYD��EH�R", "TA�KENT", "TUZLUK�U", "YALIH�Y�K", "YUNAK" });
                    break;
                case "K�TAHYA":
                    comboBoxilce.Items.AddRange(new string[] { "ALTINTA�", "ASLANAPA", "�AVDARH�SAR", "DOMAN��", "DUMLUPINAR", "EMET", "GED�Z", "H�SARCIK", "MERKEZ", "PAZARLAR", "S�MAV", "�APHANE", "TAV�ANLI" });
                    break;
                case "MALATYA":
                    comboBoxilce.Items.AddRange(new string[] { "AK�ADA�", "ARAPG�R", "ARGUVAN", "BATTALGAZ�", "DARENDE", "DO�AN�EH�R", "DO�ANYOL", "HEK�MHAN", "KALE", "KULUNCAK", "P�T�RGE", "YE��LYURT" });
                    break;
                case "MAN�SA":
                    comboBoxilce.Items.AddRange(new string[] { "AHMETL�", "AKH�SAR", "ALA�EH�R", "DEM�RC�", "G�LMARMARA", "G�RDES", "KIRKA�A�", "K�PR�BA�I", "KULA", "SAL�HL�", "SARIG�L", "SARUHANLI", "SELEND�", "SOMA", "�EHZADELER", "TURGUTLU", "YUNUSEMRE" });
                    break;
                case "MARD�N":
                    comboBoxilce.Items.AddRange(new string[] { "ARTUKLU", "DARGE��T", "DER�K", "KIZILTEPE", "MAZIDA�I", "M�DYAT", "NUSAYB�N", "�MERL�", "SAVUR", "YE��LL�" });
                    break;
                case "MU�LA":
                    comboBoxilce.Items.AddRange(new string[] { "BODRUM", "DALAMAN", "DAT�A", "FETH�YE", "KAVAKLIDERE", "K�YCE��Z", "MARMAR�S", "M�LAS", "MENTE�E" , "ORTACA", "ULA", "YATA�AN" });
                    break;
                case "MU�":
                    comboBoxilce.Items.AddRange(new string[] { "BULANIK", "HASK�Y", "KORKUT", "MALAZG�RT", "VARTO" });
                    break;
                case "NEV�EH�R":
                    comboBoxilce.Items.AddRange(new string[] { "ACIG�L", "AVANOS", "DER�NKUYU", "G�L�EH�R", "HACIBEKTA�", "KALESAK�Z�", "KOZAKLI", "NEV�EH�R", "�RG�P" });
                    break;
                case "N��DE":
                    comboBoxilce.Items.AddRange(new string[] { "ALTUNH�SAR", "BOR", "�AMARDI", "��FTL�K", "N��DE", "ULUKI�LA" });
                    break;
                case "ORDU":
                    comboBoxilce.Items.AddRange(new string[] { "AKKU�", "AYBASTI", "�AMA�", "�ATALPINAR", "�AYBA�I", "FATSA", "G�LK�Y", "G�LYALI", "G�RGENTEPE", "�K�ZCE", "KABAD�Z", "KABATA�", "KORGAN", "KUMRU", "MESUD�YE", "ORDU", "PER�EMBE", "ULUBEY", "�NYE" });
                    break;
                case "OSMAN�YE":
                    comboBoxilce.Items.AddRange(new string[] { "BAH�E", "D�Z���", "HASANBEYL�", "KAD�RL�", "OSMAN�YE", "SUMBAS", "TOPRAKKALE" });
                    break;
                case "R�ZE":
                    comboBoxilce.Items.AddRange(new string[] { "ARDE�EN", "�AMLIHEM��N", "�AYEL�", "DEREPAZARI", "FINDIKLI", "G�NEYSU", "HEM��N", "�K�ZDERE", "�Y�DERE", "KALKANDERE", "PAZAR", "R�ZE" });
                    break;
                case "SAKARYA":
                    comboBoxilce.Items.AddRange(new string[] { "ADAPAZARI", "AKYAZI", "AR�F�YE", "ERENLER", "FER�ZL�", "GEYVE", "HENDEK", "KARAP�R�EK", "KARASU", "KAYNARCA", "KOCAAL�", "PAMUKOVA", "SAPANCA", "SERD�VAN", "S���TL�", "TARAKLI" });
                    break;
                case "SAMSUN":
                    comboBoxilce.Items.AddRange(new string[] { "ALA�AM", "ASARCIK", "ATAKUM", "AYVACIK", "BAFRA", "CAN�K", "�AR�AMBA", "HAVZA", "�LKADIM", "KAVAK", "LAD�K", "OMYA", "SALIPAZARI", "TEKKEK�Y", "TERME", "VEZ�RK�PR�", "YAKAKENT" });
                    break;
                case "S��RT":
                    comboBoxilce.Items.AddRange(new string[] { "AYDINLAR", "BAYKAN", "ERUH", "KURTALAN", "PERVAR�", "��RVAN", "S��RT" });
                    break;
                case "S�NOP":
                    comboBoxilce.Items.AddRange(new string[] { "AYANCIK", "BOYABAT", "D�KMEN", "DURA�AN", "ERFELEK", "GERZE", "SARAYD�Z�", "S�NOP", "T�RKEL�" });
                    break;
                case "S�VAS":
                    comboBoxilce.Items.AddRange(new string[] { "AKINCILAR", "ALTINYAYLA", "D�VR���", "DO�AN�AR", "GEMEREK", "G�LOVA", "G�R�N", "HAF�K", "�MRANLI", "KANGAL", "KOYULH�SAR", "SU�EHR�", "�ARKI�LA", "ULA�", "YILDIZEL�", "ZARA" });
                    break;
                case "TEK�RDA�":
                    comboBoxilce.Items.AddRange(new string[] { "�ERKEZK�Y", "�ORLU", "ERGENE", "HAYRABOLU", "KAPAKLI", "MALKARA", "MARMARAERE�L�S�", "MURATLI", "SARAY", "S�LEYMANPA�A", "�ARK�Y" });
                    break;
                case "TOKAT":
                    comboBoxilce.Items.AddRange(new string[] { "ALMUS", "ARTOVA", "BA���FTL�K", "ERBAA", "N�KSAR", "PAZAR", "RE�AD�YE", "SULUSARAY", "TOKAT", "TURHAL", "YE��LYURT", "Z�LE" });
                    break;
                case "TRABZON":
                    comboBoxilce.Items.AddRange(new string[] { "AK�AABAT", "ARAKLI", "AR��N", "BE��KD�Z�", "�AR�IBA�I", "�AYKARA", "DERNEKPAZAR", "D�ZK�Y", "HAYRAT", "K�PR�BA�I", "MA�KA", "OF", "ORTAH�SAR", "S�RMENE", "�ALPAZARI", "TONYA", "VAKF�KEB�R", "YOMRA" });
                    break;
                case "TUNCEL�":
                    comboBoxilce.Items.AddRange(new string[] { "�EM��GEZEK", "HOZAT", "MAZG�RT", "NAZIM�YE", "OVACIK", "PERTER", "P�L�M�R", "TUNCEL�" });
                    break;
                case "�ANLIURFA":
                    comboBoxilce.Items.AddRange(new string[] { "AK�AKALE", "B�REC�K", "BOZOVA", "CEYLANPINAR", "EYY�B�YE", "HALFET�", "HAL�L�YE", "HARRAN", "H�LVAN", "KARAK�PR�", "S�VEREK", "SURU�", "V�RAN�EH�R" });
                    break;
                case "U�AK":
                    comboBoxilce.Items.AddRange(new string[] { "BANAZ", "E�ME", "KARAHALLI", "S�VASLI", "ULUBEY", "U�AK" });
                    break;
                case "VAN":
                    comboBoxilce.Items.AddRange(new string[] { "BAH�ESARAY", "BA�KALE", "�ALDIRAN", "�ATAK", "EDREM�T", "ERC��", "GEVA�", "G�RPINAR", "�PEKYOLU", "MURAD�YE", "�ZALP", "SARAY", "TU�BA" });
                    break;
                case "YALOVA":
                    comboBoxilce.Items.AddRange(new string[] { "ALTINOVA", "ARMUTLU", "�INARCIK", "��FTL�KK�Y", "TERMAL", "YALOVA" });
                    break;
                case "YOZGAT":
                    comboBoxilce.Items.AddRange(new string[] { "AKDA�MADEN�", "AYDINCIK", "BO�AZLIYAN", "�ANDIR", "�AYIRALAN", "�EKEREK", "KADI�EHR�", "SARIKAYA", "SORGUN", "�EFAATL�", "YEN�FAKILI", "YOZGAT", "YERK�Y" });
                    break;
                case "ZONGULDAK":
                    comboBoxilce.Items.AddRange(new string[] { "ALAPLI", "�AYCUMA", "DEVREK", "ERE�L�", "G�K�EBEY", "K�L�ML�", "KOZLU", "ZONGULDAK" });
                    break;
                case "AKSARAY":
                    comboBoxilce.Items.AddRange(new string[] { "A�A��REN", "AKSARAY", "ESK�L", "G�LA�A�", "G�ZELYURT", "ORTAK�Y", "SARIYAH��" });
                    break;
                case "BAYBURT":
                    comboBoxilce.Items.AddRange(new string[] { "AYDINTEPE", "BAYBURT", "DEM�R�Z�" });
                    break;
                case "KARAMAN":
                    comboBoxilce.Items.AddRange(new string[] { "AYRANCI", "BA�YAYLA", "ERMENEK", "KARAMAN", "KAZIMKARABEK�R", "SARIVEL�LER" });
                    break;
                case "KIRIKKALE":
                    comboBoxilce.Items.AddRange(new string[] { "BAH��L�", "BALI�EYH", "�ELEB�", "DEL�CE", "KARAKE��L�", "KESK�N", "KIRIKKALE", "SULAKYURT", "YAH��HAN" });
                    break;
                case "BATMAN":
                    comboBoxilce.Items.AddRange(new string[] { "BATMAN", "BE��R�", "GERC��", "HASANKEYF", "KOZLUK", "SASON" });
                    break;
                case "�IRNAK":
                    comboBoxilce.Items.AddRange(new string[] { "BEYT���EBAP", "C�ZRE", "G��L�KONAK", "�D�L", "S�LOP�", "�IRNAK", "ULUDERE" });
                    break;
                case "BARTIN":
                    comboBoxilce.Items.AddRange(new string[] { "AMASRA", "BARTIN", "KURUCA��LE", "ULUS" });
                    break;
                case "ARDAHAN":
                    comboBoxilce.Items.AddRange(new string[] { "ARDAHAN", "�ILDIR", "DAMAL", "G�LE", "HANAK", "POSOF" });
                    break;
                case "I�DIR":
                    comboBoxilce.Items.AddRange(new string[] { "ARALIK", "I�DIR", "KARAKOYUNLU", "TUZLUCA" });
                    break;
                case "YALOVA ":
                    comboBoxilce.Items.AddRange(new string[] { "ALTINOVA", "ARMUTLU", "�INARCIK", "��FTL�KK�Y", "TERMAL", "YALOVA" });
                    break;
                case "KARAB�K":
                    comboBoxilce.Items.AddRange(new string[] { "EFLAN�", "ESK�PAZAR", "KARAB�K", "OVACIK", "SAFRANBOLU", "YEN�CE" });
                    break;
                case "K�L�S":
                    comboBoxilce.Items.AddRange(new string[] { "ELBEYL�", "K�L�S", "MUSABEYL�", "POLATEL�" });
                    break;
                case "OSMAN�YE ":
                    comboBoxilce.Items.AddRange(new string[] { "BAH�E", "D�Z���", "HASANBEYL�", "KAD�RL�", "OSMAN�YE", "SUMBAS", "TOPRAKKALE" });
                    break;
                case "D�ZCE":
                    comboBoxilce.Items.AddRange(new string[] { "AK�AKOCA", "CUMAYER�", "��L�ML�", "D�ZCE", "G�LYAKA", "G�M��OVA", "KAYNA�LI", "YI�ILCA" });
                    break;
            }
        }
    }
}

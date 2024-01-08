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
                        MessageBox.Show("Kayýt baþvurunuz alýnmýþtýr. Ana sayfaya yönlendiriliyorsunuz.");

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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sehirler = { "ADANA", "ADIYAMAN", "AFYONKARAHÝSAR", "AÐRI", "AMASYA", "ANKARA", "ANTALYA", "ARTVÝN", "AYDIN", "BALIKESÝR", "BÝLECÝK", "BÝNGÖL", "BÝTLÝS", "BOLU", "BURDUR", "BURSA", "ÇANAKKALE", "ÇANKIRI", "ÇORUM", "DENÝZLÝ", "DÝYARBAKIR", "EDÝRNE", "ELAZIÐ", "ERZÝNCAN", "ERZURUM", "ESKÝÞEHÝR", "GAZÝANTEP", "GÝRESUN", "GÜMÜÞHANE", "HAKKARÝ", "HATAY", "ISPARTA", "MERSÝN", "ÝSTANBUL", "ÝZMÝR", "KARS", "KASTAMONU", "KAYSERÝ", "KIRKLARELÝ", "KIRÞEHÝR", "KOCAELÝ", "KONYA", "KÜTAHYA", "MALATYA", "MANÝSA", "KAHRAMANMARAÞ", "MARDÝN", "MUÐLA", "MUÞ", "NEVÞEHÝR", "NÝÐDE", "ORDU", "RÝZE", "SAKARYA", "SAMSUN", "SÝÝRT", "SÝNOP", "SÝVAS", "TEKÝRDAÐ", "TOKAT", "TRABZON", "TUNCELÝ", "ÞANLIURFA", "UÞAK", "VAN", "YOZGAT", "ZONGULDAK", "AKSARAY", "BAYBURT", "KARAMAN", "KIRIKKALE", "BATMAN", "ÞIRNAK", "BARTIN", "ARDAHAN", "IÐDIR", "YALOVA", "KARABÜK", "KÝLÝS", "OSMANÝYE", "DÜZCE" };
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
            listBox1.Items.Add(" D. TARÝHÝ : " + comboBox2.Text + " " + comboBox1.Text + " " + numericUpDown1.Value);
            listBox1.Items.Add(" ÝL : " + comboBoxsehir.Text);
            listBox1.Items.Add(" ÝLÇE : " + comboBoxilce.Text);
            if (radioButton1.Checked)
            {
                listBox1.Items.Add(" EHLÝYET TÝPÝ : " + radioButton1.Text);
            }
            if (radioButton2.Checked)
            {
                listBox1.Items.Add(" EHLÝYET TÝPÝ : " + radioButton2.Text);
            }
            if (radioButton3.Checked)
            {
                listBox1.Items.Add(" EHLÝYET TÝPÝ : " + radioButton3.Text);
            }
            if (radioButton4.Checked)
            {
                listBox1.Items.Add(" EHLÝYET TÝPÝ : " + radioButton4.Text);
            }
            if (radioButton5.Checked)
            {
                listBox1.Items.Add(" EHLÝYET TÝPÝ : " + radioButton5.Text);
            }
            if (radioButton6.Checked)
            {
                listBox1.Items.Add(" EHLÝYET TÝPÝ : " + radioButton6.Text);
            }
            if (radioButton7.Checked)
            {
                listBox1.Items.Add(" EHLÝYET TÝPÝ : " + radioButton7.Text);
            }
            if (radioButton8.Checked)
            {
                listBox1.Items.Add(" EHLÝYET TÝPÝ : " + radioButton8.Text);
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
                    comboBoxilce.Items.AddRange(new string[] { "ALADAÐ", "CEYHAN", "ÇUKUROVA", "FEKE", "ÝMAMOÐLU", "KARAÝSALI", "KARATAÞ", "KOZAN", "POZANTI", "SAÝMBEYLÝ", "SARIÇAM", "SEYHAN", "TUFANBEYLÝ", "YUMURTALIK", "YÜREÐÝR" });
                    break;
                case "ADIYAMAN":
                    comboBoxilce.Items.AddRange(new string[] { "BESNÝ", "ÇELÝKHAN", "GERGER", "GÖLBAÞI", "KAHTA", "SAMSAT", "SÝNCÝK", "TUT" });
                    break;
                case "AFYONKARAHÝSAR":
                    comboBoxilce.Items.AddRange(new string[] { "BAÞMAKÇI", "BAYAT", "BOLVADÝN", "ÇAY", "ÇOBANLAR", "DÝNAR", "EMÝRDAÐ", "EVCÝLER", "HOCALAR", "ÝHSANÝYE", "ÝSCEHÝSAR", "KIZILÖREN", "SANDIKLI", "SÝNANPAÞA", "SULTANDAÐI", "ÞUHUT" });
                    break;
                case "AÐRI":
                    comboBoxilce.Items.AddRange(new string[] { "DÝYADÝN", "DOÐUBEYAZIT", "ELEÞKÝRT", "HAMUR", "PATNOS", "TAÞLIÇAY", "TUTAK" });
                    break;
                case "AMASYA":
                    comboBoxilce.Items.AddRange(new string[] { "GÖYNÜCEK", "GÜMÜÞHACIKÖY", "HAMAMÖZÜ", "MERZÝFON", "SULUOVA", "TAÞOVA" });
                    break;
                case "ANKARA":
                    comboBoxilce.Items.AddRange(new string[] { "AKYURT", "ALTINDAÐ", "AYAÞ", "BALA", "BEYPAZARI", "ÇAMLIDERE", "ÇANKAYA", "ÇUBUK", "ELMADAÐ", "ETÝMESGUT", "EVREN", "GÖLBAÞI", "GÜDÜL", "HAYMANA", "KAHRAMANKAZAN", "KALECÝK", "KEÇÝÖREN", "KIZILCAHAMAM", "MAMAK", "NALLIHAN", "POLATLI", "PURSAKLAR", "SÝNCAN", "ÞEREFLÝKOÇHÝSAR", "YENÝMAHALLE" });
                    break;
                case "ANTALYA":
                    comboBoxilce.Items.AddRange(new string[] { "AKSEKÝ", "AKSU", "ALANYA", "DEMRE", "DÖÞEMEALTI", "ELMALI", "FÝNÝKE", "GAZÝPAÞA", "GÜNDOÐMUÞ", "ÝBRADI", "KALE", "KAÞ", "KEMER", "KEPEZ", "KONYAALTI", "KORKUTELÝ", "KUMLUCA", "MANAVGAT", "MURATPAÞA", "SERÝK" });
                    break;
                case "ARTVÝN":
                    comboBoxilce.Items.AddRange(new string[] { "ARHAVÝ", "BORÇKA", "HOPA", "MURGUL", "ÞAVÞAT", "YUSUFELÝ" });
                    break;
                case "AYDIN":
                    comboBoxilce.Items.AddRange(new string[] { "BOZDOÐAN", "BUHARKENT", "ÇÝNE", "DÝDÝM", "EFELER", "GERMENCÝK", "ÝNCÝRLÝOVA", "KARACASU", "KOÇARLI", "KÖÞK", "KUÞADASI", "KUYUCAK", "NAZÝLLÝ", "SÖKE", "SULTANHÝSAR", "YENÝPAZAR" });
                    break;
                case "BALIKESÝR":
                    comboBoxilce.Items.AddRange(new string[] { "ALTIEYLÜL", "AYVALIK", "BANDIRMA", "BÝGADÝÇ", "BURHANÝYE", "DURSUNBEY", "EDREMÝT", "ERDEK", "GÖMEÇ", "HAVRAN", "ÝVRÝNDÝ", "KARESÝ", "KEPSUT", "MANYAS", "MARMARA", "SAVAÞTEPE", "SINDIRGI", "SUSURLUK" });
                    break;
                case "BÝLECÝK":
                    comboBoxilce.Items.AddRange(new string[] { "BOZÜYÜK", "GÖLPAZARI", "ÝNHÝSAR", "OSMANELÝ", "PAZARYERÝ", "SÖÐÜT", "YENÝPAZAR" });
                    break;
                case "BÝNGÖL":
                    comboBoxilce.Items.AddRange(new string[] { "ADAKLI", "GENÇ", "KARLIOVA", "KÝÐI", "SOLHAN", "YAYLADERE", "YEDÝSU" });
                    break;
                case "BÝTLÝS":
                    comboBoxilce.Items.AddRange(new string[] { "ADÝLCEVAZ", "AHLAT", "GÜROYMAK", "HÝZAN", "MUTKÝ", "TATVAN" });
                    break;
                case "BOLU":
                    comboBoxilce.Items.AddRange(new string[] { "DÖRTDÝVAN", "GEREDE", "GÖYNÜK", "KIBRISCIK", "MENGEN", "MUDURNU", "SEBEN", "YENÝÇAÐA" });
                    break;
                case "BURDUR":
                    comboBoxilce.Items.AddRange(new string[] { "AÐLASUN", "ALTINYAYLA", "BUCAK", "ÇAVDIR", "ÇELTÝKÇÝ", "GÖLHÝSAR", "KARAMANLI", "KEMER", "TEFENNÝ", "YEÞÝLOVA" });
                    break;
                case "BURSA":
                    comboBoxilce.Items.AddRange(new string[] { "BÜYÜKORHAN", "GEMLÝK", "GÜRSU", "HARMANCIK", "ÝNEGÖL", "ÝZNÝK", "KARACABEY", "KELES", "KESTEL", "MUDANYA", "MUSTAFAKEMALPAÞA", "NÝLÜFER", "ORHANELÝ", "ORHANGAZÝ", "OSMANGAZÝ", "YILDIRIM" });
                    break;
                case "ÇANAKKALE":
                    comboBoxilce.Items.AddRange(new string[] { "AYVACIK", "BAYRAMÝÇ", "BÝGA", "BOZCAADA", "ÇAN", "ECEABAT", "EZÝNE", "GELÝBOLU", "GÖKÇEADA", "LAPSEKÝ", "YENÝCE" });
                    break;
                case "ÇANKIRI":
                    comboBoxilce.Items.AddRange(new string[] { "ATKARACALAR", "BAYRAMÖREN", "ÇERKEÞ", "ELDÝVAN", "ILGAZ", "KIZILIRMAK", "KORGUN", "KURÞUNLU", "ORTA", "ÞABANÖZÜ", "YAPRAKLI" });
                    break;
                case "ÇORUM":
                    comboBoxilce.Items.AddRange(new string[] { "ALACA", "BAYAT", "BOÐAZKALE", "DODURGA", "ÝSKÝLÝP", "KARGI", "LAÇÝN", "MECÝTÖZÜ", "OÐUZLAR", "ORTAKÖY", "OSMANCIK", "SUNGURLU", "UÐURLUDAÐ" });
                    break;
                case "DENÝZLÝ":
                    comboBoxilce.Items.AddRange(new string[] { "ACIPAYAM", "BABADAÐ", "BAKLAN", "BEKÝLLÝ", "BEYAÐAÇ", "BOZKURT", "BULDAN", "ÇAL", "ÇAMELÝ", "ÇARDAK", "ÇÝVRÝL", "GÜNEY", "HONAZ", "KALE", "MERKEZEFENDÝ", "PAMUKKALE", "SARAYKÖY", "SERÝNHÝSAR", "TAVAS" });
                    break;
                case "DÝYARBAKIR":
                    comboBoxilce.Items.AddRange(new string[] { "BAÐLAR", "BÝSMÝL", "ÇERMÝK", "ÇINAR", "ÇÜNGÜÞ", "DÝCLE", "EÐÝL", "ERGANÝ", "HANÝ", "HAZRO", "KAYAPINAR", "KOCAKÖY", "KULP", "LÝCE", "SÝLVAN", "SUR", "YENÝÞEHÝR" });
                    break;
                case "EDÝRNE":
                    comboBoxilce.Items.AddRange(new string[] { "ENEZ", "HAVSA", "ÝPSALA", "KEÞAN", "LALAPAÞA", "MERÝÇ", "SÜLOÐLU", "UZUNKÖPRÜ" });
                    break;
                case "ELAZIÐ":
                    comboBoxilce.Items.AddRange(new string[] { "AÐIN", "ALACAKAYA", "ARICAK", "BASKÝL", "KARAKOÇAN", "KEBAN", "KOVANCILAR", "MADEN", "PALU", "SÝVRÝCE" });
                    break;
                case "ERZÝNCAN":
                    comboBoxilce.Items.AddRange(new string[] { "ÇAYIRLI", "ÝLÝÇ", "KEMAH", "KEMALÝYE", "OTLUKBELÝ", "REFAHÝYE", "TERCAN", "ÜZÜMLÜ" });
                    break;
                case "ERZURUM":
                    comboBoxilce.Items.AddRange(new string[] { "AÞKALE", "AZÝZÝYE", "ÇAT", "HINIS", "HORASAN", "ÝSPÝR", "KARAÇOBAN", "KARAYAZI", "KÖPRÜKÖY", "NARMAN", "OLTU", "OLUR", "PALANDÖKEN", "PASÝNLER", "PAZARYOLU", "ÞENKAYA", "TEKMAN", "TORTUM", "YAKUTÝYE" });
                    break;
                case "ESKÝÞEHÝR":
                    comboBoxilce.Items.AddRange(new string[] { "ALPU", "BEYLÝKOVA", "ÇÝFTELER", "GÜNYÜZÜ", "HAN", "ÝNÖNÜ", "MAHMUDÝYE", "MÝHALGAZÝ", "MÝHALIÇÇIK", "ODUNPAZARI", "SARICAKAYA", "SEYÝTGAZÝ", "SÝVRÝHÝSAR", "TEPEBAÞI" });
                    break;
                case "GAZÝANTEP":
                    comboBoxilce.Items.AddRange(new string[] { "ARABAN", "KARKAMIÞ", "NÝZÝP", "OGUZELÝ", "ÞAHÝNBEY", "ÞEHÝTKAMÝL", "YAVUZELÝ" });
                    break;
                case "GÝRESUN":
                    comboBoxilce.Items.AddRange(new string[] { "ALUCRA", "BULANCAK", "ÇAMOLUK", "ÇANAKÇI", "DERELÝ", "DOÐANKENT", "ESPÝYE", "EYNESÝL", "GÖRELE", "GÜCE", "KEÞAP", "PÝRAZÝZ", "ÞEBÝNKARAHÝSAR", "TÝREBOLU", "YAÐLIDERE" });
                    break;
                case "GÜMÜÞHANE":
                    comboBoxilce.Items.AddRange(new string[] { "KELKÝT", "KÖSE", "KÜRTÜN", "ÞÝRAN", "TORUL" });
                    break;
                case "HAKKARÝ":
                    comboBoxilce.Items.AddRange(new string[] { "ÇUKURCA", "ÞEMDÝNLÝ", "YÜKSEKOVA" });
                    break;
                case "HATAY":
                    comboBoxilce.Items.AddRange(new string[] { "ALTINÖZÜ", "ANTAKYA", "ARSUZ", "BELEN", "DEFNE", "DÖRTYOL", "ERZÝN", "HASSA", "ÝSKENDERUN", "KIRIKHAN", "KUMLU", "PAYAS", "REYHANLI", "SAMANDAÐ", "YAYLADAÐI" });
                    break;
                case "ISPARTA":
                    comboBoxilce.Items.AddRange(new string[] { "AKSU", "ATABEY", "EÐÝRDÝR", "GELENDOST", "GÖNEN", "KEÇÝBORLU", "SENÝRKENT", "SÜTÇÜLER", "ÞARKÝKARAAÐAÇ", "ULUBORLU", "YALVAÇ", "YENÝÞARBADEMLÝ" });
                    break;
                case "MERSÝN":
                    comboBoxilce.Items.AddRange(new string[] { "AKDENÝZ", "ANAMUR", "AYDINCIK", "BOZYAZI", "ÇAMLIYAYLA", "ERDEMLÝ", "GÜLNAR", "MEZÝTLÝ", "MUT", "SÝLÝFKE", "TARSUS", "TOROSLAR", "YENÝÞEHÝR" });
                    break;
                case "ÝSTANBUL":
                    comboBoxilce.Items.AddRange(new string[] { "ADALAR", "ARNAVUTKÖY", "ATAÞEHÝR", "AVCILAR", "BAÐCILAR", "BAHÇELÝEVLER", "BAKIRKÖY", "BAÞAKÞEHÝR", "BAYRAMPAÞA", "BEÞÝKTAÞ", "BEYKOZ", "BEYLÝKDÜZÜ", "BEYOÐLU", "BÜYÜKÇEKMECE", "ÇATALCA", "ÇEKMEKÖY", "ESENLER", "ESENYURT", "EYÜPSULTAN", "FATÝH", "GAZÝOSMANPAÞA", "GÜNGÖREN", "KADIKÖY", "KAÐITHANE", "KARTAL", "KÜÇÜKÇEKMECE", "MALTEPE", "PENDÝK", "SANCAKTEPE", "SARIYER", "ÞÝLE", "ÞÝÞLÝ", "SULTANBEYLÝ", "SULTANGAZÝ", "TUZLA", "ÜMRANÝYE", "ÜSKÜDAR", "ZEYTÝNBURNU" });
                    break;
                case "ÝZMÝR":
                    comboBoxilce.Items.AddRange(new string[] { "ALÝAÐA", "BALÇOVA", "BAYINDIR", "BAYRAKLI", "BERGAMA", "BEYDAÐ", "BORNOVA", "BUCA", "ÇEÞME", "ÇÝÐLÝ", "DÝKÝLÝ", "FOÇA", "GAZÝEMÝR", "GÜZELBAHÇE", "KARABAÐLAR", "KARABURUN", "KARÞIYAKA", "KEMALPAÞA", "KINIK", "KÝRAZ", "KONAK", "MENDERES", "MENEMEN", "NARLIDERE", "ÖDEMÝÞ", "SEFERÝHÝSAR", "SELÇUK", "TÝRE", "TORBALI", "URLA" });
                    break;
                case "KARS":
                    comboBoxilce.Items.AddRange(new string[] { "AKYAKA", "ARPAÇAY", "DÝGOR", "KAÐIZMAN", "SARIKAMIÞ", "SELÝM", "SUSUZ" });
                    break;
                case "KASTAMONU":
                    comboBoxilce.Items.AddRange(new string[] { "ABANA", "AÐLI", "ARAÇ", "AZDAVAY", "BOZKURT", "CÝDE", "ÇATALZEYTÝN", "DADAY", "DEVREKANÝ", "DOÐANYURT", "HANÖNÜ", "ÝHSANGAZÝ", "ÝNEBOLU", "KÜRE", "MERKEZ", "PINARBAÞI", "SEYDÝLER", "ÞENPAZAR", "TAÞKÖPRÜ", "TOSYA" });
                    break;
                case "KAYSERÝ":
                    comboBoxilce.Items.AddRange(new string[] { "AKKIÞLA", "BÜNYAN", "DEVELÝ", "FELAHÝYE", "HACILAR", "ÝNCESU", "KOCASÝNAN", "MELÝKGAZÝ", "ÖZVATAN", "PINARBAÞI", "SARIOÐLAN", "SARIZ", "TALAS", "TOMARZA", "YAHYALI", "YEÞÝLHÝSAR" });
                    break;
                case "KIRKLARELÝ":
                    comboBoxilce.Items.AddRange(new string[] { "BABAESKÝ", "DEMÝRKÖY", "KOFÇAZ", "LÜLEBURGAZ", "MERKEZ", "PEHLÝVANKÖY", "PINARHÝSAR", "VÝZE" });
                    break;
                case "KIRÞEHÝR":
                    comboBoxilce.Items.AddRange(new string[] { "AKÇAKENT", "AKPINAR", "BOZTEPE", "ÇÝÇEKDAÐI", "KAMAN", "MERKEZ", "MUCUR" });
                    break;
                case "KOCAELÝ":
                    comboBoxilce.Items.AddRange(new string[] { "BAÞÝSKELE", "ÇAYIROVA", "DARICA", "DERÝNCE", "DÝLOVASI", "GEBZE", "GÖLCÜK", "ÝZMÝT", "KANDIRA", "KARAMÜRSEL", "KARTEPE", "KÖRFEZ" });
                    break;
                case "KONYA":
                    comboBoxilce.Items.AddRange(new string[] { "AHÝLER", "AKÖREN", "AKÞEHÝR", "ALTINEKÝN", "BEYÞEHÝR", "BOZKIR", "CÝHANBEYLÝ", "ÇELTÝK", "ÇUMRA", "DERBENT", "DEREBUCAK", "DOÐANHÝSAR", "EMÝRGAZÝ", "EREÐLÝ", "GÜNEYSINIR", "HADÝM", "HALKAPINAR", "HÜYÜK", "ILGIN", "KADINHANI", "KARAPINAR", "KARATAY", "KULU", "MERAM", "SARAYÖNÜ", "SELÇUKLU", "SEYDÝÞEHÝR", "TAÞKENT", "TUZLUKÇU", "YALIHÜYÜK", "YUNAK" });
                    break;
                case "KÜTAHYA":
                    comboBoxilce.Items.AddRange(new string[] { "ALTINTAÞ", "ASLANAPA", "ÇAVDARHÝSAR", "DOMANÝÇ", "DUMLUPINAR", "EMET", "GEDÝZ", "HÝSARCIK", "MERKEZ", "PAZARLAR", "SÝMAV", "ÞAPHANE", "TAVÞANLI" });
                    break;
                case "MALATYA":
                    comboBoxilce.Items.AddRange(new string[] { "AKÇADAÐ", "ARAPGÝR", "ARGUVAN", "BATTALGAZÝ", "DARENDE", "DOÐANÞEHÝR", "DOÐANYOL", "HEKÝMHAN", "KALE", "KULUNCAK", "PÖTÜRGE", "YEÞÝLYURT" });
                    break;
                case "MANÝSA":
                    comboBoxilce.Items.AddRange(new string[] { "AHMETLÝ", "AKHÝSAR", "ALAÞEHÝR", "DEMÝRCÝ", "GÖLMARMARA", "GÖRDES", "KIRKAÐAÇ", "KÖPRÜBAÞI", "KULA", "SALÝHLÝ", "SARIGÖL", "SARUHANLI", "SELENDÝ", "SOMA", "ÞEHZADELER", "TURGUTLU", "YUNUSEMRE" });
                    break;
                case "MARDÝN":
                    comboBoxilce.Items.AddRange(new string[] { "ARTUKLU", "DARGEÇÝT", "DERÝK", "KIZILTEPE", "MAZIDAÐI", "MÝDYAT", "NUSAYBÝN", "ÖMERLÝ", "SAVUR", "YEÞÝLLÝ" });
                    break;
                case "MUÐLA":
                    comboBoxilce.Items.AddRange(new string[] { "BODRUM", "DALAMAN", "DATÇA", "FETHÝYE", "KAVAKLIDERE", "KÖYCEÐÝZ", "MARMARÝS", "MÝLAS", "MENTEÞE" , "ORTACA", "ULA", "YATAÐAN" });
                    break;
                case "MUÞ":
                    comboBoxilce.Items.AddRange(new string[] { "BULANIK", "HASKÖY", "KORKUT", "MALAZGÝRT", "VARTO" });
                    break;
                case "NEVÞEHÝR":
                    comboBoxilce.Items.AddRange(new string[] { "ACIGÖL", "AVANOS", "DERÝNKUYU", "GÜLÞEHÝR", "HACIBEKTAÞ", "KALESAKÝZÝ", "KOZAKLI", "NEVÞEHÝR", "ÜRGÜP" });
                    break;
                case "NÝÐDE":
                    comboBoxilce.Items.AddRange(new string[] { "ALTUNHÝSAR", "BOR", "ÇAMARDI", "ÇÝFTLÝK", "NÝÐDE", "ULUKIÞLA" });
                    break;
                case "ORDU":
                    comboBoxilce.Items.AddRange(new string[] { "AKKUÞ", "AYBASTI", "ÇAMAÞ", "ÇATALPINAR", "ÇAYBAÞI", "FATSA", "GÖLKÖY", "GÜLYALI", "GÜRGENTEPE", "ÝKÝZCE", "KABADÜZ", "KABATAÞ", "KORGAN", "KUMRU", "MESUDÝYE", "ORDU", "PERÞEMBE", "ULUBEY", "ÜNYE" });
                    break;
                case "OSMANÝYE":
                    comboBoxilce.Items.AddRange(new string[] { "BAHÇE", "DÜZÝÇÝ", "HASANBEYLÝ", "KADÝRLÝ", "OSMANÝYE", "SUMBAS", "TOPRAKKALE" });
                    break;
                case "RÝZE":
                    comboBoxilce.Items.AddRange(new string[] { "ARDEÞEN", "ÇAMLIHEMÞÝN", "ÇAYELÝ", "DEREPAZARI", "FINDIKLI", "GÜNEYSU", "HEMÞÝN", "ÝKÝZDERE", "ÝYÝDERE", "KALKANDERE", "PAZAR", "RÝZE" });
                    break;
                case "SAKARYA":
                    comboBoxilce.Items.AddRange(new string[] { "ADAPAZARI", "AKYAZI", "ARÝFÝYE", "ERENLER", "FERÝZLÝ", "GEYVE", "HENDEK", "KARAPÜRÇEK", "KARASU", "KAYNARCA", "KOCAALÝ", "PAMUKOVA", "SAPANCA", "SERDÝVAN", "SÖÐÜTLÜ", "TARAKLI" });
                    break;
                case "SAMSUN":
                    comboBoxilce.Items.AddRange(new string[] { "ALAÇAM", "ASARCIK", "ATAKUM", "AYVACIK", "BAFRA", "CANÝK", "ÇARÞAMBA", "HAVZA", "ÝLKADIM", "KAVAK", "LADÝK", "OMYA", "SALIPAZARI", "TEKKEKÖY", "TERME", "VEZÝRKÖPRÜ", "YAKAKENT" });
                    break;
                case "SÝÝRT":
                    comboBoxilce.Items.AddRange(new string[] { "AYDINLAR", "BAYKAN", "ERUH", "KURTALAN", "PERVARÝ", "ÞÝRVAN", "SÝÝRT" });
                    break;
                case "SÝNOP":
                    comboBoxilce.Items.AddRange(new string[] { "AYANCIK", "BOYABAT", "DÝKMEN", "DURAÐAN", "ERFELEK", "GERZE", "SARAYDÜZÜ", "SÝNOP", "TÜRKELÝ" });
                    break;
                case "SÝVAS":
                    comboBoxilce.Items.AddRange(new string[] { "AKINCILAR", "ALTINYAYLA", "DÝVRÝÐÝ", "DOÐANÞAR", "GEMEREK", "GÖLOVA", "GÜRÜN", "HAFÝK", "ÝMRANLI", "KANGAL", "KOYULHÝSAR", "SUÞEHRÝ", "ÞARKIÞLA", "ULAÞ", "YILDIZELÝ", "ZARA" });
                    break;
                case "TEKÝRDAÐ":
                    comboBoxilce.Items.AddRange(new string[] { "ÇERKEZKÖY", "ÇORLU", "ERGENE", "HAYRABOLU", "KAPAKLI", "MALKARA", "MARMARAEREÐLÝSÝ", "MURATLI", "SARAY", "SÜLEYMANPAÞA", "ÞARKÖY" });
                    break;
                case "TOKAT":
                    comboBoxilce.Items.AddRange(new string[] { "ALMUS", "ARTOVA", "BAÞÇÝFTLÝK", "ERBAA", "NÝKSAR", "PAZAR", "REÞADÝYE", "SULUSARAY", "TOKAT", "TURHAL", "YEÞÝLYURT", "ZÝLE" });
                    break;
                case "TRABZON":
                    comboBoxilce.Items.AddRange(new string[] { "AKÇAABAT", "ARAKLI", "ARÞÝN", "BEÞÝKDÜZÜ", "ÇARÞIBAÞI", "ÇAYKARA", "DERNEKPAZAR", "DÜZKÖY", "HAYRAT", "KÖPRÜBAÞI", "MAÇKA", "OF", "ORTAHÝSAR", "SÜRMENE", "ÞALPAZARI", "TONYA", "VAKFÝKEBÝR", "YOMRA" });
                    break;
                case "TUNCELÝ":
                    comboBoxilce.Items.AddRange(new string[] { "ÇEMÝÞGEZEK", "HOZAT", "MAZGÝRT", "NAZIMÝYE", "OVACIK", "PERTER", "PÜLÜMÜR", "TUNCELÝ" });
                    break;
                case "ÞANLIURFA":
                    comboBoxilce.Items.AddRange(new string[] { "AKÇAKALE", "BÝRECÝK", "BOZOVA", "CEYLANPINAR", "EYYÜBÝYE", "HALFETÝ", "HALÝLÝYE", "HARRAN", "HÝLVAN", "KARAKÖPRÜ", "SÝVEREK", "SURUÇ", "VÝRANÞEHÝR" });
                    break;
                case "UÞAK":
                    comboBoxilce.Items.AddRange(new string[] { "BANAZ", "EÞME", "KARAHALLI", "SÝVASLI", "ULUBEY", "UÞAK" });
                    break;
                case "VAN":
                    comboBoxilce.Items.AddRange(new string[] { "BAHÇESARAY", "BAÞKALE", "ÇALDIRAN", "ÇATAK", "EDREMÝT", "ERCÝÞ", "GEVAÞ", "GÜRPINAR", "ÝPEKYOLU", "MURADÝYE", "ÖZALP", "SARAY", "TUÞBA" });
                    break;
                case "YALOVA":
                    comboBoxilce.Items.AddRange(new string[] { "ALTINOVA", "ARMUTLU", "ÇINARCIK", "ÇÝFTLÝKKÖY", "TERMAL", "YALOVA" });
                    break;
                case "YOZGAT":
                    comboBoxilce.Items.AddRange(new string[] { "AKDAÐMADENÝ", "AYDINCIK", "BOÐAZLIYAN", "ÇANDIR", "ÇAYIRALAN", "ÇEKEREK", "KADIÞEHRÝ", "SARIKAYA", "SORGUN", "ÞEFAATLÝ", "YENÝFAKILI", "YOZGAT", "YERKÖY" });
                    break;
                case "ZONGULDAK":
                    comboBoxilce.Items.AddRange(new string[] { "ALAPLI", "ÇAYCUMA", "DEVREK", "EREÐLÝ", "GÖKÇEBEY", "KÝLÝMLÝ", "KOZLU", "ZONGULDAK" });
                    break;
                case "AKSARAY":
                    comboBoxilce.Items.AddRange(new string[] { "AÐAÇÖREN", "AKSARAY", "ESKÝL", "GÜLAÐAÇ", "GÜZELYURT", "ORTAKÖY", "SARIYAHÞÝ" });
                    break;
                case "BAYBURT":
                    comboBoxilce.Items.AddRange(new string[] { "AYDINTEPE", "BAYBURT", "DEMÝRÖZÜ" });
                    break;
                case "KARAMAN":
                    comboBoxilce.Items.AddRange(new string[] { "AYRANCI", "BAÞYAYLA", "ERMENEK", "KARAMAN", "KAZIMKARABEKÝR", "SARIVELÝLER" });
                    break;
                case "KIRIKKALE":
                    comboBoxilce.Items.AddRange(new string[] { "BAHÞÝLÝ", "BALIÞEYH", "ÇELEBÝ", "DELÝCE", "KARAKEÇÝLÝ", "KESKÝN", "KIRIKKALE", "SULAKYURT", "YAHÞÝHAN" });
                    break;
                case "BATMAN":
                    comboBoxilce.Items.AddRange(new string[] { "BATMAN", "BEÞÝRÝ", "GERCÜÞ", "HASANKEYF", "KOZLUK", "SASON" });
                    break;
                case "ÞIRNAK":
                    comboBoxilce.Items.AddRange(new string[] { "BEYTÜÞÞEBAP", "CÝZRE", "GÜÇLÜKONAK", "ÝDÝL", "SÝLOPÝ", "ÞIRNAK", "ULUDERE" });
                    break;
                case "BARTIN":
                    comboBoxilce.Items.AddRange(new string[] { "AMASRA", "BARTIN", "KURUCAÞÝLE", "ULUS" });
                    break;
                case "ARDAHAN":
                    comboBoxilce.Items.AddRange(new string[] { "ARDAHAN", "ÇILDIR", "DAMAL", "GÖLE", "HANAK", "POSOF" });
                    break;
                case "IÐDIR":
                    comboBoxilce.Items.AddRange(new string[] { "ARALIK", "IÐDIR", "KARAKOYUNLU", "TUZLUCA" });
                    break;
                case "YALOVA ":
                    comboBoxilce.Items.AddRange(new string[] { "ALTINOVA", "ARMUTLU", "ÇINARCIK", "ÇÝFTLÝKKÖY", "TERMAL", "YALOVA" });
                    break;
                case "KARABÜK":
                    comboBoxilce.Items.AddRange(new string[] { "EFLANÝ", "ESKÝPAZAR", "KARABÜK", "OVACIK", "SAFRANBOLU", "YENÝCE" });
                    break;
                case "KÝLÝS":
                    comboBoxilce.Items.AddRange(new string[] { "ELBEYLÝ", "KÝLÝS", "MUSABEYLÝ", "POLATELÝ" });
                    break;
                case "OSMANÝYE ":
                    comboBoxilce.Items.AddRange(new string[] { "BAHÇE", "DÜZÝÇÝ", "HASANBEYLÝ", "KADÝRLÝ", "OSMANÝYE", "SUMBAS", "TOPRAKKALE" });
                    break;
                case "DÜZCE":
                    comboBoxilce.Items.AddRange(new string[] { "AKÇAKOCA", "CUMAYERÝ", "ÇÝLÝMLÝ", "DÜZCE", "GÖLYAKA", "GÜMÜÞOVA", "KAYNAÞLI", "YIÐILCA" });
                    break;
            }
        }
    }
}

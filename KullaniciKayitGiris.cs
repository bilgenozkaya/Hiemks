using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace bitirme_bilgen
{
    public partial class KullaniciKayitGiris : Form
    {
        int hata = 0; // kullanici girislerinde gerceklesebilir dolum hatalarini onlemek ve kontrol etmek icin

        public KullaniciKayitGiris()
        {
            InitializeComponent();
        }

        // giris sirasinda girilen epostayi kontrol eder.
        public void ePostaGirisKontrol()
        {
            if (!this.txtGirisEposta.Text.Contains('@') || !this.txtGirisEposta.Text.Contains('.'))
            {
                MessageBox.Show("Lutfen Duzgun bir e posta giriniz", "Eposta Uyarisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGGiris.Enabled = false;
                this.Close();
                
            }
            
        }
        // kayit sirasinda girilen epostayi kontrol eder.
        public void ePostaKayitKontrol()
        {
            if (!this.txtKayitEposta.Text.Contains('@') || !this.txtKayitEposta.Text.Contains('.'))
            {
                MessageBox.Show("Lutfen Duzgun bir e posta giriniz", "Eposta Uyarisi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnKayit.Enabled = false;
                this.Close();
            }

        }
        public void kontrolKayit()
        {
            if (txtKayitEposta.Text == string.Empty)
                hata = 1;

            if (txtKayitParola1.Text == string.Empty)
                hata = 1;

            if (txtKayitParola2.Text == string.Empty)
                hata = 1;

            if (hata == 1)
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void kontrolGiris()
        {
            if (txtGirisEposta.Text == string.Empty)
                hata = 1;

            if (txtGirisParola.Text == string.Empty)
                hata = 1;

            if (hata == 1)
            {
                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool kontrol = false; // kayit e posta kontrol ve db kontrol

        public void kayitEpostaAdiKontrol()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-INRNTK1\SQL2014;Initial Catalog=bitirme;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter(" Select Count(*) from LOGIN where USERNAME='" + txtKayitEposta.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                kontrol = true;
                MessageBox.Show("lutfen kendinize ait e postayi giriniz. \n Bu '" + txtKayitEposta.Text + "' kullanici adi mevcuttur. ");
            }
        }

        // ilk kullanici kaydi butonu
        private void btnKayit_Click(object sender, EventArgs e)
        {
            kontrolKayit();
            ePostaKayitKontrol();
            kayitEpostaAdiKontrol();
            
            if (txtKayitParola1.Text == txtKayitParola2.Text) // parola kontrol bllogu
            {
                if (kontrol == false) //essiz e posta girilmisse kayda alir. kod blogu calisir
                {
                    // db baglanti ve komut calistirma kodlari
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-INRNTK1\SQL2014;Initial Catalog=bitirme;Integrated Security=True;");
                    string strng = "INSERT into LOGIN (USERNAME,PASSWORD) VALUES('" + txtKayitEposta.Text + "','" + txtKayitParola1.Text + "');";
                    con.Open(); // db bağlantısı açıldı
                    SqlCommand cmd = new SqlCommand(strng, con);
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    AramaMotoru hiemam = new AramaMotoru(); // main formundan nesne olusturduk ve gosterdik 
                    hiemam.Show();
                    hiemam.lblKullaniciAdi.Text = txtKayitEposta.Text;
                    con.Close();// db bağlantısı kapandı
                }
            }
            else
            {
                MessageBox.Show("lutfen her iki parolayi ayni giriniz ve girdiginizden emin olunuz ");
            }
        }

        private void btnKCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGGiris_Click(object sender, EventArgs e)
        {
            kontrolGiris();
            ePostaGirisKontrol();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-INRNTK1\SQL2014;Initial Catalog=bitirme;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter(" Select Count(*) from LOGIN where USERNAME='" + txtGirisEposta.Text + "'and PASSWORD ='" + txtGirisParola.Text + "'", con);


            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                AramaMotoru hiemam = new AramaMotoru(); // hiemam  : hamileler için etken madde arama motoru kısaltımı
                hiemam.Show();
                hiemam.lblKullaniciAdi.Text = txtGirisEposta.Text;
             //   ss.lblKullaniciAdi.Text = ss.lblKullaniciAdi.Text.Substring(0, ss.lblKullaniciAdi.Text.IndexOf('@'));
               
            }
            else
            {
                MessageBox.Show("lutfen dogru girin");
            }
        }

        private void btnGCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KullaniciKayitGiris_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

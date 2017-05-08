using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;
using System.Data.SqlClient;
using System.Threading;
using System.IO;

namespace bitirme_bilgen
{
    public partial class AramaMotoru : Form
    {
        public String html;
        public Uri url;
        public static bool secenek = false; // Main formu ile Form2(veri analiz ) formu arasinda secim saglamasi icin 
                                            // public static bool isDb = true; // bool veri degeri arama yaparken onecligin veritabani mi yoksa internetten veri madenciligi ile arama mi yapmayi ayirt eder.
        static string conString = @"Data Source=DESKTOP-INRNTK1\SQL2014;Initial Catalog=bitirme;Integrated Security=True;";

        public AramaMotoru()
        {
            InitializeComponent();
        }

        private void AramaMotoru_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
       
        public void gebelikIlacKategoriDurum()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-INRNTK1\SQL2014;Initial Catalog=bitirme;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter(" Select Count(*) from GEBELIK_KATEGORI where ETKEN_MADDE_ADI='" + txtEtkenMaddeArama.Text + "'", con);
            SqlConnection baglantiGK = new SqlConnection(conString);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                string gebelikKategori = "";

                baglantiGK.Open();
                /// burada db den sayac degerimizi cektik
                string gebelikKategoriTuru = "Select GEBELIK_KATEGORI_ADI from GEBELIK_KATEGORI where ETKEN_MADDE_ADI='" + txtEtkenMaddeArama.Text + "'";
                SqlCommand komutGK = new SqlCommand(gebelikKategoriTuru, baglantiGK);
                SqlDataAdapter da = new SqlDataAdapter(komutGK);
                SqlDataReader dr = komutGK.ExecuteReader();
                if (dr.Read()) //Sadece tek bir kayıt döndürüleceği için while kullanmadım.
                {
                    //Datareader ile okunan verileri form kontrollerine aktardık.
                    gebelikKategori = dr["GEBELIK_KATEGORI_ADI"].ToString();

                    switch (gebelikKategori)
                    {
                        case "A": lblUyari.Text = " HAMILELER ICIN UYGUNDUR. "; listBox1.Items.Add("A"); break;
                        case "B": lblUyari.Text = " HAMILELER ICIN UYGUNDUR. "; listBox1.Items.Add("B"); break;
                        case "C": lblUyari.Text = " HAMILELER ICIN UYGUN OLABILIR \n FAKAT \n DOKTOR GOZETIMINDE KULLANILMALIDIR. "; listBox1.Items.Add("C"); break;
                        case "D": lblUyari.Text = " HAMILELER ICIN UYGUN DEGILDIR. "; listBox1.Items.Add("D"); break;
                        case "X": lblUyari.Text = " HAMILELER ICIN UYGUN DEGILDIR. "; listBox1.Items.Add("X"); break;
                        default:
                            MessageBox.Show("Hatali Bir Etken Madde Girdiniz.\n" + txtEtkenMaddeArama.Text + " maddesinin, etken maddesini giriniz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    }
                }
            }
            else
            {
                gebelikDurum();
            }
        }


        public void gebelikDurum()
        {
            // gebelikDurum methodu her calistiginda listbox icini temizliyoruz.
            lstbIlacListele.Items.Clear();

            //Hedef kaynak urlmiz. Bu url yardimi ile belirtilen kelimeyi aratip sonucu buluyoruz.
            //Adresten istek yapıp, html kodlarını indiriyor.
            Uri url = new Uri("https://tr.wikipedia.org/wiki/" + txtEtkenMaddeArama.Text);
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string html = client.DownloadString(url);

            // İndirdiğimiz html kodlarını bir HtmlDocment nesnesine yüklüyorum.     
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);

            try
            {  // Html dökümanı içndeki a etiketlerinden title'ı  Gebelik kategorisi olanları liste halinde alıyorum.
                HtmlNodeCollection basliklar = dokuman.DocumentNode.SelectNodes("//a[@title='Gebelik kategorisi']");

                // basliklar koleksiyonunu tek tek gezerek, her bir elemanının içindeki text'i alıyorum 
                foreach (var baslik in basliklar)
                {
                    listBox1.Items.Add(baslik.InnerText);
                }
                listBox1.Items.RemoveAt(0);
                listBox1.Items.RemoveAt(1);
                // Gebelik kategorisinin ABD ye uygun olarak A,B,C,D,X karakterleri olarak doktara sunuyorum. 
                MessageBox.Show(listBox1.Items.Count.ToString());
                //Gelen gebelik kategorilerine gore secim yapip, uyari verdiriyorum.
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    switch (listBox1.Items[i].ToString())
                    {
                        case "A": lblUyari.Text = " HAMILELER ICIN UYGUNDUR. ";  break;
                        case "B": lblUyari.Text = " HAMILELER ICIN UYGUNDUR. ";  break;
                        case "C": lblUyari.Text = " HAMILELER ICIN UYGUN OLABILIR \n FAKAT \n DOKTOR GOZETIMINDE KULLANILMALIDIR. ";  break;
                        case "D": lblUyari.Text = " HAMILELER ICIN UYGUN DEGILDIR. ";  break;
                        case "X": lblUyari.Text = " HAMILELER ICIN UYGUN DEGILDIR. ";  break;
                        default:
                            MessageBox.Show("Hatali Bir Etken Madde Girdiniz.\n" + txtEtkenMaddeArama.Text + " maddesinin, etken maddesini giriniz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    }
                }
            }
            catch (NullReferenceException) //yaratılmamış bir nesneye  değer atama veya değer okuma hatasi geri donerse
            {
                if (MessageBox.Show("Hatali Etken Madde Girdiniz.\n" + txtEtkenMaddeArama.Text + " maddesinin, etken maddesini giriniz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                { }

            }
        }


        

        public void ilacListele()
        {
            string html1 = "";

            // ilacListele methodu her calistiginda listbox icini temizliyoruz.
            lstbIlacListele.Items.Clear();

            //Hedef kaynak urlmiz. Bu url yardimi ile belirtilen kelimeyi aratip sonucu buluyoruz.
            //Adresten istek yapıp, html kodlarını indiriyor.
            Uri url1 = new Uri("http://www.ilacprospektusu.com/ara/ilac/etken-madde/" + txtEtkenMaddeArama.Text);
            WebClient client1 = new WebClient();
            client1.Encoding = System.Text.Encoding.UTF8;

            // Adresten istek yapı html kodlarını indiriyorum.   
            try
            {html1 = client1.DownloadString(url1); }
            catch (WebException) // hatali url geldiginde calisir
            {
                if (MessageBox.Show("Hatali Url", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                { }
            }

            // İndirdiğim html kodlarını bir HtmlDocment nesnesine yüklüyorum.   
            HtmlAgilityPack.HtmlDocument dokuman1 = new HtmlAgilityPack.HtmlDocument();
            dokuman1.LoadHtml(html1);

            // Html dökümanı içndeki li etiketlerinden class'ı  urun olanları liste halinde alıyorum 
            HtmlNodeCollection basliklar1 = dokuman1.DocumentNode.SelectNodes("//li[@class='urun']");

            // basliklar1 koleksiyonunu tek tek gezerek, her bir elemanının içindeki text'i alıyorum 
            try
            {
                foreach (var baslik in basliklar1)
                {
                    lstbIlacListele.Items.Add(baslik.InnerText); //Burada etken maddeye göre bulduğu ilaçları listbox'a ekliyor.
                }
            }
            catch (NullReferenceException) //yaratılmamış bir nesneye  değer atama veya değer okuma hatasi geri donerse
            {
                if (MessageBox.Show("Aramanızla eşleşen ilac sonuçlari bulunamadı.", "Ilac Bulunamadi Uyarisi", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtEtkenMaddeArama.Text = "";
                    lblUyari.Text = "!!!!!!!";
                }
            }
        }



        // VeriAnaliz methodumuz sistemde aratilan etken madde adalarina gore toplam kac adet arama yapilmis onu gosterir.
        public void veriAnaliz()
        {
            int sayac = 0;  // sonradan db'den okuyacagmiz SAYAC degerini bir artirmak icin olusturdum
            //gerekli db baglantilarimi ve sql komutumu yazdim
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-INRNTK1\SQL2014;Initial Catalog=bitirme;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter(" Select Count(*) from VeriAnalizi where ETKEN_MADDE_ADI='" + txtEtkenMaddeArama.Text + "'", con);
            SqlConnection baglanti = new SqlConnection(conString);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                string verideger = "";
                sayac += 1;

                baglanti.Open();
                /// burada db den sayac degerimizi cektik
                string sayacVeri = "Select SAYAC from VeriAnalizi where ETKEN_MADDE_ADI='" + txtEtkenMaddeArama.Text + "'";
                SqlCommand komut = new SqlCommand(sayacVeri, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read()) //Sadece tek bir kayıt döndürüleceği için while kullanmadım.
                {
                    //Datareader ile okunan verileri form kontrollerine aktardık.
                    verideger = dr["SAYAC"].ToString();
                }

                int veriDeger = Convert.ToInt32(verideger);
                sayac = sayac + veriDeger;
                baglanti.Close();

                baglanti.Open();
                // burada db ye yeni sayac degerini guncelledik
                string kayit = "UPDATE VeriAnalizi SET SAYAC=@SAYAC WHERE ETKEN_MADDE_ADI='" + txtEtkenMaddeArama.Text + "';";
                SqlCommand komut2 = new SqlCommand(kayit, baglanti);
                komut2.Parameters.AddWithValue("@SAYAC", sayac);
                komut2.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();

            }
            else
            {
                sayac = 1;
                // db baglanti ve komut calistirma kodlari
                SqlConnection coni = new SqlConnection(@"Data Source=DESKTOP-INRNTK1\SQL2014;Initial Catalog=bitirme;Integrated Security=True;");
                string strng = "INSERT into VeriAnalizi (ETKEN_MADDE_ADI,SAYAC) VALUES('" + txtEtkenMaddeArama.Text + "','" + sayac + "');";
                coni.Open();
                SqlCommand cmd = new SqlCommand(strng, coni);
                cmd.ExecuteNonQuery();
                coni.Close();

            }

        }

        private void btnEtkenMaddeAra_Click(object sender, EventArgs e)
        {
              pgbSayac();
          //  backgroundWorker1.RunWorkerAsync();
            gebelikIlacKategoriDurum();

            ilacListele();
            veriAnaliz();
        }

        public void pgbSayac()
        {    /// progresbar thread yardimi ile listeleme anindaki gecikme ile beraber dolum yapmasi icin ayarlandi.
            for (int i = 0; i < 101; i++)
            {
                lblSurec.Text = "%"+i.ToString();
                pgbIlacListele.Value = i;
                Thread.Sleep(40);
                

            }
        }
        private void txtEtkenMaddeArama_MouseClick(object sender, MouseEventArgs e)
        { // bu kod blogunda txtbox icindeki cumlenin yok olmasi ve yeni yazilacak kelimelerin font renk degisikligi
          
            txtEtkenMaddeArama.Text = "";
            txtEtkenMaddeArama.ForeColor = Color.Black;
            lstbIlacListele.Items.Clear();
            listBox1.Items.Clear();
            pgbIlacListele.Value = 0;
            lblUyari.Text = "!!!!!";
        }

        private void txtEtkenMaddeArama_ModifiedChanged(object sender, EventArgs e)
        {

            // bu kod blogunda txtbox icindeki cumlenin yok olmasi ve yeni yazilacak kelimelerin font renk degisikligi
            txtEtkenMaddeArama.Text = "";
            txtEtkenMaddeArama.ForeColor = Color.Black;
        }
        
        private void enÇokArananEtkenMaddeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secenek = false;

            Araclar araclar = new Araclar();
            araclar.Show();
        }

        private void enAzArananEtkenMaddeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secenek = true;

            Araclar araclar = new Araclar();
            araclar.Show();

        }

        private void tamçıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menudeki cikis butonu arama motoru ekranini kapatir
            this.Close();                            // bulundugu ekrani kapattim
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Menudeki cikis butonu arama motoru ekranini kapatip giris ekranina dondurur. 
            this.Close();                            // bulundugu ekrani kapattim
            KullaniciKayitGiris f1 = new KullaniciKayitGiris();                  // from1 yani giris ekranindan nesne aldim 
            f1.Show();                               // Aldigim nesneye cagirip gosterdim
        }

       
        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yardim yardım = new Yardim();
            yardım.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblsaat.Text= DateTime.Now.ToLongTimeString();
            lbltarih.Text = DateTime.Now.ToLongDateString();
        }
    }
}


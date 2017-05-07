using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitirme_bilgen
{
    public partial class Araclar : Form
    {
        public Araclar()
        {
            InitializeComponent();
        }

        private void Araclar_Load(object sender, EventArgs e)
        {
            // Main formumuzdan araclar butonundan secilen veri analiz turune gore analiz sonuclarini gosterir.
            if (AramaMotoru.secenek)
            {
                lblAraclar.Text = "En Az Aranan Etken Maddeler"; // En Az Aranan Etken Maddeler Adi
                // veritabani baglantisi 
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-INRNTK1\SQL2014;Initial Catalog=bitirme;Integrated Security=True;");
                conn.Open();
                // Veri tabanina, en az aranan etken madde ve aranma miktarini(sayac) iceren sql kodu ile yeni bir formda datagridview icerinde gosteriyoruz.
                SqlCommand komut = new SqlCommand(" Select top 5 ETKEN_MADDE_ADI as EtkenMadde, SAYAC as Sayaç From [bitirme].[dbo].[VeriAnalizi] Order By SAYAC ASC; ", conn);
                DataTable tablo = new DataTable(); // verileri tutacagimiz tabloyu olusturduk
                SqlDataReader veriyukle = komut.ExecuteReader(); // sql kodumuzu calistirdik.  Okumak uzere sqldatareader a yazdik.
                tablo.Load(veriyukle);                           // okudugumuz verileri tablomuza yazdik
                dgvAraclar.DataSource = tablo;                   // bu tabloyu da datagridview(dgvAraclar) a atadik.
                conn.Close();                                    // veritabani kapandi
            }
            else
            {
                lblAraclar.Text = "En Çok Aranan Etken Maddeler"; //En Cok Aranan Etken Maddeler Adi
                // veritabani baglantisi
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-INRNTK1\SQL2014;Initial Catalog=bitirme;Integrated Security=True;");
                conn.Open();
                // Veri tabanina, en cok aranan etken madde ve aranma miktarini(sayac) iceren sql kodu ile yeni bir formda datagridview icerinde gosteriyoruz.
                SqlCommand komut = new SqlCommand(" Select top 5 ETKEN_MADDE_ADI as EtkenMadde, SAYAC as Sayaç From [bitirme].[dbo].[VeriAnalizi] Order By SAYAC DESC; ", conn);
                DataTable tablo = new DataTable();              // verileri tutacagimiz tabloyu olusturduk
                SqlDataReader veriyukle = komut.ExecuteReader();// sql kodumuzu calistirdik.  Okumak uzere sqldatareader a yazdik.
                tablo.Load(veriyukle);                           // okudugumuz verileri tablomuza yazdik
                dgvAraclar.DataSource = tablo;                   // bu tabloyu da datagridview(dgvAraclar) a atadik.
                conn.Close();                                    // veritabani kapandi

            }

        }

    }
}

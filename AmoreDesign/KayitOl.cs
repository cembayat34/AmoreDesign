using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AmoreDesign
{
    public partial class KayitOl : Form
    {

        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlCommand komut2;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        bool varMi;

        public KayitOl()
        {
            InitializeComponent();
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Kayit();
        }


        private void Kayit()
        {
            string email = txtEmail.Text;
            string kullaniciAdi = txtKullaniciAdi.Text;

            baglanti = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=amoredesign");

            
            string sorgu = "INSERT INTO kullanicilar (ad, soyad, kullanici_adi, email, tel, cinsiyet, sifre) VALUES (@ad, @soyad, @kullanici_adi, @email, @tel, @cinsiyet, @sifre)";
            string sorgu2 = "SELECT * FROM kullanicilar";
            
            komut = new MySqlCommand(sorgu, baglanti);
            komut2 = new MySqlCommand(sorgu2, baglanti);

            baglanti.Open();
            dr = komut2.ExecuteReader();

            while (dr.Read())
            {
                if (email == dr["email"].ToString() || kullaniciAdi == dr["kullanici_adi"].ToString())
                {
                    varMi = true;
                    break;
                } else
                {
                    varMi = false;
                }
            }

            baglanti.Close();

            if (!varMi)
            {
                MessageBox.Show("Kayit talebiniz olusturuldu.");
            } else
            {
                MessageBox.Show("Boyle bir email ya da kullanici adi sisteme kayitli");
                return;
            }

            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@kullanici_adi", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@tel", txtTel.Text);
            komut.Parameters.AddWithValue("@cinsiyet", txtCinsiyet.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

       
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Close();
        }
    }
}

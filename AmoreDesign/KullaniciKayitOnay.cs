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
    public partial class KullaniciKayitOnay : Form
    {

        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        

        public KullaniciKayitOnay()
        {
            InitializeComponent();
        }

        private void KullaniciKayitOnay_Load(object sender, EventArgs e)
        {

            onayBekleyenKullanicilariGetir();
        }

        private void onayBekleyenKullanicilariGetir()
        {
            baglanti = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=amoredesign");
            baglanti.Open();
            string sorgu = "SELECT * FROM kullanicilar WHERE kayit_durum = 0";

            da = new MySqlDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }



        private void btnTumunuOnayla_Click(object sender, EventArgs e)
        {
            onayBekleyenVarMi();

            if (varMi)
            {
                tumunuOnayla();
                onayBekleyenKullanicilariGetir();
            } else
            {
                MessageBox.Show("Onay bekleyen kullanici bulunmamakta");
            }

        }

        bool varMi;

        private void onayBekleyenVarMi()
        {
            baglanti = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=amoredesign");
            baglanti.Open();

            string sorgu = "SELECT * FROM kullanicilar WHERE kayit_durum=0";
            komut = new MySqlCommand(sorgu, baglanti);
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                varMi = true;
            } else
            {
                varMi = false;
            }

            baglanti.Close();
        }

        private void tumunuOnayla()
        {
            baglanti = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=amoredesign");
            
            string sorgu = "UPDATE kullanicilar SET kayit_durum=1 WHERE kayit_durum=0";
            komut = new MySqlCommand(sorgu, baglanti);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Onay bekleyen kullanicilar sisteme eklendi");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            main frm = new main();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void secileniOnayla()
        {
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["sec"].Value))
                {
                    Console.WriteLine("secili");
                    Console.WriteLine(dataGridView1.Rows[i].Cells[1].Value);

                    baglanti = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=amoredesign");

                    string sorgu = "UPDATE kullanicilar SET kayit_durum=1 WHERE id =" + dataGridView1.Rows[i].Cells[1].Value;
                    komut = new MySqlCommand(sorgu, baglanti);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                } else
                {
                    Console.WriteLine("secili degil");
                }
            }
            onayBekleyenKullanicilariGetir();
        }

        private void btnSecilenleriOnayla_Click(object sender, EventArgs e)
        {
            secileniOnayla();
        }
    }
}

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
    public partial class Form1 : Form
    {

        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlCommand komut2;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlDataReader dr2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            baglanti = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=amoredesign");
            MySqlDataReader dr;
            try
            {
                baglanti.Open();
                string sorgu = "SELECT email,sifre FROM kullanicilar WHERE email=@email AND sifre=@sifre AND kayit_durum = 1";
                string sorgu2 = "SELECT kayit_durum FROM kullanicilar WHERE email=@email AND sifre=@sifre";
                komut = new MySqlCommand(sorgu, baglanti);
                komut2 = new MySqlCommand(sorgu2, baglanti);

                komut.Parameters.AddWithValue("@email", txtEmail.Text);
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
                komut2.Parameters.AddWithValue("@sifre", txtSifre.Text);
                komut2.Parameters.AddWithValue("@email", txtEmail.Text);

                
                dr = komut2.ExecuteReader();

                while (dr.Read())
                {
                    if (0 == Convert.ToInt32(dr["kayit_durum"]))
                    {
                        MessageBox.Show("Onay sureci devam ediyor...");
                        return;
                        
                    }
                    else
                    {
                        
                    }
                    
                }
                baglanti.Close();

                baglanti.Open();
                dr2 = komut.ExecuteReader();

                if (dr2.HasRows)
                {
                    while (dr2.Read())
                    {
                       
                        main_form();
                    }
                }
                else
                {
                    MessageBox.Show("Bilgiler yanlis");
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine("login failed");
            }
            baglanti.Close();
        }


        private void main_form()
        {
            this.Hide();
            main frm = new main();
            frm.ShowDialog();
            this.Close();
        }

        private void KayitOl_form()
        {
            this.Hide();
            KayitOl frm = new KayitOl();
            frm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitOl_form();
        }
    }
}

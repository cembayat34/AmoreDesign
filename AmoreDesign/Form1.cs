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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            runQuery();
        }

        private void runQuery()
        {
            string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=amoredesign";
            var con = new MySqlConnection(cs);
            MySqlDataReader reader;
            try
            {
                con.Open();
                string stm = "SELECT email,sifre FROM kullanicilar WHERE email=@email AND sifre=@sifre";
                var cmd = new MySqlCommand(stm, con);

                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Bilgiler Dogru Giris Yapiliyor...");
                        main_form();
                    }
                } else
                {
                    MessageBox.Show("Bilgiler yanlis");
                }

                
            }
            catch (Exception ex)
            {

                Console.WriteLine("login failed");
            }
            con.Close();
        }

        private void main_form()
        {
            this.Hide();
            main frm = new main();
            frm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

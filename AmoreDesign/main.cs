using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmoreDesign
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnKayitOnayla_Click(object sender, EventArgs e)
        {
            this.Hide();
            KullaniciKayitOnay frm = new KullaniciKayitOnay();
            frm.ShowDialog();
            this.Close();
        }
    }
}

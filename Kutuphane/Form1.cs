using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class frmQuiz : Form
    {
        public frmQuiz()
        {
            InitializeComponent();
        }

        private Kutuphane kutuphane = new Kutuphane();
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            KitapOzellik kitapOzellik = new KitapOzellik();

            kitap.kitapOzellik = kitapOzellik;
            kitap.kitapOzellik.ISBN = Convert.ToInt32(txtISBN.Text);
            kitap.kitapOzellik.KitapAdi = txtKitapAdi.Text;
            kitap.kitapOzellik.Yazar = txtYazar.Text;
            kitap.AlisTarih = Convert.ToDateTime(txtAlis.Text);
            kitap.IadeTarihi = Convert.ToDateTime(txtAlis.Text);

            kutuphane.KitapEkle(kitap);
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            kutuphane.KitapSil();
            txtListele.Clear();
        }
        
        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            txtListele.Text = (kutuphane.KitapListele()).ToString();
        }
    }
}
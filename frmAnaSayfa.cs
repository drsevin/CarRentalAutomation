using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalAutomation
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; " +
            "Database=AracKiralamaUygulamasi; user ID=postgres; password=Mshsys02129");
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele = new frmMusteriListele();
            listele.ShowDialog();
            
        }

        private void btnMusteriEkleme_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
        }

        private void btnAracKayit_Click(object sender, EventArgs e)
        {
            frmAracEkle kayit = new frmAracEkle();
            kayit.ShowDialog();
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            frmAracListele aracListele = new frmAracListele();
            aracListele.ShowDialog();
        }

        private void btnKiralama_Click(object sender, EventArgs e)
        {
            frmKiralamaIslemi kiralama = new frmKiralamaIslemi();
            kiralama.ShowDialog();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            frmSatislar satislar = new frmSatislar();
            satislar.ShowDialog();
        }
    }
}

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
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; " +
            "Database=AracKiralamaUygulamasi; user ID=postgres; password=Mshsys02129");
        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from city",
                baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbSehir.DisplayMember = "name";
            cmbSehir.ValueMember = "citycode";
            cmbSehir.DataSource = dt;
            baglanti.Close();

        }
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into customers (phonenumber,birthday,citycode," +
                "tcidentity,firstname,lastname,email) values (@p5,@p6,@p7,@p1,@p2,@p3,@p4) ", baglanti);
            komut1.Parameters.AddWithValue("@p5", txtTel.Text);
            komut1.Parameters.AddWithValue("@p6", dateTimePicker1.Value.Date);
            komut1.Parameters.AddWithValue("@p7", int.Parse(cmbSehir.SelectedValue.ToString()));
            komut1.Parameters.AddWithValue("@p1", txtTC.Text);
            komut1.Parameters.AddWithValue("@p2", txtAd.Text);
            komut1.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut1.Parameters.AddWithValue("@p4", txtEmail.Text);
          
            komut1.ExecuteNonQuery();
            txtTel.Text = "";
            dateTimePicker1.Text = DateTime.Today.ToString();
            cmbSehir.Text = "";
            txtTC.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtEmail.Text = "";

            baglanti.Close();
            MessageBox.Show("Müşteri başarıyla eklendi");
            
            


        }

        private void btnMusteriIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmKiralamaIslemi : Form
    {
        public frmKiralamaIslemi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; " +
           "Database=AracKiralamaUygulamasi; user ID=postgres; password=Mshsys02129");

        

        private void frmKiralamaIslemi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da18 = new NpgsqlDataAdapter("select * from cars",
                baglanti);
            DataTable dt18 = new DataTable();
            da18.Fill(dt18);

            cmbAracId.ValueMember = "id";
            cmbAracId.DataSource = dt18;


            NpgsqlDataAdapter da23 = new NpgsqlDataAdapter("select * from city",
               baglanti);
            DataTable dt23 = new DataTable();
            da23.Fill(dt23);
            cmbSehir.DisplayMember = "name";
            cmbSehir.ValueMember = "citycode";
            cmbSehir.DataSource = dt23;


            baglanti.Close();
        }

        private void btnSozlesmeIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        

        private void cmbAracId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c1 = int.Parse(cmbAracId.SelectedValue.ToString());

            NpgsqlDataAdapter da19 = new NpgsqlDataAdapter("select * from cars where \"id\" = " + c1 + "",
               baglanti);
            DataTable dt19 = new DataTable();
            da19.Fill(dt19);

            
            cmbRenk.ValueMember = "colorid";
            cmbRenk.DataSource = dt19;

            
            cmbMarka.ValueMember = "brandid";
            cmbMarka.DataSource = dt19;

            
            cmbModel.ValueMember = "modelid";
            cmbModel.DataSource = dt19;

            
            cmbVites.ValueMember = "gearid";
            cmbVites.DataSource = dt19;

            
            cmbStokAdedi.ValueMember = "unitsinstock";
            cmbStokAdedi.DataSource = dt19;

            cmbYakit.ValueMember = "fuelid";
            cmbYakit.DataSource = dt19;

            
            cmbAracSinifi.ValueMember = "vehicleid";
            cmbAracSinifi.DataSource = dt19;

            
            cmbFiyatAralik.ValueMember = "rangeid";
            cmbFiyatAralik.DataSource = dt19;

           
            cmbKmLimit.ValueMember = "limitid";
            cmbKmLimit.DataSource = dt19;

            
            cmbMusteriId.ValueMember = "customerid";
            cmbMusteriId.DataSource = dt19;

            
            cmbGunlukFiyat.ValueMember = "dailyprice";
            cmbGunlukFiyat.DataSource = dt19;

            int c2 = int.Parse(cmbMusteriId.SelectedValue.ToString());

            NpgsqlDataAdapter da20 = new NpgsqlDataAdapter("select * from customers where \"customerid\" = " + c2 + "",
               baglanti);
            DataTable dt20 = new DataTable();
            da20.Fill(dt20);

            cmbSehir.ValueMember = "citycode";
            cmbSehir.DataSource = dt20;

            cmbTC.DisplayMember = "tcidentity";
            cmbTC.DataSource = dt20;

            cmbAd.DisplayMember = "firstname";
            cmbAd.DataSource = dt20;

            cmbSoyad.DisplayMember = "lastname";
            cmbSoyad.DataSource = dt20; 

            cmbEmail.DisplayMember = "email";
            cmbEmail.DataSource = dt20;

            cmbTelefon.DisplayMember = "phonenumber";
            cmbTelefon.DataSource = dt20;

            cmbDogumGunu.DisplayMember = "birthday";
            cmbDogumGunu.DataSource = dt20;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut7 = new NpgsqlCommand("insert into date (\"rentDate\",\"returnDate\") values (@p1,@p2) ", baglanti);
           
            komut7.Parameters.AddWithValue("@p1", dateTimePicker2.Value.Date);
            komut7.Parameters.AddWithValue("@p2", dateTimePicker3.Value.Date);

            komut7.ExecuteNonQuery();
            
            baglanti.Close();
            MessageBox.Show("Tarihler başarıyla eklendi");

            

            NpgsqlDataAdapter da25 = new NpgsqlDataAdapter("select * from date ",
               baglanti);
            DataTable dt25 = new DataTable();
            da25.Fill(dt25);

            cmbDateId.DisplayMember = "id";
            cmbDateId.DataSource = dt25;


        }

        private void btnSozlesme_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut8 = new NpgsqlCommand("insert into payments (dateid,creditcardnumber,expirationdate," +
                "securitycode,price,postcode,customerid,adress,city,ownername,cardid) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11) ", baglanti);

            komut8.Parameters.AddWithValue("@p1", int.Parse(cmbDateId.Text));
            komut8.Parameters.AddWithValue("@p2", txtKrediKart.Text);
            komut8.Parameters.AddWithValue("@p3", txtSonKullanma.Text);
            komut8.Parameters.AddWithValue("@p4", txtGuvenlikKodu.Text);
            komut8.Parameters.AddWithValue("@p5", int.Parse(txtToplamTutar.Text));
            komut8.Parameters.AddWithValue("@p6", int.Parse(txtPostaKodu.Text));
            komut8.Parameters.AddWithValue("@p7", int.Parse(txtMusteriId.Text));
            komut8.Parameters.AddWithValue("@p8", txtAdres.Text);
            komut8.Parameters.AddWithValue("@p9", cmbSehir2.Text);
            komut8.Parameters.AddWithValue("@p10", txtKartSahibi.Text);
            komut8.Parameters.AddWithValue("@p11", int.Parse(cmbCardId.Text));


            komut8.ExecuteNonQuery();
            cmbDateId.Text = "";
            txtKrediKart.Text = "";
            txtSonKullanma.Text = "";
            txtGuvenlikKodu.Text = "";
            txtToplamTutar.Text = "";
            txtPostaKodu.Text = "";
            txtMusteriId.Text = "";
            txtAdres.Text = "";
            cmbSehir2.Text = "";
            txtKartSahibi.Text = "";
            cmbCardId.Text = "";

            NpgsqlCommand komut12 = new NpgsqlCommand("insert into rentals (\"rentDate\",\"returnDate\",\"carId\",\"customerId\") values (@p1,@p2,@p3,@p4) ", baglanti);

            komut12.Parameters.AddWithValue("@p1", dateTimePicker2.Value.Date);
            komut12.Parameters.AddWithValue("@p2", dateTimePicker3.Value.Date);
            komut12.Parameters.AddWithValue("@p3", int.Parse(cmbAracId.Text));
            komut12.Parameters.AddWithValue("@p4", int.Parse(cmbMusteriId.Text));
            
          

            komut12.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Ödeme işlemi başarıyla gerçekleşti ve satış işlemi tamamlandı");
            

            //DialogResult dr = new DialogResult();
            //dr = MessageBox.Show("Ödeme işlemi başarıyla gerçekleşti. Kart Bilgilerini Kaydetmek İster Misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr == DialogResult.Yes)
            //{

            //}
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlDataAdapter da21 = new NpgsqlDataAdapter("select * from city where citycode  = " + cmbSehir.SelectedValue + "",
                baglanti);
            DataTable dt21 = new DataTable();
            da21.Fill(dt21);
            cmbSehir2.DisplayMember = "name";
            cmbSehir2.ValueMember = "citycode";
            cmbSehir2.DataSource = dt21;
        }

       

        private void btnTutarHesapla_Click(object sender, EventArgs e)
        {


            DateTime bTarih = Convert.ToDateTime(dateTimePicker2.Text);
            DateTime kTarih = Convert.ToDateTime(dateTimePicker3.Text);
            TimeSpan Sonuc = kTarih - bTarih;
            int gunFark = int.Parse(Sonuc.TotalDays.ToString());
            int tutar = gunFark * int.Parse(cmbGunlukFiyat.Text);
            txtToplamTutar.Text = tutar.ToString();


        }

        private void btnCardEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut9 = new NpgsqlCommand("insert into cards (creditcardnumber,expirationdate," +
                "securitycode,customerid,ownername) values (@p1,@p2,@p3,@p4,@p5) ", baglanti);


            komut9.Parameters.AddWithValue("@p1", txtKrediKart.Text);
            komut9.Parameters.AddWithValue("@p2", txtSonKullanma.Text);
            komut9.Parameters.AddWithValue("@p3", txtGuvenlikKodu.Text);
            komut9.Parameters.AddWithValue("@p4", int.Parse(txtMusteriId.Text));
            komut9.Parameters.AddWithValue("@p5", txtKartSahibi.Text);


            komut9.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kart başarıyla eklendi");

            int c3 = int.Parse(cmbMusteriId.SelectedValue.ToString());

            NpgsqlDataAdapter da21 = new NpgsqlDataAdapter("select * from cards where \"customerid\" = " + c3 + "",
               baglanti);
            DataTable dt21 = new DataTable();
            da21.Fill(dt21);

            cmbCardId.DisplayMember = "cardid";
            cmbCardId.DataSource = dt21;
        }

        private void btnSozlesmeListele_Click(object sender, EventArgs e)
        {
            string sorgu5 = "select * from payments";
            NpgsqlDataAdapter da22 = new NpgsqlDataAdapter(sorgu5, baglanti);
            DataSet ds22 = new DataSet();
            da22.Fill(ds22);
            dataGridView1.DataSource = ds22.Tables[0];
        }

        private void btnSozlesmeSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataGridViewRow satir3 = dataGridView1.CurrentRow;
            NpgsqlCommand komut4 = new NpgsqlCommand("Delete From payments where paymentid='" + satir3.Cells["paymentid"].Value.ToString() + "'", baglanti);

            komut4.ExecuteNonQuery();
            cmbDateId.Text = "";
            txtKrediKart.Text = "";
            txtSonKullanma.Text = "";
            txtGuvenlikKodu.Text = "";
            txtToplamTutar.Text = "";
            txtPostaKodu.Text = "";
            txtMusteriId.Text = "";
            txtAdres.Text = "";
            cmbSehir2.Text = "";
            txtKartSahibi.Text = "";
            cmbCardId.Text = "";

            
            


            baglanti.Close();
            MessageBox.Show("Sözleşme süresi dolmuştur ", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir3 = dataGridView1.CurrentRow;
            cmbDateId.Text = satir3.Cells[9].Value.ToString();
            txtKartSahibi.Text = satir3.Cells[11].Value.ToString();
            txtSonKullanma.Text = satir3.Cells[3].Value.ToString();
            txtGuvenlikKodu.Text = satir3.Cells[4].Value.ToString();
            txtToplamTutar.Text = satir3.Cells[5].Value.ToString();
            txtPostaKodu.Text = satir3.Cells[6].Value.ToString();
            txtKrediKart.Text = satir3.Cells[2].Value.ToString();
            txtMusteriId.Text = satir3.Cells[8].Value.ToString();
            txtAdres.Text = satir3.Cells[7].Value.ToString();
            cmbSehir2.Text = satir3.Cells[1].Value.ToString();
            cmbCardId.Text = satir3.Cells[10].Value.ToString();


        }
    }
}

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
    public partial class frmAracEkle : Form
    {
        public frmAracEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; " +
           "Database=AracKiralamaUygulamasi; user ID=postgres; password=Mshsys02129");
        private void frmAracEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("select * from colors",
                baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cmbRenk.DisplayMember = "colorName";
            cmbRenk.ValueMember = "colorId";
            cmbRenk.DataSource = dt1;

            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from brands",
                baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbMarka.DisplayMember = "brandname";
            cmbMarka.ValueMember = "brandid";
            cmbMarka.DataSource = dt2;

           

            NpgsqlDataAdapter da4 = new NpgsqlDataAdapter("select * from geartype",
                baglanti);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            cmbVites.DisplayMember = "gearName";
            cmbVites.ValueMember = "gearId";
            cmbVites.DataSource = dt4;

            NpgsqlDataAdapter da5 = new NpgsqlDataAdapter("select * from fueltype",
                baglanti);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            cmbYakit.DisplayMember = "fuelName";
            cmbYakit.ValueMember = "fuelId";
            cmbYakit.DataSource = dt5;

            NpgsqlDataAdapter da6 = new NpgsqlDataAdapter("select * from vehicleclass",
                baglanti);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);
            cmbAracSinifi.DisplayMember = "vehicleName";
            cmbAracSinifi.ValueMember = "vehicleId";
            cmbAracSinifi.DataSource = dt6;

            NpgsqlDataAdapter da7 = new NpgsqlDataAdapter("select * from pricerange",
                baglanti);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            cmbFiyatAralik.DisplayMember = "range";
            cmbFiyatAralik.ValueMember = "rangeId";
            cmbFiyatAralik.DataSource = dt7;

            NpgsqlDataAdapter da8 = new NpgsqlDataAdapter("select * from kilometerlimit",
                baglanti);
            DataTable dt8 = new DataTable();
            da8.Fill(dt8);
            cmbKmLimit.DisplayMember = "kmLimit";
            cmbKmLimit.ValueMember = "limitId";
            cmbKmLimit.DataSource = dt8;

            NpgsqlDataAdapter da9 = new NpgsqlDataAdapter("select * from customers",
                baglanti);
            DataTable dt9 = new DataTable();
            da9.Fill(dt9);
            
            cmbMusteriId.ValueMember = "customerid";
            cmbMusteriId.DataSource = dt9;

            baglanti.Close();
        }

        private void btnArabaKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut4 = new NpgsqlCommand("insert into cars (colorid,brandid,modelid," +
                "gearid,fuelid,vehicleid,rangeid,limitid,customerid,dailyprice,unitsinstock) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11) ", baglanti);

            komut4.Parameters.AddWithValue("@p1", int.Parse(cmbRenk.SelectedValue.ToString()));
            komut4.Parameters.AddWithValue("@p2", int.Parse(cmbMarka.SelectedValue.ToString()));
            komut4.Parameters.AddWithValue("@p3", int.Parse(cmbModel.SelectedValue.ToString()));
            komut4.Parameters.AddWithValue("@p4", int.Parse(cmbVites.SelectedValue.ToString()));
            komut4.Parameters.AddWithValue("@p5", int.Parse(cmbYakit.SelectedValue.ToString()));
            komut4.Parameters.AddWithValue("@p6", int.Parse(cmbAracSinifi.SelectedValue.ToString()));
            komut4.Parameters.AddWithValue("@p7", int.Parse(cmbFiyatAralik.SelectedValue.ToString()));
            komut4.Parameters.AddWithValue("@p8", int.Parse(cmbKmLimit.SelectedValue.ToString()));
            komut4.Parameters.AddWithValue("@p9", int.Parse(cmbMusteriId.SelectedValue.ToString()));
            komut4.Parameters.AddWithValue("@p10", int.Parse(txtGunlukFiyat.Text));
            komut4.Parameters.AddWithValue("@p11", int.Parse(nmrcStokAdedi.Value.ToString()));
           
            komut4.ExecuteNonQuery();
            cmbRenk.Text = "";
            cmbMarka.Text = "";
            cmbModel.Text = "";
            cmbVites.Text = "";
            cmbYakit.Text = "";
            cmbAracSinifi.Text = "";
            cmbFiyatAralik.Text = "";
            cmbKmLimit.Text = "";
            cmbMusteriId.Text = "";
            txtGunlukFiyat.Text = "";
            nmrcStokAdedi.Text = "";
            baglanti.Close();
            MessageBox.Show("Araç başarıyla eklendi");
            

        }

        private void btnArabaIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = int.Parse(cmbMarka.SelectedValue.ToString());

            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter("select * from models where \"brandid\" = "+a+"",
               baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            cmbModel.DisplayMember = "modelname";
            cmbModel.ValueMember = "modelid";

            cmbModel.DataSource = dt3;

        }
    }
}

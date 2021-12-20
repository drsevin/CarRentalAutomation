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
    public partial class frmAracListele : Form
    {
        public frmAracListele()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; " +
           "Database=AracKiralamaUygulamasi; user ID=postgres; password=Mshsys02129");
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;

            txtAracId.Text = satir.Cells[0].Value.ToString();
           
            cmbRenk.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbMarka.SelectedValue = satir.Cells[3].Value.ToString();
            cmbModel.SelectedValue = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbVites.SelectedValue = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbYakit.SelectedValue = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cmbAracSinifi.SelectedValue = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cmbFiyatAralik.SelectedValue = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cmbKmLimit.SelectedValue = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cmbMusteriId.Text = satir.Cells[1].Value.ToString();
            txtGunlukFiyat.Text = satir.Cells[11].Value.ToString();
            nmrcStokAdedi.Text = satir.Cells[10].Value.ToString();

           
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from cars";
            NpgsqlDataAdapter db = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet dz = new DataSet();
            db.Fill(dz);
            dataGridView1.DataSource = dz.Tables[0];
        }

        private void btnAracIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut5 = new NpgsqlCommand("update cars set brandid=@brandid ,colorid=@colorid ," +
                "modelid=@modelid , customerid=@customerid , dailyprice=@dailyprice , fuelid=@fuelid , gearid=@gearid , " +
                "limitid=@limitid , rangeid=@rangeid , unitsinstock=@unitsinstock , vehicleid=@vehicleid   where id=@id", baglanti);
            komut5.Parameters.AddWithValue("@brandid", int.Parse((cmbMarka.SelectedIndex + 1).ToString()));
            komut5.Parameters.AddWithValue("@colorid", int.Parse(cmbRenk.SelectedValue.ToString()));
            komut5.Parameters.AddWithValue("@modelid", int.Parse(cmbModel.SelectedValue.ToString()));
            komut5.Parameters.AddWithValue("@customerid", int.Parse(cmbMusteriId.Text));
            komut5.Parameters.AddWithValue("@dailyprice", int.Parse(txtGunlukFiyat.Text));
            komut5.Parameters.AddWithValue("@fuelid", int.Parse(cmbYakit.SelectedValue.ToString()));
            komut5.Parameters.AddWithValue("@gearid", int.Parse(cmbVites.SelectedValue.ToString()));
            komut5.Parameters.AddWithValue("@limitid", int.Parse(cmbKmLimit.SelectedValue.ToString()));
            komut5.Parameters.AddWithValue("@rangeid", int.Parse(cmbFiyatAralik.SelectedValue.ToString()));
            komut5.Parameters.AddWithValue("@unitsinstock", int.Parse(nmrcStokAdedi.Value.ToString()));
            komut5.Parameters.AddWithValue("@vehicleid", int.Parse(cmbAracSinifi.SelectedValue.ToString()));
            komut5.Parameters.AddWithValue("@id", int.Parse(txtAracId.Text));

            komut5.ExecuteNonQuery();
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
            MessageBox.Show("Araç güncelleme işlemi başarılı", cmbMarka.SelectedValue.ToString(),
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }

        private void frmAracListele_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            
            
            NpgsqlDataAdapter da10 = new NpgsqlDataAdapter("select * from brands ",
                baglanti);
            DataTable dt10 = new DataTable();
            da10.Fill(dt10);
            cmbMarka.DisplayMember = "brandname";
            cmbMarka.ValueMember = "barndid";
            cmbMarka.DataSource = dt10;

            NpgsqlDataAdapter da11 = new NpgsqlDataAdapter("select * from colors",
                baglanti);
            DataTable dt11 = new DataTable();
            da11.Fill(dt11);
            cmbRenk.DisplayMember = "colorname";
            cmbRenk.ValueMember = "colorid";
            cmbRenk.DataSource = dt11;

            NpgsqlDataAdapter da12 = new NpgsqlDataAdapter("select * from models",
                baglanti);
            DataTable dt12 = new DataTable();
            da12.Fill(dt12);
            cmbModel.DisplayMember = "modelname";
            cmbModel.ValueMember = "modelid";
            cmbModel.DataSource = dt12;

            NpgsqlDataAdapter da13 = new NpgsqlDataAdapter("select * from fueltype",
                baglanti);
            DataTable dt13 = new DataTable();
            da13.Fill(dt13);
            cmbYakit.DisplayMember = "fuelname";
            cmbYakit.ValueMember = "fuelid";
            cmbYakit.DataSource = dt13;

            NpgsqlDataAdapter da14 = new NpgsqlDataAdapter("select * from geartype",
                baglanti);
            DataTable dt14 = new DataTable();
            da14.Fill(dt14);
            cmbVites.DisplayMember = "gearname";
            cmbVites.ValueMember = "gearid";
            cmbVites.DataSource = dt14;

            NpgsqlDataAdapter da15 = new NpgsqlDataAdapter("select * from kilometerlimit",
                baglanti);
            DataTable dt15 = new DataTable();
            da15.Fill(dt15);
            cmbKmLimit.DisplayMember = "kmlimit";
            cmbKmLimit.ValueMember = "limitid";
            cmbKmLimit.DataSource = dt15;

            NpgsqlDataAdapter da16 = new NpgsqlDataAdapter("select * from pricerange",
                baglanti);
            DataTable dt16 = new DataTable();
            da16.Fill(dt16);
            cmbFiyatAralik.DisplayMember = "range";
            cmbFiyatAralik.ValueMember = "rangeid";
            cmbFiyatAralik.DataSource = dt16;

            NpgsqlDataAdapter da17 = new NpgsqlDataAdapter("select * from vehicleclass",
                baglanti);
            DataTable dt17 = new DataTable();
            da17.Fill(dt17);
            cmbAracSinifi.DisplayMember = "vehiclename";
            cmbAracSinifi.ValueMember = "vehicleid";
            cmbAracSinifi.DataSource = dt17;

            baglanti.Close();

        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataGridViewRow satir = dataGridView1.CurrentRow;
            NpgsqlCommand komut3 = new NpgsqlCommand("Delete From cars where id='" + satir.Cells["id"].Value.ToString() + "'", baglanti);

            komut3.ExecuteNonQuery();
            txtAracId.Text = "";
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
            MessageBox.Show("Araç silme işlemi başarılı", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            baglanti.Close();
        }



        

        private void cmbMarka_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if (cmbMarka.SelectedIndex > -1)
            {
              int c3 = int.Parse((cmbMarka.SelectedIndex+1).ToString());

                NpgsqlDataAdapter da32 = new NpgsqlDataAdapter("select * from models where \"brandid\" = " + c3 + "",
              baglanti);
                DataTable dt32 = new DataTable();
                da32.Fill(dt32);
                cmbModel.DisplayMember = "modelname";
                cmbModel.ValueMember = "modelid";
                cmbModel.DataSource = dt32;
            }
            
           
        }
    }
}

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
    public partial class frmMusteriListele : Form
    {
        public frmMusteriListele()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; " +
            "Database=AracKiralamaUygulamasi; user ID=postgres; password=Mshsys02129");
        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from customers";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtMusteriAra_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from customers where tcidentity like '%"+txtMusteriAra.Text+"%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnMusteriIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMusteriListele_Load(object sender, EventArgs e)
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
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtTC.Text = satir.Cells[7].Value.ToString();
            txtAd.Text = satir.Cells[1].Value.ToString();
            txtSoyad.Text = satir.Cells[2].Value.ToString();
            txtEmail.Text = satir.Cells[3].Value.ToString();
            txtTel.Text = satir.Cells[6].Value.ToString();
            dateTimePicker1.Text = satir.Cells[4].Value.ToString();

            cmbSehir.SelectedValue = dataGridView1.CurrentRow.Cells[5].Value.ToString();

             
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut2 = new NpgsqlCommand("update customers set firstname=@firstname ,lastname=@lastname ," +
                "email=@email , phonenumber=@phonenumber , birthday=@birthday , citycode=@citycode where tcidentity=@tcidentity", baglanti);
            komut2.Parameters.AddWithValue("@phonenumber", txtTel.Text);
            komut2.Parameters.AddWithValue("@birthday", dateTimePicker1.Value.Date);
            komut2.Parameters.AddWithValue("@citycode", int.Parse(cmbSehir.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@tcidentity", txtTC.Text);
            komut2.Parameters.AddWithValue("@firstname", txtAd.Text);
            komut2.Parameters.AddWithValue("@lastname", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@email", txtEmail.Text);
            
            komut2.ExecuteNonQuery();
            txtTel.Text = "";
            dateTimePicker1.Text = "";
            cmbSehir.Text = "";
            txtTC.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtEmail.Text = "";

            baglanti.Close();
            MessageBox.Show("Müşteri güncelleme işlemi başarılı", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
            
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataGridViewRow satir = dataGridView1.CurrentRow;
            NpgsqlCommand komut3 = new NpgsqlCommand("Delete From customers where tcidentity='"+satir.Cells["tcidentity"].Value.ToString()+"'" ,baglanti);
           
            komut3.ExecuteNonQuery();
            txtTel.Text = "";
            dateTimePicker1.Text = DateTime.Today.ToString();
            cmbSehir.Text = "";
            txtTC.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtEmail.Text = "";


            baglanti.Close();
            MessageBox.Show("Müşteri silme işlemi başarılı","Bilgi",
                MessageBoxButtons.OK,MessageBoxIcon.Stop);
           
            

        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            
            
            
                //DataGridViewRow satir2 = dataGridView1.CurrentRow;



        }

        private void cmbSehir_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            
        }
    }
}

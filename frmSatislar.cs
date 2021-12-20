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
    public partial class frmSatislar : Form
    {
        public frmSatislar()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; " +
           "Database=AracKiralamaUygulamasi; user ID=postgres; password=Mshsys02129");
        private void btnSatisListele_Click(object sender, EventArgs e)
        {
            string sorgu6 = "select * from rentals";
            NpgsqlDataAdapter da27 = new NpgsqlDataAdapter(sorgu6, baglanti);
            DataSet ds27 = new DataSet();
            da27.Fill(ds27);
            dataGridView1.DataSource = ds27.Tables[0];
        }
    }
}

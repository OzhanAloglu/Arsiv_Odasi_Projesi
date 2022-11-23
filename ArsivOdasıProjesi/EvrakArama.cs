using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ArsivOdasıProjesi
{
    public partial class EvrakArama : Form
    {
        public EvrakArama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALOGLU\\SQLEXPRESS;Initial Catalog=ArsivOdası;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;

        private void ARA_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Select * from Evrak where E_Ad like '%" + txt_evrakarama.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource=ds.Tables[0];

            baglanti.Close();

            
        }

        public void evrakgöster()
        {
            baglanti.Open();
            komut = new SqlCommand("select * from Evrak", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            evrakgöster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenüSayfası frm = new MenüSayfası();
            frm.ShowDialog();
        }
    }
}

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
    public partial class KlasörEkle : Form
    {
        public KlasörEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ALOGLU\\SQLEXPRESS;Initial Catalog=ArsivOdası;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;

        void klasörgöster()
        {
            baglanti.Open();
            komut = new SqlCommand("select * from Klasör", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void btn_menğüdön_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenüSayfası frm = new MenüSayfası();
            frm.ShowDialog();
        }

        private void KlasörEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("select O_ID from ODA ", baglanti);

            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                cmb_klasörodaekle.Items.Add(dr[0]);
            }
            baglanti.Close();
        }

        private void cmb_klasörodaekle_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_klasörblmekle.Items.Clear();
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select B_ID from RAF where O_ID=@O_ID", baglanti);
            komut3.Parameters.AddWithValue("@O_ID", cmb_klasörodaekle.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
                
            while (dr3.Read())
            {
                cmb_klasörblmekle.Items.Add(dr3[0].ToString());
            }
            baglanti.Close();
        }

        private void cmb_klasörblmekle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cmb_bölmrafekle.Items.Clear();
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select R_ID from RAF where O_ID=@O_ID and B_ID=@B_ID", baglanti);
            komut4.Parameters.AddWithValue("@O_ID", cmb_klasörodaekle.Text);
            komut4.Parameters.AddWithValue("@B_ID", cmb_klasörblmekle.Text);
            SqlDataReader dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
                cmb_bölmrafekle.Items.Add(dr4[0].ToString());
            }
            baglanti.Close();



        }

        private void btn_kydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("insert into Klasör (O_ID,B_ID,R_ID,K_Ad)values(@p1,@p2,@p3,@p4)", baglanti);

            komut.Parameters.AddWithValue("p1", cmb_klasörodaekle.Text);
            komut.Parameters.AddWithValue("p2", cmb_klasörblmekle.Text);
            komut.Parameters.AddWithValue("p3", cmb_bölmrafekle.Text);
            komut.Parameters.AddWithValue("p4", txt_Klasörgirin.Text);

            dr = komut.ExecuteReader();

            baglanti.Close();
            klasörgöster();
        }

        private void btn_verigöster_Click(object sender, EventArgs e)
        {
            klasörgöster();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("delete from Klasör where K_Ad=@K_Ad",baglanti);
            komut.Parameters.AddWithValue("@K_Ad",txt_klasörsil.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            klasörgöster();
        }
    }
}

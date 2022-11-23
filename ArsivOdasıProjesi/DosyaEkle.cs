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
    public partial class DosyaEkle : Form
    {
        public DosyaEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ALOGLU\\SQLEXPRESS;Initial Catalog=ArsivOdası;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand komut;

        void dosyagöster()
        {
            
            baglanti.Open();
            komut = new SqlCommand("select * from Dosya", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void DosyaEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("select O_ID from ODA", baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_dosyaodaseç.Items.Add(dr[0]);
            }
            baglanti.Close();

        }

        private void cmb_dosyaodaseç_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_dosyabölmseç.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select B_ID from Klasör where O_ID=@O_ID", baglanti);
            komut2.Parameters.AddWithValue("@O_ID", cmb_dosyaodaseç.Text);
            dr = komut2.ExecuteReader();

            while (dr.Read())
            {
                cmb_dosyabölmseç.Items.Add(dr[0]);
            }
            baglanti.Close();


        }

        private void cmb_dosyabölmseç_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_dosyarafseç.Items.Clear();
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select R_ID from Klasör where O_ID=@O_ID and B_ID=@B_ID",baglanti);
            komut3.Parameters.AddWithValue("@O_ID",cmb_dosyaodaseç.Text);
            komut3.Parameters.AddWithValue("@B_ID",cmb_dosyabölmseç.Text);
            dr=komut3.ExecuteReader();

            while (dr.Read())
            {
                cmb_dosyarafseç.Items.Add(dr[0]);
            }
            baglanti.Close();
        }

        private void cmb_dosyarafseç_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_dosyaklasörseç.Items.Clear();
            
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select K_ID from Klasör where O_ID=@O_ID and B_ID=@B_ID and R_ID=@R_ID",baglanti);
            komut4.Parameters.AddWithValue("@O_ID",cmb_dosyaodaseç.Text);
            komut4.Parameters.AddWithValue("@B_ID",cmb_dosyabölmseç.Text);
            komut4.Parameters.AddWithValue("@R_ID",cmb_dosyarafseç.Text);
            dr =komut4.ExecuteReader();

            while (dr.Read())
            {
                cmb_dosyaklasörseç.Items.Add(dr[0]);
            }
            baglanti.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("insert into Dosya (O_ID,B_ID,R_ID,K_ID,D_Ad)values(@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut5.Parameters.AddWithValue("@p1",cmb_dosyaodaseç.Text);
            komut5.Parameters.AddWithValue("@p2",cmb_dosyabölmseç.Text);
            komut5.Parameters.AddWithValue("@p3",cmb_dosyarafseç.Text);
            komut5.Parameters.AddWithValue("@p4",cmb_dosyaklasörseç.Text);
            komut5.Parameters.AddWithValue("@p5",txt_dosyagir.Text);

            dr=komut5.ExecuteReader();
            baglanti.Close();
            dosyagöster();
        }

        private void btn_mverigöster_Click(object sender, EventArgs e)
        {
            dosyagöster();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("delete from Dosya  where D_Ad=@p1", baglanti);
            komut.Parameters.AddWithValue("p1", txt_dosyagir.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dosyagöster();

        }

        private void btn_menüdön_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenüSayfası frm12 = new MenüSayfası();
            frm12.ShowDialog();

        }

        private void btn_sıfırla_Click(object sender, EventArgs e)
        {
            cmb_dosyabölmseç.Text = "";
            cmb_dosyaodaseç.Text = "";
            cmb_dosyarafseç.Text = "";
            cmb_dosyaklasörseç.Text = "";
            txt_dosyagir.Clear();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {

        }









































        //private void DosyaEkle_Load(object sender, EventArgs e)
        //{
        //    baglanti.Open();
        //    komut = new SqlCommand("select O_ID from ODA ", baglanti);

        //    dr = komut.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        cmb_btndosyaodaseç.Items.Add(dr[0]);
        //    }
        //    baglanti.Close();
        //}

        //private void cmb_btndosyaodaseç_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cmb_dosyabölmseç.Items.Clear();
        //    baglanti.Open();
        //    SqlCommand komut3 = new SqlCommand("select R_ID from Klasör where O_ID=@O_ID", baglanti);
        //    komut3.Parameters.AddWithValue("@O_ID", cmb_btndosyaodaseç.Text);
        //    SqlDataReader dr3 = komut3.ExecuteReader();

        //    while (dr3.Read())
        //    {
        //        cmb_dosyabölmseç.Items.Add(dr3[0].ToString());
        //    }
        //    baglanti.Close();
        //}

        //private void cmb_dosyabölmseç_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cmb_dosyabölmseç.Items.Clear();
        //    baglanti.Open();
        //    SqlCommand komut4 = new SqlCommand("select D_ID from Dosya where O_ID=@O_ID and B_ID=@B_ID and R_ID=@R_ID", baglanti);
        //    komut4.Parameters.AddWithValue("@O_ID", cmb_btndosyaodaseç.Text);
        //    komut4.Parameters.AddWithValue("@B_ID", cmb_dosyabölmseç.Text);
        //    komut4.Parameters.AddWithValue("@R_ID", cmb_dosyarafseç.Text);
        //    SqlDataReader dr4 = komut4.ExecuteReader();

        //    while (dr4.Read())
        //    {
        //        cmb_dosyabölmseç.Items.Add(dr4[0].ToString());
        //    }
        //    baglanti.Close();
        //}



    }
}

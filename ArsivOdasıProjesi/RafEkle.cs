using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ArsivOdasıProjesi
{
    public partial class RafEkle : Form
    {
        public RafEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ALOGLU\\SQLEXPRESS;Initial Catalog=ArsivOdası;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;

        void rafgöster()
        {
            baglanti.Open();
            komut = new SqlCommand("select * from RAF",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource=dt;
            baglanti.Close();

        }

        private void btn_verigöstr_Click(object sender, EventArgs e)
        {
            rafgöster();

        }

        private void btn_menüdönn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenüSayfası frm10 = new MenüSayfası();
            frm10.ShowDialog();
        }

        private void RafEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("select O_ID from ODA ",baglanti);
           
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                cmb_odaseçinz.Items.Add(dr[0]);
            }
            baglanti.Close();
        }

        private void btn_bölmseçnz_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmb_odaseçinz_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_bölmseçnz.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select B_ID from Bölüm where O_ID=@O_ID", baglanti);
            komut2.Parameters.AddWithValue("@O_ID", cmb_odaseçinz.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                cmb_bölmseçnz.Items.Add(dr2[0].ToString()) ;
            }
            baglanti.Close();
        }

        private void btn_rafekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("insert into Raf (O_ID,B_ID,R_Ad)values(@p1,@p2,@p3)",baglanti);

            komut.Parameters.AddWithValue("p1",cmb_odaseçinz.Text);
            komut.Parameters.AddWithValue("p2",cmb_bölmseçnz.Text);
            komut.Parameters.AddWithValue("p3",txt_rafgirin.Text);

            dr = komut.ExecuteReader();

            baglanti.Close();
            rafgöster();
        }

        private void btn_rafsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("delete from Raf  where R_Ad=@p1",baglanti);
            komut.Parameters.AddWithValue("p1",txt_rafgirin.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            rafgöster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb_odaseçinz.Text = "";
            cmb_bölmseçnz.Text = "";
        }
    }
}

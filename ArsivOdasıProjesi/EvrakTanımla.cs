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
    public partial class EvrakTanımla : Form
    {
        public EvrakTanımla()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ALOGLU\\SQLEXPRESS;Initial Catalog=ArsivOdası;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand komut;

        void evrakgöster()
        {
            baglanti.Open();
            komut = new SqlCommand("select * from Evrak", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }


        private void EvrakTanımla_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("select O_ID from ODA", baglanti);
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                cmb_EvrakOdaKayıt.Items.Add(dr[0]);
            }
            baglanti.Close();

        }

        private void cmb_EvrakOdaKayıt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_EvrakBölümKayıt.Items.Clear();
            baglanti.Open();
            komut = new SqlCommand("select B_ID from Dosya where O_ID=@O_ID", baglanti);
            komut.Parameters.AddWithValue("@O_ID", cmb_EvrakOdaKayıt.Text);
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                cmb_EvrakBölümKayıt.Items.Add(dr[0]);
            }
            baglanti.Close();
        }

        [Obsolete]
        private void cmb_EvrakBölümKayıt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_EvrakRafKayıt.Items.Clear();
            baglanti.Open();
            komut = new SqlCommand("select R_ID from Dosya where O_ID=@O_ID and B_ID=@B_ID", baglanti);
            komut.Parameters.Add("@O_ID", cmb_EvrakOdaKayıt.Text);
            komut.Parameters.Add("@B_ID", cmb_EvrakBölümKayıt.Text);
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                cmb_EvrakRafKayıt.Items.Add(dr[0]);
            }
            baglanti.Close();
        }

        [Obsolete]
        private void cmb_EvrakRafKayıt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_EvrakKlasörKayıt.Items.Clear();
            baglanti.Open();
            komut = new SqlCommand("select K_ID from Dosya where O_ID=@O_ID and B_ID=@B_ID and R_ID=@R_ID", baglanti);
            komut.Parameters.Add("@O_ID", cmb_EvrakOdaKayıt.Text);
            komut.Parameters.Add("@B_ID", cmb_EvrakBölümKayıt.Text);
            komut.Parameters.Add("@R_ID", cmb_EvrakRafKayıt.Text);

            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                cmb_EvrakKlasörKayıt.Items.Add(dr[0]);
            }
            baglanti.Close();


        }

        [Obsolete]
        private void cmb_EvrakKlasörKayıt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_EvrakDosyaKayıt.Items.Clear();
            baglanti.Open();
            komut = new SqlCommand("select D_ID from Dosya where O_ID=@O_ID and B_ID=@B_ID and R_ID=@R_ID and K_ID=@K_ID", baglanti);
            komut.Parameters.Add("@O_ID", cmb_EvrakOdaKayıt.Text);
            komut.Parameters.Add("@B_ID", cmb_EvrakBölümKayıt.Text);
            komut.Parameters.Add("@R_ID", cmb_EvrakRafKayıt.Text);
            komut.Parameters.Add("@K_ID", cmb_EvrakKlasörKayıt.Text);

            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_EvrakDosyaKayıt.Items.Add(dr[0]);
            }
            baglanti.Close();

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("insert into Evrak (O_ID,B_ID,R_ID,K_ID,D_ID,E_Ad)values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut5.Parameters.AddWithValue("@p1", cmb_EvrakOdaKayıt.Text);
            komut5.Parameters.AddWithValue("@p2", cmb_EvrakBölümKayıt.Text);
            komut5.Parameters.AddWithValue("@p3", cmb_EvrakRafKayıt.Text);
            komut5.Parameters.AddWithValue("@p4", cmb_EvrakKlasörKayıt.Text);
            komut5.Parameters.AddWithValue("@p5", cmb_EvrakDosyaKayıt.Text);
            komut5.Parameters.AddWithValue("@p6", txt_EvrakAdıGir.Text);

            dr = komut5.ExecuteReader();
            baglanti.Close();
            evrakgöster();

        }

        [Obsolete]
        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("delete from Evrak where E_Ad=@p1",baglanti);
            komut.Parameters.Add("@p1",txt_EvrakAdıGir.Text);
            komut .ExecuteNonQuery();

            baglanti.Close();
            evrakgöster();
        }

        private void btn_sıfırla_Click(object sender, EventArgs e)
        {
            cmb_EvrakBölümKayıt.Text = "";
            cmb_EvrakDosyaKayıt.Text = "";
            cmb_EvrakKlasörKayıt.Text = "";
            cmb_EvrakOdaKayıt.Text = "";
            cmb_EvrakRafKayıt.Text = "";
        }

        private void btn_menüdön_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenüSayfası frm = new MenüSayfası();
            frm.ShowDialog();
        }

        private void btn_mverigöster_Click(object sender, EventArgs e)
        {
            evrakgöster();
        }
    }
}

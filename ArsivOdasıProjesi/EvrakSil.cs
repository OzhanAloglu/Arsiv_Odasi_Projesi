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
    public partial class EvrakSil : Form
    {
        public EvrakSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALOGLU\\SQLEXPRESS;Initial Catalog=ArsivOdası;Integrated Security=True");
        SqlCommand komut;

         void verigöster()
        {
            baglanti.Open();
            komut = new SqlCommand("select * from Evrak", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }



        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut=new SqlCommand("delete from Evrak where E_Ad=@E_Ad",baglanti);

            komut.Parameters.AddWithValue("@E_Ad", txt_evraksil.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verigöster();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            verigöster();
        }

        private void btn_menüdön_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenüSayfası frm = new MenüSayfası();
            frm.ShowDialog();
        }
    }
}

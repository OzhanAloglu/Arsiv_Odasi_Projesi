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
    public partial class ODAEKLE : Form
    {
        public ODAEKLE()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ALOGLU\\SQLEXPRESS;Initial Catalog=ArsivOdası;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;

        void verilerigöster()
        {
            baglanti.Open();
            komut = new SqlCommand("select * from ODA", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void ODAEKLE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("insert into ODA (O_Ad) values (@O_Ad)", baglanti);
            komut.Parameters.AddWithValue("@O_Ad", txt_odakyıt.Text);
            dr = komut.ExecuteReader();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("delete from ODA where O_Ad=@O_Ad", baglanti);
            komut.Parameters.AddWithValue("@O_Ad", txt_odakyıt.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn_menüdön_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenüSayfası frm7=new MenüSayfası();
            frm7.ShowDialog();
        }

        private void btn_odagüncelle_Click(object sender, EventArgs e)
        {
            
        }
    }
}

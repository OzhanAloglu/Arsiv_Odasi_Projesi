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
    public partial class BölümTanımla : Form
    {
        public BölümTanımla()
        {
            InitializeComponent();
        }

        SqlConnection baglanti=new SqlConnection("Data Source=ALOGLU\\SQLEXPRESS;Initial Catalog=ArsivOdası;Integrated Security=True");
 
        SqlCommand komut;
        SqlDataReader dr;
       void verileriigöster()
        {
            baglanti.Open();
            komut = new SqlCommand("select * from Bölüm", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void BölümTanımla_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("select O_ID from ODA",baglanti);
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenüSayfası frm5 = new MenüSayfası();
            frm5.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Bölmkydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("insert into Bölüm (B_Ad,O_ID)values(@B_Ad,@O_ID)",baglanti);
            komut.Parameters.AddWithValue("@B_Ad", textBox1.Text.ToString());
            komut.Parameters.AddWithValue("@O_ID", comboBox1.Text);

            dr = komut.ExecuteReader();
            baglanti.Close();
            verileriigöster();
        }

        private void btn_bölmsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("delete from Bölüm where B_Ad=@B_Ad",baglanti);
            komut.Parameters.AddWithValue("@B_Ad",textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriigöster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            verileriigöster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
        }
    }
}

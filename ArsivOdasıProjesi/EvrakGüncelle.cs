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
    public partial class EvrakGüncelle : Form
    {
        public EvrakGüncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ALOGLU\\SQLEXPRESS;Initial Catalog=ArsivOdası;Integrated Security=True");
        SqlCommand komut = new SqlCommand();

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string E_ID = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            string E_Ad = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            string D_ID = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            string K_ID = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            string R_ID = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            string B_ID = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();
            string O_ID = dataGridView1.Rows[seçilialan].Cells[6].Value.ToString();

            txt_E_ID.Text=E_ID;
            txt_E_Ad.Text=E_Ad;
            txt_D_ID.Text = D_ID;
            txt_K_ID.Text = K_ID;
            txt_R_ID.Text = R_ID;
            txt_B_ID.Text = B_ID;
            txt_O_ID.Text = O_ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            evrakgöster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("update Evrak set  D_ID='" + txt_D_ID.Text.ToString() + "',K_ID='" + txt_K_ID.Text.ToString() + "',R_ID='" + txt_R_ID.Text.ToString() + "',B_ID='" + txt_B_ID.Text.ToString() + "',O_ID='" + txt_O_ID.Text.ToString()+ "'where E_Ad='"+txt_E_Ad.Text+"'" ,baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            evrakgöster();
            

        }

        private void btn_Evrakara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Select * from Evrak where E_Ad like '%" + txt_evrakarama.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void btn_menüdön_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenüSayfası frm = new MenüSayfası();
            frm.ShowDialog();
        }
    }
}

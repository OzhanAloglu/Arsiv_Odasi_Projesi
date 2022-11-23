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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ALOGLU\\SQLEXPRESS;Initial Catalog=ArsivOdası;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;

        

        private void btn_giriş_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            komut = new SqlCommand("select * from Kayıtlar where ID=@ID and Password=@Password", baglanti);

            komut.Parameters.AddWithValue("@ID", txt_ID.Text);
            komut.Parameters.AddWithValue("@Password", txt_şifre.Text);
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                this.Hide();
                MenüSayfası frm2 = new MenüSayfası();
                frm2.ShowDialog();

            }

            else
            {
                MessageBox.Show("Hatalı giriş.");
            }
            baglanti.Close();

        }

        private void btn_kayıtol_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayıtOl frm3 = new KayıtOl();
            frm3.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_şifre.UseSystemPasswordChar = true;
            if (checkBox1.CheckState==CheckState.Checked)
            {
                txt_şifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Şifreyi Gizle";
            }
            else
            {
                txt_şifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Şifreyi Göster";
            }
        }
    }
}

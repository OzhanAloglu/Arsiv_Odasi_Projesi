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
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ALOGLU\\SQLEXPRESS;Initial Catalog=ArsivOdası;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;

        private void btn_Kydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("insert into Kayıtlar (ID,Password)values(@p2,@p3)", baglanti);
                komut.Parameters.AddWithValue("@p2", txt_ıdkyıt.Text);


                if (txt_sifrekyt.Text == txt_sfretkrar.Text)
                {
                    komut.Parameters.AddWithValue("@p3", txt_sifrekyt.Text);
                }

                dr = komut.ExecuteReader();
                dr.Read();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı.");
            }
            catch (Exception)
            {

                MessageBox.Show("Şifreler uyuşmuyor.");
            }

            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();


        }

        private void BTN_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenüSayfası frm9=new MenüSayfası();
            frm9.ShowDialog();
        }
    }
}

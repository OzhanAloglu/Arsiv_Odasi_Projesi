using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArsivOdasıProjesi
{
    public partial class MenüSayfası : Form
    {
        public MenüSayfası()
        {
            InitializeComponent();
        }

        private void kullanıcıTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayıtOl frm4 = new KayıtOl();
            frm4.ShowDialog();

        }

        private void odaTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ODAEKLE frm = new ODAEKLE();
            frm.ShowDialog();
        }

        private void bölümTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BölümTanımla frm2 = new BölümTanımla();
            frm2.ShowDialog();
        }

        private void rafTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {this.Hide();
            RafEkle frm9 = new RafEkle();
            frm9.ShowDialog();
        }

        private void klasörTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KlasörEkle frm10 = new KlasörEkle();
            frm10.ShowDialog();
        }

        private void dosyaTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DosyaEkle frm2 = new DosyaEkle();
            frm2.ShowDialog();
        }

        private void evrakTanımlaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EvrakTanımla frm = new EvrakTanımla();
            frm.ShowDialog();
        }

        private void evrakAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EvrakArama frm = new EvrakArama();
            frm.ShowDialog();
        }

        private void evrakGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EvrakGüncelle frm = new EvrakGüncelle();
            frm.ShowDialog();
        }

        private void evrakSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EvrakSil frm = new EvrakSil();
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
            DialogResult result2=MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?","Çıkış",MessageBoxButtons.YesNoCancel);

            if (result2==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Hide();
                MenüSayfası frm = new MenüSayfası();
                frm.ShowDialog();
            }
            
        }
    }
}

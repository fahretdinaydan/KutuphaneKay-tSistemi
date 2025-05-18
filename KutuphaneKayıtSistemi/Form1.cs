using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneKayıtSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kitapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ogrenciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 abs = new Form5();
            abs.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("Çıkmak istediğinize eminmisiniz?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
                    }

        private void yeniKitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 abs = new Form2();
            abs.Show();
        }

        private void kitaplarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 abs = new Form4();
            abs.Show();

        }

        private void sayıKitaplarıToolStripMenuItem_Click(object sender, EventArgs e)
        {






        }

        private void ogrencileriGoruntuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 abs = new Form6();
            abs.Show();
        }

        private void oduncAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 abs = new Form7();
            abs.Show();
        }

        private void iadeEtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form8 form8 = new Form8();         // constructor da long olmalı
            form8.Show();
            this.Hide();
        }
    }
}

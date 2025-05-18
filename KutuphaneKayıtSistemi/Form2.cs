using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneKayıtSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-0SI016LJ\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True"))
                {
                    conn.Open();


                    // SQL INSERT sorgusu
                    string sorgu = "INSERT INTO newbook (kitap_adi, yazar, yayinevi, yayin_tarihi, fiyat) " +
                    "VALUES (@kitap_adi, @yazar, @yayinevi, @yayintarihi, @fiyat )";

                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.Parameters.AddWithValue("@kitap_adi", textBox1.Text);
                    komut.Parameters.AddWithValue("@yazar", textBox2.Text);
                    komut.Parameters.AddWithValue("@yayinevi", textBox3.Text);
                    komut.Parameters.AddWithValue("@yayintarihi", textBox5.Text);
                    komut.Parameters.AddWithValue("@fiyat", textBox4.Text);
                    



                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("ekleme işlemi başarıyla tamamlandı!", "Başarılı");
                        Form4 form4 = new Form4();
                        form4.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız. Hiçbir satır eklenmedi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

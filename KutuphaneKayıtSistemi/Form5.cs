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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-0SI016LJ\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True"))
                {
                    conn.Open();


                    // SQL INSERT sorgusu
                    string sorgu = "INSERT INTO ogrenciekle (ogrenciadi, ogrencikayitno) " +
                    "VALUES (@ogrenciadi, @ogrencikayitno )";

                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.Parameters.AddWithValue("@ogrenciadi", textBox1.Text);
                    komut.Parameters.AddWithValue("@ogrencikayitno", textBox2.Text);
               

                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("ekleme işlemi başarıyla tamamlandı!", "Başarılı");
                        Form6 form6 = new Form6();
                        form6.Show();
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

        private void Form5_Load(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
    }


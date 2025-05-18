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

namespace KutuphaneKayıtSistemi
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kutuphaneDataSet1.odunc' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oduncTableAdapter.Fill(this.kutuphaneDataSet1.odunc);
            // TODO: Bu kod satırı 'kutuphaneDataSet1.odunc' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oduncTableAdapter.Fill(this.kutuphaneDataSet1.odunc);
            // TODO: Bu kod satırı 'kutuphaneDataSet.ogrenciekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            
            

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-0SI016LJ\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True"))
                {
                    conn.Open();

                    // SQL INSERT sorgusu
                    string sorgu = "INSERT INTO odunc (ogrenci_adi, kitap_adi ) " +
                    "VALUES (@ogrenciadi, @kitapadi  )";

                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.Parameters.AddWithValue("@ogrenciadi", comboBox1.Text);
                    komut.Parameters.AddWithValue("@kitapadi", comboBox2.Text);



                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla tamamlandı!", "Başarılı");

                        Form7 form7 = new Form7();         // constructor da long olmalı
                        form7.Show();
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
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }
    }
        }

    




                
    

    


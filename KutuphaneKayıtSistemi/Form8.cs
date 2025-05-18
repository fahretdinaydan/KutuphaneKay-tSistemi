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
    public partial class Form8 : Form
    {
        private object komut;
        private object iadeTableAdapter1;
        private object kutuphaneDataSet3;

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)

        {
            // TODO: Bu kod satırı 'kutuphaneDataSet31.odunc' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oduncTableAdapter1.Fill(this.kutuphaneDataSet31.odunc);

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-0SI016LJ\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True"))
                {
                    conn.Open();

                    // Öğrencileri çek
                    SqlCommand cmdOgrenci = new SqlCommand("SELECT DISTINCT ogrenci_adi FROM odunc", conn);
                    SqlDataReader drOgrenci = cmdOgrenci.ExecuteReader();
                    comboBox1.Items.Clear();
                    while (drOgrenci.Read())
                    {
                        comboBox1.Items.Add(drOgrenci["ogrenci_adi"].ToString());
                    }
                    drOgrenci.Close();

                    // Kitapları çek
                    SqlCommand cmdKitap = new SqlCommand("SELECT DISTINCT kitap_adi FROM odunc", conn);
                    SqlDataReader drKitap = cmdKitap.ExecuteReader();
                    comboBox2.Items.Clear();
                    while (drKitap.Read())
                    {
                        comboBox2.Items.Add(drKitap["kitap_adi"].ToString());
                    }
                    drKitap.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yükleme hatası: " + ex.Message);
            }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {


         
            try
            {
                string secilenOgrenci = comboBox1.Text.Trim();
                string secilenKitap = comboBox2.Text.Trim();

                if (string.IsNullOrEmpty(secilenOgrenci) || string.IsNullOrEmpty(secilenKitap))
                {
                    MessageBox.Show("Lütfen öğrenci ve kitap adı seçiniz.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-0SI016LJ\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True"))
                {
                    conn.Open();

                    // 1. Ödünç tablosundan sil
                    string silSorgu = "DELETE FROM odunc WHERE ogrenci_adi = @ogrenciadi AND kitap_adi = @kitapadi";
                    using (SqlCommand silKomut = new SqlCommand(silSorgu, conn))
                    {
                        silKomut.Parameters.AddWithValue("@ogrenciadi", secilenOgrenci);
                        silKomut.Parameters.AddWithValue("@kitapadi", secilenKitap);

                        int sonuc = silKomut.ExecuteNonQuery();

                        if (sonuc > 0)
                        {
                            // 2. İade tablosuna ekle
                            string ekleSorgu = "INSERT INTO iade (ogrenci_adi, kitap_adi) VALUES (@ogrenciadi, @kitapadi)";
                            using (SqlCommand ekleKomut = new SqlCommand(ekleSorgu, conn))
                            {
                                ekleKomut.Parameters.AddWithValue("@ogrenciadi", secilenOgrenci);
                                ekleKomut.Parameters.AddWithValue("@kitapadi", secilenKitap);
                                ekleKomut.ExecuteNonQuery();
                            }


                        }
                        else
                        {
                            MessageBox.Show("Başarısız");
                        }
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




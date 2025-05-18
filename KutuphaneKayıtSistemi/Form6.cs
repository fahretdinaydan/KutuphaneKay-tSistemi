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
    public partial class Form6 : Form
    {
        private string ogrenciadi;


        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                try
                {
                    ogrenciadi = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                   
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=LAPTOP-0SI016LJ\\SQLEXPRESS; database= kutuphane; integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    // Daha güvenli parametreli sorgu kullanımı (önerilen)
                    cmd.CommandText = "select * from ogrenciekle";
                   

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds);
                    
                    dataGridView1.DataSource = ds.Tables[0];
                }



                catch (Exception ex)

                {

                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
            }
        }
        
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kutuphaneDataSet.ogrenciekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciekleTableAdapter.Fill(this.kutuphaneDataSet.ogrenciekle);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-0SI016LJ\\SQLEXPRESS; Initial Catalog=kutuphane; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from ogrenciekle";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
    }


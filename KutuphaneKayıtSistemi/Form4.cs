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
using System.Security.Cryptography;

namespace KutuphaneKayıtSistemi
{
    public partial class Form4 : Form
    {
        private object con;
        private int kitap_adi;

        public Form4()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-0SI016LJ\\SQLEXPRESS; Initial Catalog=kutuphane; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from newbook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                try
                {
                    kitap_adi = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());


                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=LAPTOP-0SI016LJ\\SQLEXPRESS; database= newbook; integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    // Daha güvenli parametreli sorgu kullanımı (önerilen)
                    cmd.CommandText = "select * from newbook where kitap_adi = @kitap_adi";
                    cmd.Parameters.AddWithValue("@kitap_adi", kitap_adi);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    con.Open();
                    da.Fill(ds);
                    con.Close();
                }



                catch (Exception ex)

                {

                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
                }
            }    
        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}

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

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public string myName,channelName;
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-7AMPI4V\SQLEXPRESS02;Initial Catalog=Farmville;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            
            

            Con.Open();
            string query = "SELECT * FROM tblHayvanDurum";
            SqlDataAdapter SDA = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            Con.Close();

            Con.Open();
            string query2 = "SELECT * FROM tblisDetaylari";
            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, Con);
            DataTable dt2 = new DataTable();
            SDA2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            Con.Close();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

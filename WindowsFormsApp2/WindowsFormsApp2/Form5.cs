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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-7AMPI4V\SQLEXPRESS02;Initial Catalog=Farmville;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Con.Open();
            string query3 = "SELECT * FROM tblHayvanDurum";
            SqlDataAdapter SDA2 = new SqlDataAdapter(query3, Con);
            DataTable dt3 = new DataTable();
            SDA2.Fill(dt3);
            dataGridView1.DataSource = dt3;
            Con.Close();
        }
    }
}

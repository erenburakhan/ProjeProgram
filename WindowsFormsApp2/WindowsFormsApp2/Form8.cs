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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-7AMPI4V\SQLEXPRESS02;Initial Catalog=Farmville;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 objFrmMain = new Form2();
            this.Hide();
            objFrmMain.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * FROM tblPersonelListe";
            SqlDataAdapter SDA = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            Con.Close();
        }
    }
}

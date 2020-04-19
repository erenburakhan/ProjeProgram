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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-7AMPI4V\SQLEXPRESS02;Initial Catalog=Farmville;Integrated Security=True";
        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@"Kullanıcı Adı"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"Kullanıcı Adı";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            con.Open();
            com.Connection = con;
            com.CommandText = "Select * from Auth";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (txtUsername.Text.Equals(dr["KullaniciAdi"].ToString()) && txtPassword.Text.Equals(dr["Sifre"].ToString()))
                {
                    this.Hide();
                    Form2 ss = new Form2();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }

        private void txtUser2Enter(object sender, EventArgs e)
        {
            if (txtUsername2.Text.Equals(@"Kullanıcı Adı"))
            {
                txtUsername2.Text = "";
            }
        }

        private void txtUser2Leave(object sender, EventArgs e)
        {
            if (txtUsername2.Text.Equals(""))
            {
                txtUsername2.Text = @"Kullanıcı Adı";
            }
        }

        private void txtPass2Enter(object sender, EventArgs e)
        {
            if (txtPassword2.Text.Equals("Password"))
            {
                txtPassword2.Text = "";
            }
        }

        private void txtPass2Leave(object sender, EventArgs e)
        {
            if (txtPassword2.Text.Equals(""))
            {
                txtPassword2.Text = "Password";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Select * from UyeAuth Where UyeId= '" + txtUsername2.Text.Trim() + "' and UyePass = '" + txtPassword2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Form3 objFrmMain = new Form3();
                this.Hide();
                objFrmMain.Show();


            }
            else
            {
                MessageBox.Show("KullanıcıAdı veya Şifre Yanlış");

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 ss = new Form4();
            ss.Show();
        }
    }
}

   


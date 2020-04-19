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
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
          

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 objFrmMain = new Form5();
            this.Hide();
            objFrmMain.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 ss = new Form6();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 objFrmMain = new Form7();
            this.Hide();
            objFrmMain.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 objFrmMain = new Form8();
            this.Hide();
            objFrmMain.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 objFrmMain = new Form9();
            this.Hide();
            objFrmMain.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form10 objFrmMain = new Form10();
            this.Hide();
            objFrmMain.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using(Form3 f3 = new Form3())    
            {
                
                
                
                
            }

           
        }
    }
}

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
using System.Diagnostics;


namespace Army_Database_2._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


        }



        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\LENOVO\source\repos\Army Database 2.0\Army Database 2.0\ammunitionDatabase.mdf; Integrated Security = True; Connect Timeout = 30");
            conn.Open();
            
            SqlCommand cmd = new SqlCommand("Select Username, Password from login1 where Username = '" + textBox2.Text + "' and Password = '" + textBox1.Text + "' ",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
           

            if (dt.Rows.Count <= 0)
            {

                panel2.Height = 50;
                label5.ForeColor = Color.Red;
                label5.Text = "Username or Password invalid";
                timer1.Start();

            }
            else
            {
                panel2.Height = 50;
                label5.ForeColor = Color.Green;
                label5.Text = "Login Successful";
                timer1.Start();
                MessageBox.Show("Login Successful");

                this.Hide();
                HomePage lg = new HomePage();
                lg.FormClosed += (s, args) => this.Close();
                lg.Show();
                lg.Focus();
            }








        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel2.Height != 50)
            {
                panel2.Height = panel2.Height - 3;
                if (panel2.Height == 50)
                {
                    timer1.Stop();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }
    }
}

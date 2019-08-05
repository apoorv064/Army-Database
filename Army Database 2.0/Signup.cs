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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\LENOVO\source\repos\Army Database 2.0\Army Database 2.0\ammunitionDatabase.mdf; Integrated Security = True; Connect Timeout = 30");
            conn.Open();

            String query = "INSERT INTO login1 (Username,Password) VALUES ('" + maskedTextBox1.Text + "','" + maskedTextBox3.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Signup Successful");
            this.Hide();




            redir1 lg = new redir1();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

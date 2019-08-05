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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        
           

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage lg = new HomePage();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label1.Visible = true;

         



        }

        
    }
}

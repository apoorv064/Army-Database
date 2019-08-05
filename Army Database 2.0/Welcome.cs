using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Army_Database_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup lg1 = new Signup();
            lg1.FormClosed += (s, args) => this.Close();
            lg1.Show();
            lg1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

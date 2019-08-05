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
    public partial class redir1 : Form
    {
        public redir1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }
    }
}

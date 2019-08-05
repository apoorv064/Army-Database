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
    public partial class UpdateSystem : Form
    {
        public UpdateSystem()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage lg = new HomePage();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

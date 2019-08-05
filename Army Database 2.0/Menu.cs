using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Army_Database_2._0
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

         private void pictureBox8_Click(object sender, EventArgs e)
            {
               Process.Start("https://www.militarytimes.com/");
            }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("https://economictimes.indiatimes.com/news/defence/indias-agni-long-range-missiles-broke-un-limits-chinese-media/articleshow/56349807.cms");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage lg = new HomePage();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
           
            WindowsFormsApplication1.Weapon lg = new WindowsFormsApplication1.Weapon();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
           
            WindowsFormsApplication1.Ammo lg = new WindowsFormsApplication1.Ammo();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Artillery lg = new WindowsFormsApplication1.Artillery();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Army_Database_2._0.AlphaCode lg = new Army_Database_2._0.AlphaCode();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }
    }
}

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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.DimGray;
            Dashboard lg = new Dashboard();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.ForeColor = Color.DimGray;
            this.Hide();
            Menu lg = new Menu();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSdrw7sq1wFBHnMBX40C-BHDsoWrw2kRR8xYcoZTqfFh9SfmEA/viewform");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.DimGray;
            this.Hide();
            Login lg = new Login();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu lg = new Menu();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.military.com/daily-news");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
            UpdateSystem lg = new UpdateSystem();
            lg.FormClosed += (s, args) => this.Close();
            lg.Show();
            lg.Focus();
        }
    }
}

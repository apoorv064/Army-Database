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
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Weapon : Form
    {
        

        public Weapon()
        {
            InitializeComponent();
        }
        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataSet sDs;
        DataTable sTable;
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\"MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ammunitionDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            string sql = "SELECT * FROM Arms";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            sCommand = new SqlCommand(sql, connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "Arms");
            sTable = sDs.Tables["Arms"];
            connection.Close();
            dataGridView1.DataSource = sDs.Tables["Arms"];
            dataGridView1.ReadOnly = true;
            save_btn.Enabled = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            save_btn.Enabled = true;
            new_btn.Enabled = false;
            delete_btn.Enabled = false;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        { 
             string connetionString =  "Data Source = (LocalDB)\"MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ammunitionDatabase.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection cnn;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = null;
                

                cnn = new SqlConnection(connetionString);
                sql = "INSERT INTO [dbo].[Arms] ([Weapon_name], [Weapon_type], [Batch_ID], [Origin], [Mag_size], [Ammo_c], [Fire_rate]) VALUES (textBox1.text,textBox2.text,textBox3.text,textBox4.text,textBox5.text,textBox6.text,textBox7.text)";

                try
                {
                    cnn.Open();
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Row inserted !! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                sAdapter.Update(sTable);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            sAdapter.Update(sTable);
            dataGridView1.ReadOnly = true;
            save_btn.Enabled = false;
            new_btn.Enabled = true;
            delete_btn.Enabled = true;
        }

        private void Weapon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ammunitionDatabaseDataSet2.Arms' table. You can move, or remove it, as needed.
            this.armsTableAdapter.Fill(this.ammunitionDatabaseDataSet2.Arms);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void insert_btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
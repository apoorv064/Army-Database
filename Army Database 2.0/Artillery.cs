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
    public partial class Artillery : Form
    {


        public Artillery()
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
            string sql = "SELECT * FROM Artillery";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            sCommand = new SqlCommand(sql, connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "Artillery");
            sTable = sDs.Tables["Artillery"];
            connection.Close();
            dataGridView1.DataSource = sDs.Tables["Artillery"];
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
            string connetionString = "Data Source = (LocalDB)\"MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ammunitionDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection cnn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = null;


            cnn = new SqlConnection(connetionString);
            sql = "INSERT INTO [dbo].[Artillery] ([Artillery_name], [Artillery_type], [Batch_id], [Country]) VALUES ('" +textBox1.Text+ "','" +textBox2.Text+ "','" +textBox3.Text+ "','" +textBox4.Text+ "')";

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
        private void Artillery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ammunitionDatabaseDataSet6.Artillery' table. You can move, or remove it, as needed.
            this.artilleryTableAdapter.Fill(this.ammunitionDatabaseDataSet6.Artillery);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void new_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}

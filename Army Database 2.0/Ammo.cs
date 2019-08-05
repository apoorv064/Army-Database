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
    public partial class Ammo : Form
    {


        public Ammo()
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
            string sql = "SELECT * FROM Ammo";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            sCommand = new SqlCommand(sql, connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "Ammo");
            sTable = sDs.Tables["Ammo"];
            connection.Close();
            dataGridView1.DataSource = sDs.Tables["Ammo"];
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
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\LENOVO\source\repos\Army Database 2.0\Army Database 2.0\ammunitionDatabase.mdf; Integrated Security = True; Connect Timeout = 30");
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = null;


            for (int i = dataGridView1.RowCount; i < dataGridView1.RowCount + 1; i++)
            {
                sql = "INSERT INTO [dbo].[Ammo] ([Ammo_caliber], [abbv], [length], [weapon_type], [muzzle_vel]) VALUES ('" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "')";



                try
                {
                    conn.Open();
                    adapter.InsertCommand = new SqlCommand(sql, conn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Row inserted !! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

            private void Ammo_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'ammunitionDatabaseDataSet4.Ammo' table. You can move, or remove it, as needed.
                this.ammoTableAdapter.Fill(this.ammunitionDatabaseDataSet4.Ammo);


            }

          

        }
    }


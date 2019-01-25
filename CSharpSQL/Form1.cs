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
using System.Configuration;
namespace CSharpSQL
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString;

        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CSharpSQL.Properties.Settings.StudEvidencija"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        

        private int ExecuteQuery(string query)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                errorTextBox.Text = String.Concat("SQL Query Failed: ", e.Message);
                return 0;
            }
            catch (InvalidOperationException e)
            {
                errorTextBox.Text = String.Concat("SQL Query Failed: ", e.Message);
                return 0;
            }
        }

        private DataTable ExecuteSelectQuery(string query)
        {
            DataTable results = new DataTable();

            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(results);
                    return results;
                }
            }
            catch (SqlException e)
            {
                errorTextBox.Text = String.Concat("SQL Query Failed: ", e.Message);
                return null;
            }
            catch (InvalidOperationException e)
            {
                errorTextBox.Text = String.Concat("SQL Query Failed: ", e.Message);
                return null;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            string query = queryTextBox.Text;
            string[] temp = queryTextBox.Text.Split(' ');
            string cmd = temp[0];
            dataGridView1.DataSource = new DataTable();

            if (string.IsNullOrWhiteSpace(query))
            {
                errorTextBox.Text = "Enter query first!";
                return;
            }

            if (string.Equals(cmd, "select", StringComparison.OrdinalIgnoreCase))
            {
                DataTable results = ExecuteSelectQuery(query);
                if (results != null)
                {
                    dataGridView1.DataSource = results;
                    errorTextBox.Text = "";
                }
            }
            else
            {
                int rows = ExecuteQuery(query);
                if (rows > 0)
                    MessageBox.Show(cmd + " finished succesfully! -- " + rows + " rows affected","Failed");
                else
                    MessageBox.Show("cannot " + cmd);
            }
        }

    }
}

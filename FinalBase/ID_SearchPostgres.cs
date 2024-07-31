using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalBase
{
    public partial class ID_SearchPostgres : Form
    {
        private NpgsqlConnection connection;
        private NpgsqlCommand command;

        public ID_SearchPostgres()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=12345;Database=consultapostgres";
            connection = new NpgsqlConnection(connectionString);
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                FetchDataById();
            }
            else
            {
                MessageBox.Show("ID field must be filled out.");
            }
        }

        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(txt_id.Text);
        }

        private void FetchDataById()
        {
            try
            {
                string query = "SELECT * FROM get_data_by_id(@id)";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", int.Parse(txt_id.Text));

                    using (var reader = command.ExecuteReader())
                    {
                        var dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

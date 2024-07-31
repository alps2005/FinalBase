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
    public partial class ReadPostgres : Form
    {
        private NpgsqlConnection connection;
        private NpgsqlCommand command;
        public ReadPostgres()
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
            string query = "SELECT * FROM show_all()";
            FetchData(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM show_provincia_canton()";
            FetchData(query);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM show_provincia_parroquia()";
            FetchData(query);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM show_canton_parroquia()";
            FetchData(query);
        }

        private void FetchData(string query)
        {
            try
            {
                using (var command = new NpgsqlCommand(query, connection))
                {
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

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace FinalBase
{
    public partial class ReadPostgres : Form
    {
        private NpgsqlConnection connection;

        public ReadPostgres()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=12345;Database=consultapostgres";
            connection = new NpgsqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ExecuteProcedure(string procedureName)
        {
            try
            {
                using (var command = new NpgsqlCommand($"CALL {procedureName}()", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void FetchData(string tableName)
        {
            try
            {
                using (var command = new NpgsqlCommand($"SELECT * FROM {tableName}", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        var dataTable = new DataTable();
                        dataTable.Load(reader);
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Ningun dato retorno.");
                        }
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExecuteProcedure("show_all");
            FetchData("temp_show_all");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExecuteProcedure("show_provincia_canton");
            FetchData("temp_show_provincia_canton");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExecuteProcedure("show_provincia_parroquia");
            FetchData("temp_show_provincia_parroquia");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExecuteProcedure("show_canton_parroquia");
            FetchData("temp_show_canton_parroquia");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ID_SearchPostgres postgres = new ID_SearchPostgres();
            postgres.Show();
        }
    }
}

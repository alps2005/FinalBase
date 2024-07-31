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
    public partial class DeletePostgres : Form
    {
        private NpgsqlConnection connection;
        private NpgsqlCommand command;
        public DeletePostgres()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                try
                {
                    string connectionString = "Host=localhost;Username=postgres;Password=12345;Database=consultapostgres";

                    using (var conn = new NpgsqlConnection(connectionString))
                    {
                        conn.Open();
                        int id = int.Parse(txt_id.Text);

                        // Delete from Provincias
                        using (var cmd = new NpgsqlCommand("SELECT delete_provincia(@id)", conn))
                        {
                            cmd.Parameters.AddWithValue("id", id);
                            cmd.ExecuteNonQuery();
                        }

                        // Delete from Cantones
                        using (var cmd = new NpgsqlCommand("SELECT delete_canton(@id)", conn))
                        {
                            cmd.Parameters.AddWithValue("id", id);
                            cmd.ExecuteNonQuery();
                        }

                        // Delete from Parroquias
                        using (var cmd = new NpgsqlCommand("SELECT delete_parroquia(@id)", conn))
                        {
                            cmd.Parameters.AddWithValue("id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Data deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
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
    }
}

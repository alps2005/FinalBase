using System;
using Npgsql;
using System.Windows.Forms;

namespace FinalBase
{
    public partial class Postgres : Form
    {
        private NpgsqlConnection connection;
        private NpgsqlCommand command;
        public Postgres()
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

        private void button5_Click(object sender, EventArgs e)
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

                        // Insert into Provincias
                        using (var cmd = new NpgsqlCommand("CALL insert_provincia(@pro_name)", conn))
                        {
                            cmd.Parameters.AddWithValue("pro_name", txt_provincias.Text);
                            cmd.ExecuteNonQuery();
                        }

                        // Retrieve the last inserted id for Provincia
                        int provinciaId;
                        using (var cmd = new NpgsqlCommand("SELECT currval(pg_get_serial_sequence('Provincias', 'id'))", conn))
                        {
                            provinciaId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // Insert into Cantones
                        using (var cmd = new NpgsqlCommand("CALL insert_canton(@can_name, @provincia_id)", conn))
                        {
                            cmd.Parameters.AddWithValue("can_name", txt_cantones.Text);
                            cmd.Parameters.AddWithValue("provincia_id", provinciaId);
                            cmd.ExecuteNonQuery();
                        }

                        // Retrieve the last inserted id for Canton
                        int cantonId;
                        using (var cmd = new NpgsqlCommand("SELECT currval(pg_get_serial_sequence('Cantones', 'id'))", conn))
                        {
                            cantonId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // Insert into Parroquias
                        using (var cmd = new NpgsqlCommand("CALL insert_parroquia(@par_name, @canton_id)", conn))
                        {
                            cmd.Parameters.AddWithValue("par_name", txt_parroquias.Text);
                            cmd.Parameters.AddWithValue("canton_id", cantonId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Datos insertados exitosamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar llenos.");
            }
        }

        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(txt_provincias.Text) &&
                   !string.IsNullOrWhiteSpace(txt_cantones.Text) &&
                   !string.IsNullOrWhiteSpace(txt_parroquias.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeletePostgres postgres = new DeletePostgres();
            postgres.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReadPostgres postgres = new ReadPostgres();
            postgres.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdatePostgres postgres = new UpdatePostgres();
            postgres.Show();
        }
    }
}

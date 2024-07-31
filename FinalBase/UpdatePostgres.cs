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
    public partial class UpdatePostgres : Form
    {
        private NpgsqlConnection connection;
        private NpgsqlCommand command;
        public UpdatePostgres()
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
            int id;
            if (int.TryParse(textBox1.Text, out id))
            {
                string newProName = textBox2.Text;
                string newCanName = textBox3.Text;
                string newParName = textBox4.Text;

                if (!string.IsNullOrWhiteSpace(newProName) &&
                    !string.IsNullOrWhiteSpace(newCanName) &&
                    !string.IsNullOrWhiteSpace(newParName))
                {
                    UpdateData(id, newProName, newCanName, newParName);
                }
                else
                {
                    MessageBox.Show("All fields must be filled out.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.");
            }
        }

        private void UpdateData(int id, string newProName, string newCanName, string newParName)
        {
            string query = "SELECT update_data(@id, @newProName, @newCanName, @newParName)";

            try
            {
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@newProName", newProName);
                    command.Parameters.AddWithValue("@newCanName", newCanName);
                    command.Parameters.AddWithValue("@newParName", newParName);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Data updated successfully.");
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

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalBase
{
    public partial class BusServer : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-AGG79CP;Initial Catalog=Project;Persist Security Info=True;User ID=sa;Password=fransua0513");

        public BusServer()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Buscar Provincia
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    using (SqlCommand cmd = new SqlCommand("GetProvincia", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox2.Text = reader["nombre"].ToString();
                            }
                        }
                    }
                }

                // Buscar Canton
                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    using (SqlCommand cmd = new SqlCommand("GetCanton", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", int.Parse(textBox3.Text));

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox4.Text = reader["nombre"].ToString();
                            }
                        }
                    }
                }

                // Buscar Parroquia
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    using (SqlCommand cmd = new SqlCommand("GetParroquia", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", int.Parse(textBox5.Text));

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox6.Text = reader["nombre"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = string.Empty;

                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Provincia":
                        query = "SELECT * FROM Provincias";
                        break;
                    case "Canton":
                        query = "SELECT * FROM Cantones";
                        break;
                    case "Parroquia":
                        query = "SELECT * FROM Parroquias";
                        break;
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void BusServer_Load(object sender, EventArgs e)
        {

        }
    }
}

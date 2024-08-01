using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalBase
{
    public partial class EditForm : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-AGG79CP;Initial Catalog=Project;Persist Security Info=True;User ID=sa;Password=fransua0513;Trust Server Certificate=True");

        public EditForm()
        {
            InitializeComponent();
            LoadComboBoxOptions();
        }

        private void LoadComboBoxOptions()
        {
            // Cargar las opciones en el ComboBox principal
            comboBoxEntityType.Items.Add("Provincia");
            comboBoxEntityType.Items.Add("Canton");
            comboBoxEntityType.Items.Add("Parroquia");
        }

        private void comboBoxEntityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboBoxEntityType.SelectedItem.ToString();
            LoadListComboBox(selectedType);
            DisplayDataInGridView(selectedType); // Mostrar datos en DataGridView
        }

        private void LoadListComboBox(string type)
        {
            DataTable dt = new DataTable();
            string query = "";

            if (type == "Provincia")
                query = "GetProvincias";
            else if (type == "Canton")
                query = "GetCantones";
            else if (type == "Parroquia")
                query = "GetParroquias";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                con.Close();
            }

            comboBoxList.DataSource = dt;
            comboBoxList.DisplayMember = "nombre";
            comboBoxList.ValueMember = "id";
        }

        private void DisplayDataInGridView(string type)
        {
            try
            {
                con.Open();
                string query = "";

                switch (type)
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

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            string type = comboBoxEntityType.SelectedItem.ToString();
            LoadData(id, type);
        }

        private void LoadData(int id, string type)
        {
            string query = "";
            if (type == "Provincia")
                query = "SELECT nombre FROM Provincias WHERE id = @id";
            else if (type == "Canton")
                query = "SELECT nombre, provincia_id FROM Cantones WHERE id = @id";
            else if (type == "Parroquia")
                query = "SELECT nombre, canton_id FROM Parroquias WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBoxName.Text = reader["nombre"].ToString();
                    if (type == "Canton")
                        comboBoxProvincias.SelectedValue = reader["provincia_id"];
                    else if (type == "Parroquia")
                        comboBoxCantones.SelectedValue = reader["canton_id"];
                }
                con.Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            string name = textBoxName.Text;
            string type = comboBoxEntityType.SelectedItem.ToString();
            SaveData(id, name, type);
        }

        private void SaveData(int id, string name, string type)
        {
            string query = "";
            if (type == "Provincia")
                query = "UPDATE Provincias SET nombre = @nombre WHERE id = @id";
            else if (type == "Canton")
                query = "UPDATE Cantones SET nombre = @nombre, provincia_id = @provincia_id WHERE id = @id";
            else if (type == "Parroquia")
                query = "UPDATE Parroquias SET nombre = @nombre, canton_id = @canton_id WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@nombre", name);
                cmd.Parameters.AddWithValue("@id", id);
                if (type == "Canton")
                    cmd.Parameters.AddWithValue("@provincia_id", comboBoxProvincias.SelectedValue);
                else if (type == "Parroquia")
                    cmd.Parameters.AddWithValue("@canton_id", comboBoxCantones.SelectedValue);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void comboBoxProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCantones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
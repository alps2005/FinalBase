using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalBase
{
    public partial class DelServer : Form
    {
        public DelServer()
        {
            InitializeComponent();
            // Configura el ComboBox solo una vez en el constructor
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.Clear(); // Limpia los elementos existentes
            comboBox1.Items.AddRange(new string[] { "Provincia", "Canton", "Parroquia" });
            comboBox1.SelectedIndex = 0; // Selecciona Provincia por defecto
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dataTable = null;
            string selectedType = comboBox1.SelectedItem.ToString();

            switch (selectedType)
            {
                case "Provincia":
                    dataTable = DatabaseUtils.BuscarProvincias();
                    break;
                case "Canton":
                    dataTable = DatabaseUtils.BuscarCantones();
                    break;
                case "Parroquia":
                    dataTable = DatabaseUtils.BuscarParroquias();
                    break;
            }

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = dataTable;

                // Configura las columnas del DataGridView según el tipo de datos
                if (selectedType == "Provincia")
                {
                    dataGridView1.Columns["id"].HeaderText = "ID Provincia";
                    dataGridView1.Columns["nombre"].HeaderText = "Nombre Provincia";
                }
                else if (selectedType == "Canton")
                {
                    dataGridView1.Columns["id"].HeaderText = "ID Canton";
                    dataGridView1.Columns["nombre"].HeaderText = "Nombre Canton";
                    dataGridView1.Columns["provincia_id"].HeaderText = "ID Provincia";
                }
                else if (selectedType == "Parroquia")
                {
                    dataGridView1.Columns["id"].HeaderText = "ID Parroquia";
                    dataGridView1.Columns["nombre"].HeaderText = "Nombre Parroquia";
                    dataGridView1.Columns["canton_id"].HeaderText = "ID Canton";
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("No hay datos para mostrar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(textBox1.Text, out id))
            {
                // Elimina la provincia, canton o parroquia basado en la selección
                string selectedType = comboBox1.SelectedItem.ToString();

                switch (selectedType)
                {
                    case "Provincia":
                        DatabaseUtils.EliminarProvincia(id);
                        break;
                    case "Canton":
                        DatabaseUtils.EliminarCanton(id);
                        break;
                    case "Parroquia":
                        DatabaseUtils.EliminarParroquia(id);
                        break;
                }

                MessageBox.Show("Registro eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }

        private void DelServer_Load(object sender, EventArgs e)
        {
            // Solo llama a InitializeComboBox en el evento Load si es necesario
            // InitializeComboBox(); // Esta línea puede ser eliminada si ya se llama en el constructor
        }
    }
}

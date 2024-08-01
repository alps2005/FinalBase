using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace FinalBase
{
    public partial class ServerForms1 : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-AGG79CP;Initial Catalog=Project;Persist Security Info=True;User ID=sa;Password=fransua0513;Trust Server Certificate=True");

        public ServerForms1()
        {
            InitializeComponent();
        }

        private void InsertarProvincia(string nombre)
        {
            using (SqlCommand cmd = new SqlCommand("InsertProvincia", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void InsertarCanton(string nombre, int provinciaId)
        {
            using (SqlCommand cmd = new SqlCommand("InsertCanton", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@provincia_id", provinciaId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void InsertarParroquia(string nombre, int cantonId)
        {
            using (SqlCommand cmd = new SqlCommand("InsertParroquia", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@canton_id", cantonId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void EliminarProvincia(int id)
        {
            using (SqlCommand cmd = new SqlCommand("DeleteProvincia", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void EliminarCanton(int id)
        {
            using (SqlCommand cmd = new SqlCommand("DeleteCanton", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void EliminarParroquia(int id)
        {
            using (SqlCommand cmd = new SqlCommand("DeleteParroquia", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private DataTable BuscarProvincias()
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("GetProvincias", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                con.Close();
            }
            return dt;
        }

        private DataTable BuscarCantones()
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("GetCantones", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                con.Close();
            }
            return dt;
        }

        private DataTable BuscarParroquias()
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("GetParroquias", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                con.Close();
            }
            return dt;
        }

        private void ModificarProvincia(int id, string nombre)
        {
            using (SqlCommand cmd = new SqlCommand("UpdateProvincia", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void ModificarCanton(int id, string nombre, int provinciaId)
        {
            using (SqlCommand cmd = new SqlCommand("UpdateCanton", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@provincia_id", provinciaId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void ModificarParroquia(int id, string nombre, int cantonId)
        {
            using (SqlCommand cmd = new SqlCommand("UpdateParroquia", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@canton_id", cantonId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreProvincia = textBox1.Text;
            string nombreCanton = textBox2.Text;
            string nombreParroquia = textBox3.Text;

            // Ejemplo de IDs para demostración
            int provinciaId = 1;
            int cantonId = 1;

            // Insertar datos
            InsertarProvincia(nombreProvincia);
            InsertarCanton(nombreCanton, provinciaId);
            InsertarParroquia(nombreParroquia, cantonId);

            MessageBox.Show("Datos guardados correctamente.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditForm editServerForm = new EditForm();
            editServerForm.ShowDialog();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Abre el formulario BusServer
            BusServer busServerForm = new BusServer();
            busServerForm.ShowDialog(); // Usa ShowDialog() para mostrar el formulario como una ventana modal.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Abre el formulario DelServer
            DelServer delServerForm = new DelServer();
            delServerForm.ShowDialog(); // Usa ShowDialog() para mostrar el formulario como una ventana modal.
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Aquí iría el código para el label3 si es necesario
        }

        private void ServerForms1_Load(object sender, EventArgs e)
        {
            // Aquí puedes inicializar los controles si es necesario
        }
    }
}

using MySql.Data.MySqlClient;
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
    public partial class ParroquiasMySQL : Form
    {
        DataTable Table = new DataTable();
        DataTable dataTable = new DataTable();
        private Conexion mConexion;
        private MySqlCommand comando;
        public ParroquiasMySQL()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                mConexion = new Conexion();
                using (MySqlConnection conn = mConexion.getConexion())
                {
                    using (MySqlCommand comando = new MySqlCommand("sp_Insertarparroquia", conn))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@pnombre", txt_nombre.Text);


                        comando.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Registro guardado");

                        // Limpiar los campos de texto
                        txt_id.Text = "";
                        txt_nombre.Text = "";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = null;

            try
            {
                mConexion = new Conexion();
                using (MySqlConnection conn = mConexion.getConexion())
                {
                    using (MySqlCommand comando = new MySqlCommand("sp_Buscarparroquia", conn))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        int codigo_provincia = Convert.ToInt32(txt_id.Text);
                        comando.Parameters.AddWithValue("@pparroquiaID", codigo_provincia);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    txt_id.Text = reader.GetInt32(0).ToString(); // Convertir Int32 a String
                                    txt_nombre.Text = reader.GetString(1);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron registros");

                            }
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                mConexion = new Conexion();
                using (MySqlConnection conn = mConexion.getConexion())
                {
                    if (string.IsNullOrEmpty(txt_id.Text) || string.IsNullOrEmpty(txt_nombre.Text))
                    {
                        MessageBox.Show("Faltan campos por llenar");
                    }
                    else
                    {
                        using (MySqlCommand comando = new MySqlCommand("sp_Modificarparroquia", conn))
                        {
                            comando.CommandType = CommandType.StoredProcedure;

                            int codigo_cliente = Convert.ToInt32(txt_id.Text);
                            comando.Parameters.AddWithValue("@pparroquiaID", codigo_cliente);
                            comando.Parameters.AddWithValue("@pnombre", txt_nombre.Text);
                            comando.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Registro modificado");

                            // Limpiar los campos de texto
                            txt_id.Text = "";
                            txt_nombre.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                mConexion = new Conexion();
                using (MySqlConnection conn = mConexion.getConexion())
                {
                    if (string.IsNullOrEmpty(txt_id.Text))
                    {
                        MessageBox.Show("Debe proporcionar un ID de usuario");
                    }
                    else
                    {
                        using (MySqlCommand comando = new MySqlCommand("sp_parroquia_de", conn))
                        {
                            comando.CommandType = CommandType.StoredProcedure;

                            int ci_provincia = Convert.ToInt32(txt_id.Text);
                            comando.Parameters.AddWithValue("@pparroquiaID", ci_provincia);

                            comando.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Usuario eliminado");

                            // Limpiar los campos de texto
                            txt_id.Text = "";
                            txt_nombre.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            try
            {
                mConexion = new Conexion();
                using (MySqlConnection conn = mConexion.getConexion())
                {
                    using (MySqlCommand comando = new MySqlCommand("sp_Mostrarparroquia", conn))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar datos: " + ex.Message);
            }
        }
    }
}

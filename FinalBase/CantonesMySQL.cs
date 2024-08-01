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
    public partial class CantonesMySQL : Form
    {
        DataTable Table = new DataTable();
        DataTable dataTable = new DataTable();
        private Conexion mConexion;
        private MySqlCommand comando;
        public CantonesMySQL()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                mConexion = new Conexion();
                using (MySqlConnection conn = mConexion.getConexion())
                {
                    using (MySqlCommand comando = new MySqlCommand("sp_Insertarcanton", conn))
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
                    using (MySqlCommand comando = new MySqlCommand("sp_Buscarcanton", conn))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        int codigo_provincia = Convert.ToInt32(txt_id.Text);
                        comando.Parameters.AddWithValue("@pcantonID", codigo_provincia);

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

        private void btn_modificar_Click(object sender, EventArgs e)
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
                        using (MySqlCommand comando = new MySqlCommand("sp_Modificarcanton", conn))
                        {
                            comando.CommandType = CommandType.StoredProcedure;

                            int codigo_cliente = Convert.ToInt32(txt_id.Text);
                            comando.Parameters.AddWithValue("@pcantonID", codigo_cliente);
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
                        using (MySqlCommand comando = new MySqlCommand("sp_canton_de", conn))
                        {
                            comando.CommandType = CommandType.StoredProcedure;

                            int ci_provincia = Convert.ToInt32(txt_id.Text);
                            comando.Parameters.AddWithValue("@pcantonID", ci_provincia);

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

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            try
            {
                mConexion = new Conexion();
                using (MySqlConnection conn = mConexion.getConexion())
                {
                    using (MySqlCommand comando = new MySqlCommand("sp_Mostrarcanton", conn))
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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

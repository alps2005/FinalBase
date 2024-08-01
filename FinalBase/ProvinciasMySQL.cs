using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalBase
{
    public partial class ProvinciasMySQL : Form
    {
        DataTable Table = new DataTable();
        DataTable dataTable = new DataTable();
        private Conexion mConexion;
        private MySqlCommand comando;
        public ProvinciasMySQL()
        {

            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                mConexion = new Conexion();
                using (MySqlConnection conn = mConexion.getConexion())
                {
                    using (MySqlCommand comando = new MySqlCommand("sp_Insertarprovincia", conn))
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

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = null;

            try
            {
                mConexion = new Conexion();
                using (MySqlConnection conn = mConexion.getConexion())
                {
                    using (MySqlCommand comando = new MySqlCommand("sp_Buscarprovincia", conn))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        int codigo_provincia = Convert.ToInt32(txt_id.Text);
                        comando.Parameters.AddWithValue("@pprovinciaID", codigo_provincia);

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
                        using (MySqlCommand comando = new MySqlCommand("sp_Modificarprovincia", conn))
                        {
                            comando.CommandType = CommandType.StoredProcedure;

                            int codigo_cliente = Convert.ToInt32(txt_id.Text);
                            comando.Parameters.AddWithValue("@pprovinciaID", codigo_cliente);
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

        private void btn_eliminar_Click(object sender, EventArgs e)
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
                        using (MySqlCommand comando = new MySqlCommand("sp_provincia_de", conn))
                        {
                            comando.CommandType = CommandType.StoredProcedure;

                            int ci_provincia = Convert.ToInt32(txt_id.Text);
                            comando.Parameters.AddWithValue("@pprovinciaID", ci_provincia);

                            //conn.Open();
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
                    using (MySqlCommand comando = new MySqlCommand("sp_Mostrarprovincia", conn))
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

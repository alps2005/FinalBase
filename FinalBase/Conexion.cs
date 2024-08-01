using MySql.Data.MySqlClient;
using Npgsql;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalBase
{
    internal class Conexion
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "proyecto";
        public string user = "root";
        private string password = "12345";
        private string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = "Database=" + database +
                "; DataSource=" + server +
                "; User Id= " + user +
                "; Password= " + password;
        }

        public MySqlConnection getConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            return conexion;
        }
    }

    internal class ConexionPostgres
    {
        private NpgsqlConnection postgresConnection;
        private string server = "localhost";
        private string database = "consultapostgres";
        public string user = "postgres";
        private string password = "12345";
        private string postgresConnectionString;

        public ConexionPostgres()
        {
            postgresConnectionString = "Host=" + server +
                                       "; Database=" + database +
                                       "; Username=" + user +
                                       "; Password=" + password;
        }

        public NpgsqlConnection getConexion()
        {
            if (postgresConnection == null)
            {
                postgresConnection = new NpgsqlConnection(postgresConnectionString);
                postgresConnection.Open();
            }
            return postgresConnection;
        }

        internal class DatabaseConnection
        {
            private static string connectionString = "User Id=system;Password=12345;Data Source=localhost";

            public static void InsertarProvincia(int provinciaId, string nombre, string codigo, string region)
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (OracleCommand cmd = new OracleCommand("sp_InsertarProvincia", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Agregar los parámetros
                            cmd.Parameters.Add("p_provincia_id", OracleDbType.Int32).Value = provinciaId;
                            cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                            cmd.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = codigo;
                            cmd.Parameters.Add("p_region", OracleDbType.Varchar2).Value = region;

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            MessageBox.Show("Provincia insertada exitosamente");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                    finally
                    {
                        // Cerrar la conexión
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }

            public static void ActualizarProvincia(int provinciaId, string nombre, string codigo, string region)
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (OracleCommand cmd = new OracleCommand("sp_ActualizarProvincia", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Agregar los parámetros
                            cmd.Parameters.Add("p_provincia_id", OracleDbType.Int64).Value = provinciaId;
                            cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                            cmd.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = codigo;
                            cmd.Parameters.Add("p_region", OracleDbType.Varchar2).Value = region;

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            MessageBox.Show("Provincia actualizada exitosamente");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                    finally
                    {
                        // Cerrar la conexión
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }

            public static void BorrarProvincia(int provinciaId)
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (OracleCommand cmd = new OracleCommand("sp_BorrarProvincia", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Agregar los parámetros
                            cmd.Parameters.Add("p_provincia_id", OracleDbType.Int64).Value = provinciaId;

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            MessageBox.Show("Provincia eliminada exitosamente");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                    finally
                    {
                        // Cerrar la conexión
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }

            public static DataTable SelectProvincia()
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand("sp_SelectProvincia", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        conn.Open();

                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            // Métodos para Canton

            public static DataTable SelectCantones()
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand("sp_SelectCantones", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        conn.Open();

                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            public static void InsertarCanton(int cantonId, string nombre, int provinciaId, string codigo, int poblacion)
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (OracleCommand cmd = new OracleCommand("sp_InsertarCanton", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Agregar los parámetros
                            cmd.Parameters.Add("p_canton_id", OracleDbType.Int64).Value = cantonId;
                            cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                            cmd.Parameters.Add("p_provincia_id", OracleDbType.Int64).Value = provinciaId;
                            cmd.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = codigo;
                            cmd.Parameters.Add("p_poblacion", OracleDbType.Int64).Value = poblacion;

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            MessageBox.Show("Canton insertado exitosamente");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                    finally
                    {
                        // Cerrar la conexión
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }

            public static void ActualizarCanton(int cantonId, string nombre, int provinciaId, string codigo, int poblacion)
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (OracleCommand cmd = new OracleCommand("sp_ActualizarCanton", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Agregar los parámetros
                            cmd.Parameters.Add("p_canton_id", OracleDbType.Int64).Value = cantonId;
                            cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                            cmd.Parameters.Add("p_provincia_id", OracleDbType.Int64).Value = provinciaId;
                            cmd.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = codigo;
                            cmd.Parameters.Add("p_poblacion", OracleDbType.Int64).Value = poblacion;

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            MessageBox.Show("Canton actualizado exitosamente");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                    finally
                    {
                        // Cerrar la conexión
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }

            public static void BorrarCanton(int cantonId)
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (OracleCommand cmd = new OracleCommand("sp_BorrarCanton", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Agregar los parámetros
                            cmd.Parameters.Add("p_canton_id", OracleDbType.Int64).Value = cantonId;

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            MessageBox.Show("Canton eliminado exitosamente");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                    finally
                    {
                        // Cerrar la conexión
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }

            public static DataTable SelectParroquias()
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand("sp_SelectParroquia", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        conn.Open();

                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            public static void InsertarParroquia(int parroquiaId, string nombre, int cantonId, string codigo, string tipo)
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (OracleCommand cmd = new OracleCommand("sp_InsertarParroquia", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Agregar los parámetros
                            cmd.Parameters.Add("p_parroquia_id", OracleDbType.Int64).Value = parroquiaId;
                            cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                            cmd.Parameters.Add("p_canton_id", OracleDbType.Int64).Value = cantonId;
                            cmd.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = codigo;
                            cmd.Parameters.Add("p_tipo", OracleDbType.Varchar2).Value = tipo;

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            MessageBox.Show("Parroquia insertada exitosamente");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                    finally
                    {
                        // Cerrar la conexión
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }

            public static void ActualizarParroquia(int parroquiaId, string nombre, int cantonId, string codigo, string tipo)
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (OracleCommand cmd = new OracleCommand("sp_ActualizarParroquia", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Agregar los parámetros
                            cmd.Parameters.Add("p_parroquia_id", OracleDbType.Int64).Value = parroquiaId;
                            cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                            cmd.Parameters.Add("p_canton_id", OracleDbType.Int64).Value = cantonId;
                            cmd.Parameters.Add("p_codigo", OracleDbType.Varchar2).Value = codigo;
                            cmd.Parameters.Add("p_tipo", OracleDbType.Varchar2).Value = tipo;

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            MessageBox.Show("Parroquia actualizada exitosamente");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                    finally
                    {
                        // Cerrar la conexión
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }

            public static void BorrarParroquia(int parroquiaId)
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (OracleCommand cmd = new OracleCommand("sp_BorrarParroquia", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Agregar los parámetros
                            cmd.Parameters.Add("p_parroquia_id", OracleDbType.Int64).Value = parroquiaId;

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            MessageBox.Show("Parroquia eliminada exitosamente");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                    finally
                    {
                        // Cerrar la conexión
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }

            public static DataTable BuscarDetalles(int? provinciaId, int? cantonId, int? parroquiaId)
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (OracleCommand cmd = new OracleCommand("sp_BuscarDetalles", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Parámetros opcionales
                            cmd.Parameters.Add("p_provincia_id", OracleDbType.Int32).Value = (object)provinciaId ?? DBNull.Value;
                            cmd.Parameters.Add("p_canton_id", OracleDbType.Int32).Value = (object)cantonId ?? DBNull.Value;
                            cmd.Parameters.Add("p_parroquia_id", OracleDbType.Int32).Value = (object)parroquiaId ?? DBNull.Value;

                            // Parámetro de salida
                            cmd.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                            using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                                return dt;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                        return null;
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }
    }
}

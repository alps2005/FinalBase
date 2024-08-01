using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

using System.Data;
using Microsoft.Data.SqlClient;

namespace FinalBase
{
    public static class DatabaseUtils
    {
        private static readonly SqlConnection con = new SqlConnection("Data Source=DESKTOP-AGG79CP;Initial Catalog=Project;Persist Security Info=True;User ID=sa;Password=fransua0513;Trust Server Certificate=True");

        public static void InsertarProvincia(string nombre)
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

        public static void InsertarCanton(string nombre, int provinciaId)
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

        public static void InsertarParroquia(string nombre, int cantonId)
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

        public static void EliminarProvincia(int id)
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

        public static void EliminarCanton(int id)
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

        public static void EliminarParroquia(int id)
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

        public static DataTable BuscarProvincias()
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

        public static DataTable BuscarCantones()
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

        public static DataTable BuscarParroquias()
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
    }
}

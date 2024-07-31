using MySql.Data.MySqlClient;
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
    public partial class Provincias : Form
    {
        public int provinciaID { get; set; }
        public string nombre { get; set; }

        public Provincias()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private DataSet CargaDatos()
        {
            DataSet datos = new DataSet();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_provincia_se"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(datos, "data");
                    }
                }
                return datos;
            }

            catch (MySqlException ex)
            {
                Console.WriteLine("ERROR" + ex.Message + "HAS OCCURRED: " + ex.Message);
                return null;
            }
            
        }
        public int Insert()
        {
            int Id = 0;
            DataSet datos = new DataSet();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_provincia_in"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pnombre", nombre.ToString().ToUpper().Trim());
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(datos, "data");
                        Id = 1;
                    }
                }
                return Id;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("ERROR" + ex.Message + "HAS OCCURRED: " + ex.Message);
                return 0;
            }
        }
        public int Update()
        {
            int Id = 0;
            DataSet datos = new DataSet();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_provincia_up"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pprovinciaID", provinciaID.ToString().ToUpper().Trim());
                    cmd.Parameters.AddWithValue("@pnombre", nombre.ToString().ToUpper().Trim());
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(datos, "data");
                        Id = 1;
                    }
                }
                return Id;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("ERROR" + ex.Message + "HAS OCCURRED: " + ex.Message);
                return 0;
            }
        }
        public int Delete()
        {
            int Id = 0;
            DataSet datos = new DataSet();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_provincia_de"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pprovinciaID", provinciaID.ToString().ToUpper().Trim());
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(datos, "data");
                        Id = 1;
                    }
                }
                return Id;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("ERROR" + ex.Message + "HAS OCCURRED: " + ex.Message);
                return 0;
            }
        }
    }
}

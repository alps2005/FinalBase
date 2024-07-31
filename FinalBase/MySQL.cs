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
    public partial class MySQL : Form
    {
        public MySQL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProvinciasMySQL provincias = new ProvinciasMySQL();   
            provincias.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_parroquias_Click(object sender, EventArgs e)
        {
            ParroquiasMySQL parroquias = new ParroquiasMySQL();
            parroquias.Show();
        }

        private void btn_cantones_Click(object sender, EventArgs e)
        {
            CantonesMySQL cantones = new CantonesMySQL(); 
            cantones.Show();
        }
    }
}

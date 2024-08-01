using System;
using System.Windows.Forms;

namespace FinalBase
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void mySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySQL mySQL = new MySQL();
            mySQL.Show();
        }

        private void postgresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Postgres postgres = new Postgres();
            postgres.Show();
        }

        private void oraclToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sQLserverToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

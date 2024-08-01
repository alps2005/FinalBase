using System;
using System.Data;
using System.Windows.Forms;
using static FinalBase.ConexionPostgres;

namespace FinalBase
{
    public partial class Oracle : Form
    {
        private int tablaToUse = 0;
        public Oracle()
        {
            InitializeComponent();
        }
        private void ClearInput()
        {
            txtIdPr.Text = "";
            txtNombreProvincia.Text = "";
            txtCodigoProvincia.Text = "";
            txtRegionProv.Text = "";

            inParrId.Text = "";
            inNombrePar.Text = "";
            inCantonIdPar.Text = "";
            inCodigoParr.Text = "";
            inTipoParr.Text = "";

            inCantonId.Text = "";
            inNombreCan.Text = "";
            inProviIdCan.Text = "";
            inCodigoCan.Text = "";
            inPoblaciCan.Text = "";

            inputCanton.Text = "";
            inputParroquia.Text = "";
            inputProvincia.Text = "";
        }
        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bInsertar_Click(object sender, EventArgs e)
        {
            switch (tablaToUse)
            {
                case 1:
                    if (txtNombreProvincia.Text.Equals("") || txtCodigoProvincia.Text.Equals("") || txtRegionProv.Text.Equals(""))
                    {
                        MessageBox.Show("Se debe llenar los campos de Provincia");
                    }
                    else
                    {
                        DatabaseConnection.InsertarProvincia(
                            int.Parse(txtIdPr.Text),
                            txtNombreProvincia.Text,
                            txtCodigoProvincia.Text,
                            txtRegionProv.Text
                        );
                    }
                    break;

                case 2:
                    if (inNombrePar.Text.Equals("") || inCantonIdPar.Text.Equals("") || inCodigoParr.Text.Equals("") || inTipoParr.Text.Equals(""))
                    {
                        MessageBox.Show("Se debe llenar los campos de Parroquia");
                    }
                    else
                    {
                        DatabaseConnection.InsertarParroquia(
                            int.Parse(inParrId.Text),
                            inNombrePar.Text,
                            int.Parse(inCantonIdPar.Text),
                            inCodigoParr.Text,
                            inTipoParr.Text
                        );
                    }
                    break;

                case 3:
                    if (inNombreCan.Text.Equals("") || inProviIdCan.Text.Equals("") || inCodigoCan.Text.Equals("") || inPoblaciCan.Text.Equals(""))
                    {
                        MessageBox.Show("Se debe llenar los campos de Cantón");
                    }
                    else
                    {
                        DatabaseConnection.InsertarCanton(
                            int.Parse(inCantonId.Text),
                            inNombreCan.Text,
                            int.Parse(inProviIdCan.Text),
                            inCodigoCan.Text,
                            int.Parse(inPoblaciCan.Text)
                        );
                    }
                    break;

                default:
                    Console.WriteLine("El valor no es 1, 2 o 3");
                    break;
            }
            ClearInput();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            switch (tablaToUse)
            {
                case 1:
                    if (txtIdPr.Text.Equals("") || txtNombreProvincia.Text.Equals("") || txtCodigoProvincia.Text.Equals("") || txtRegionProv.Text.Equals(""))
                    {
                        MessageBox.Show("Se debe llenar los campos de Provincia");
                    }
                    else
                    {
                        DatabaseConnection.ActualizarProvincia(
                            int.Parse(txtIdPr.Text),
                            txtNombreProvincia.Text,
                            txtCodigoProvincia.Text,
                            txtRegionProv.Text
                        );
                    }
                    break;

                case 2:
                    if (inParrId.Text.Equals("") || inNombrePar.Text.Equals("") || inCantonIdPar.Text.Equals("") || inCodigoParr.Text.Equals("") || inTipoParr.Text.Equals(""))
                    {
                        MessageBox.Show("Se debe llenar los campos de Parroquia");
                    }
                    else
                    {
                        DatabaseConnection.ActualizarParroquia(
                            int.Parse(inParrId.Text),
                            inNombrePar.Text,
                            int.Parse(inCantonIdPar.Text),
                            inCodigoParr.Text,
                            inTipoParr.Text
                        );
                    }
                    break;

                case 3:
                    if (inCantonId.Text.Equals("") || inNombreCan.Text.Equals("") || inProviIdCan.Text.Equals("") || inCodigoCan.Text.Equals("") || inPoblaciCan.Text.Equals(""))
                    {
                        MessageBox.Show("Se debe llenar los campos de Cantón");
                    }
                    else
                    {
                        DatabaseConnection.ActualizarCanton(
                            int.Parse(inCantonId.Text),
                            inNombreCan.Text,
                            int.Parse(inProviIdCan.Text),
                            inCodigoCan.Text,
                            int.Parse(inPoblaciCan.Text)
                        );
                    }
                    break;

                default:
                    Console.WriteLine("El valor no es 1, 2 o 3");
                    break;
            }
            ClearInput();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            switch (tablaToUse)
            {
                case 1:
                    if (txtIdPr.Text.Equals(""))
                    {
                        MessageBox.Show("Se debe proporcionar el ID de la Provincia");
                    }
                    else
                    {
                        DatabaseConnection.BorrarProvincia(int.Parse(txtIdPr.Text));
                    }
                    break;

                case 2:
                    if (inParrId.Text.Equals(""))
                    {
                        MessageBox.Show("Se debe proporcionar el ID de la Parroquia");
                    }
                    else
                    {
                        DatabaseConnection.BorrarParroquia(int.Parse(inParrId.Text));
                    }
                    break;

                case 3:
                    if (inCantonId.Text.Equals(""))
                    {
                        MessageBox.Show("Se debe proporcionar el ID del Cantón");
                    }
                    else
                    {
                        DatabaseConnection.BorrarCanton(int.Parse(inCantonId.Text));
                    }
                    break;

                default:
                    Console.WriteLine("El valor no es 1, 2 o 3");
                    break;
            }
            ClearInput();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            PanelSelect.Visible = false;
            panelParroquia.Visible = false;
            panelCanton.Visible = false;
            panelProvincia.Visible = false;
            panelBusqueda.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bRegresarSelect_Click(object sender, EventArgs e)
        {
            PanelMain.Visible = true;
            PanelSelect.Visible = false;
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void fToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fToolStripMenuItem.Text = "Provincia";
            tablaToUse = 1;
            panelParroquia.Visible = false;
            panelCanton.Visible = false;
            panelProvincia.Visible = true;
        }

        private void fToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fToolStripMenuItem.Text = "Parroquia";
            tablaToUse = 2;
            panelProvincia.Visible = false;
            panelCanton.Visible = false;
            panelParroquia.Visible = true;
        }

        private void cantonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fToolStripMenuItem.Text = "Canton";
            tablaToUse = 3;
            panelParroquia.Visible = false;
            panelProvincia.Visible = false;
            panelCanton.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void bSelectAll_Click(object sender, EventArgs e)
        {
            if (tablaToUse == 0)
            {
                MessageBox.Show("Seleccione una tabla");
                return;
            }
            PanelMain.Visible = false;
            PanelSelect.Visible = true;
            DataTable dt;

            switch (tablaToUse)
            {
                case 1:
                    dt = DatabaseConnection.SelectProvincia();
                    if (dt.Rows.Count > 0)
                    {
                        tablaSelect.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Provincia no encontrada");
                        tablaSelect.DataSource = null;
                    }

                    break;

                case 2:
                    dt = DatabaseConnection.SelectParroquias();
                    if (dt.Rows.Count > 0)
                    {
                        tablaSelect.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Parroquia no encontrada");
                        tablaSelect.DataSource = null;
                    }

                    break;

                case 3:
                    dt = DatabaseConnection.SelectCantones();
                    if (dt.Rows.Count > 0)
                    {
                        tablaSelect.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Cantón no encontrado");
                        tablaSelect.DataSource = null;
                    }

                    break;

                default:
                    Console.WriteLine("El valor no es 1, 2 o 3");
                    break;
            }
            ClearInput();
        }

        private void bBuscarTablas_Click(object sender, EventArgs e)
        {
            DataTable dt;

            if (!inputProvincia.Text.Equals("") && inputCanton.Text.Equals("") && inputParroquia.Text.Equals(""))
            {
                // Solo se proporciona el ID de la Provincia
                dt = DatabaseConnection.BuscarDetalles(int.Parse(inputProvincia.Text), null, null);
                if (dt.Rows.Count > 0)
                {
                    tablaSelect.DataSource = dt;
                    PanelMain.Visible = false;
                    PanelSelect.Visible = true;
                }
                else
                {
                    MessageBox.Show("Detalles de la Provincia no encontrados");
                    tablaSelect.DataSource = null;
                }
            }
            else if (!inputProvincia.Text.Equals("") && !inputCanton.Text.Equals("") && inputParroquia.Text.Equals(""))
            {
                // Se proporcionan el ID de la Provincia y el ID del Cantón
                dt = DatabaseConnection.BuscarDetalles(int.Parse(inputProvincia.Text), int.Parse(inputCanton.Text), null);
                if (dt.Rows.Count > 0)
                {
                    tablaSelect.DataSource = dt;
                    PanelMain.Visible = false;
                    PanelSelect.Visible = true;
                }
                else
                {
                    MessageBox.Show("Detalles del Cantón no encontrados");
                    tablaSelect.DataSource = null;
                }
            }
            else if (!inputProvincia.Text.Equals("") && !inputCanton.Text.Equals("") && !inputParroquia.Text.Equals(""))
            {
                // Se proporcionan el ID de la Provincia, el ID del Cantón y el ID de la Parroquia
                dt = DatabaseConnection.BuscarDetalles(int.Parse(inputProvincia.Text), int.Parse(inputCanton.Text), int.Parse(inputParroquia.Text));
                if (dt.Rows.Count > 0)
                {
                    tablaSelect.DataSource = dt;
                    PanelMain.Visible = false;
                    PanelSelect.Visible = true;
                }
                else
                {
                    MessageBox.Show("Detalles de la Parroquia no encontrados");
                    tablaSelect.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Se deben proporcionar al menos el ID de la Provincia");
                tablaSelect.DataSource = null;
            }
            ClearInput();
        }

        private void bRegresarBusqueda_Click(object sender, EventArgs e)
        {
            panelBusqueda.Visible = false;
            PanelMain.Visible = true;
            PanelSelect.Visible = false;
        }
    }
}

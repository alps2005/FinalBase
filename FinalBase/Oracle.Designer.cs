namespace FinalBase
{
    partial class Oracle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bBack = new System.Windows.Forms.Button();
            this.bInsertar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.bRegresarBusqueda = new System.Windows.Forms.Button();
            this.bBuscarTablas = new System.Windows.Forms.Button();
            this.inputProvincia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputCanton = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputParroquia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCanton = new System.Windows.Forms.Panel();
            this.inProviIdCan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inCantonId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inPoblaciCan = new System.Windows.Forms.TextBox();
            this.inCodigoCan = new System.Windows.Forms.TextBox();
            this.inNombreCan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelParroquia = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.inCantonIdPar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.inParrId = new System.Windows.Forms.TextBox();
            this.txtparr = new System.Windows.Forms.Label();
            this.inTipoParr = new System.Windows.Forms.TextBox();
            this.inCodigoParr = new System.Windows.Forms.TextBox();
            this.inNombrePar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.bSelectAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cantonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelProvincia = new System.Windows.Forms.Panel();
            this.txtCodigoProvincia = new System.Windows.Forms.TextBox();
            this.txtCodigoPr = new System.Windows.Forms.Label();
            this.txtIdPr = new System.Windows.Forms.TextBox();
            this.txtProvinciaId = new System.Windows.Forms.Label();
            this.txtRegionProv = new System.Windows.Forms.TextBox();
            this.txtNombreProvincia = new System.Windows.Forms.TextBox();
            this.txtRegionPr = new System.Windows.Forms.Label();
            this.txtNombrePr = new System.Windows.Forms.Label();
            this.PanelSelect = new System.Windows.Forms.Panel();
            this.bRegresarSelect = new System.Windows.Forms.Button();
            this.tablaSelect = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PanelMain.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.panelCanton.SuspendLayout();
            this.panelParroquia.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelProvincia.SuspendLayout();
            this.PanelSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bBack.Location = new System.Drawing.Point(803, 487);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 23);
            this.bBack.TabIndex = 13;
            this.bBack.Text = "Salir";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.button4_Click);
            // 
            // bInsertar
            // 
            this.bInsertar.Location = new System.Drawing.Point(47, 249);
            this.bInsertar.Name = "bInsertar";
            this.bInsertar.Size = new System.Drawing.Size(75, 23);
            this.bInsertar.TabIndex = 9;
            this.bInsertar.Text = "Insertar";
            this.bInsertar.UseVisualStyleBackColor = true;
            this.bInsertar.Click += new System.EventHandler(this.bInsertar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bEliminar.Location = new System.Drawing.Point(147, 249);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 10;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(431, 37);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 11;
            this.bBuscar.Text = "Busqueda";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bModificar
            // 
            this.bModificar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bModificar.Location = new System.Drawing.Point(350, 249);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 12;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.Azure;
            this.PanelMain.Controls.Add(this.panelBusqueda);
            this.PanelMain.Controls.Add(this.panelCanton);
            this.PanelMain.Controls.Add(this.panelParroquia);
            this.PanelMain.Controls.Add(this.bSelectAll);
            this.PanelMain.Controls.Add(this.bModificar);
            this.PanelMain.Controls.Add(this.bBuscar);
            this.PanelMain.Controls.Add(this.bEliminar);
            this.PanelMain.Controls.Add(this.bInsertar);
            this.PanelMain.Controls.Add(this.menuStrip1);
            this.PanelMain.Controls.Add(this.panelProvincia);
            this.PanelMain.ForeColor = System.Drawing.Color.Black;
            this.PanelMain.Location = new System.Drawing.Point(256, 98);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(513, 282);
            this.PanelMain.TabIndex = 14;
            this.PanelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMain_Paint);
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.Aquamarine;
            this.panelBusqueda.Controls.Add(this.bRegresarBusqueda);
            this.panelBusqueda.Controls.Add(this.bBuscarTablas);
            this.panelBusqueda.Controls.Add(this.inputProvincia);
            this.panelBusqueda.Controls.Add(this.label2);
            this.panelBusqueda.Controls.Add(this.inputCanton);
            this.panelBusqueda.Controls.Add(this.label3);
            this.panelBusqueda.Controls.Add(this.inputParroquia);
            this.panelBusqueda.Controls.Add(this.label5);
            this.panelBusqueda.Location = new System.Drawing.Point(22, 82);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(400, 112);
            this.panelBusqueda.TabIndex = 23;
            this.panelBusqueda.Visible = false;
            // 
            // bRegresarBusqueda
            // 
            this.bRegresarBusqueda.Location = new System.Drawing.Point(102, 83);
            this.bRegresarBusqueda.Name = "bRegresarBusqueda";
            this.bRegresarBusqueda.Size = new System.Drawing.Size(75, 23);
            this.bRegresarBusqueda.TabIndex = 19;
            this.bRegresarBusqueda.Text = "Regresar";
            this.bRegresarBusqueda.UseVisualStyleBackColor = true;
            this.bRegresarBusqueda.Click += new System.EventHandler(this.bRegresarBusqueda_Click);
            // 
            // bBuscarTablas
            // 
            this.bBuscarTablas.Location = new System.Drawing.Point(225, 83);
            this.bBuscarTablas.Name = "bBuscarTablas";
            this.bBuscarTablas.Size = new System.Drawing.Size(75, 23);
            this.bBuscarTablas.TabIndex = 18;
            this.bBuscarTablas.Text = "Buscar";
            this.bBuscarTablas.UseVisualStyleBackColor = true;
            this.bBuscarTablas.Click += new System.EventHandler(this.bBuscarTablas_Click);
            // 
            // inputProvincia
            // 
            this.inputProvincia.Location = new System.Drawing.Point(78, 57);
            this.inputProvincia.Name = "inputProvincia";
            this.inputProvincia.Size = new System.Drawing.Size(307, 20);
            this.inputProvincia.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Provincia_id ";
            // 
            // inputCanton
            // 
            this.inputCanton.Location = new System.Drawing.Point(65, 5);
            this.inputCanton.Name = "inputCanton";
            this.inputCanton.Size = new System.Drawing.Size(320, 20);
            this.inputCanton.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Canton_id ";
            // 
            // inputParroquia
            // 
            this.inputParroquia.Location = new System.Drawing.Point(82, 31);
            this.inputParroquia.Name = "inputParroquia";
            this.inputParroquia.Size = new System.Drawing.Size(303, 20);
            this.inputParroquia.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Location = new System.Drawing.Point(7, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Parroquia_id ";
            // 
            // panelCanton
            // 
            this.panelCanton.BackColor = System.Drawing.Color.Teal;
            this.panelCanton.Controls.Add(this.inProviIdCan);
            this.panelCanton.Controls.Add(this.label1);
            this.panelCanton.Controls.Add(this.inCantonId);
            this.panelCanton.Controls.Add(this.label8);
            this.panelCanton.Controls.Add(this.inPoblaciCan);
            this.panelCanton.Controls.Add(this.inCodigoCan);
            this.panelCanton.Controls.Add(this.inNombreCan);
            this.panelCanton.Controls.Add(this.label10);
            this.panelCanton.Controls.Add(this.label11);
            this.panelCanton.Controls.Add(this.label12);
            this.panelCanton.Location = new System.Drawing.Point(25, 37);
            this.panelCanton.Name = "panelCanton";
            this.panelCanton.Size = new System.Drawing.Size(400, 167);
            this.panelCanton.TabIndex = 21;
            this.panelCanton.Visible = false;
            // 
            // inProviIdCan
            // 
            this.inProviIdCan.Location = new System.Drawing.Point(78, 69);
            this.inProviIdCan.Name = "inProviIdCan";
            this.inProviIdCan.Size = new System.Drawing.Size(307, 20);
            this.inProviIdCan.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(4, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Provincia_id ";
            // 
            // inCantonId
            // 
            this.inCantonId.Location = new System.Drawing.Point(65, 5);
            this.inCantonId.Name = "inCantonId";
            this.inCantonId.Size = new System.Drawing.Size(320, 20);
            this.inCantonId.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label8.Location = new System.Drawing.Point(4, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Canton_id ";
            // 
            // inPoblaciCan
            // 
            this.inPoblaciCan.Location = new System.Drawing.Point(65, 133);
            this.inPoblaciCan.Name = "inPoblaciCan";
            this.inPoblaciCan.Size = new System.Drawing.Size(320, 20);
            this.inPoblaciCan.TabIndex = 7;
            // 
            // inCodigoCan
            // 
            this.inCodigoCan.Location = new System.Drawing.Point(50, 101);
            this.inCodigoCan.Name = "inCodigoCan";
            this.inCodigoCan.Size = new System.Drawing.Size(335, 20);
            this.inCodigoCan.TabIndex = 6;
            // 
            // inNombreCan
            // 
            this.inNombreCan.Location = new System.Drawing.Point(50, 36);
            this.inNombreCan.Name = "inNombreCan";
            this.inNombreCan.Size = new System.Drawing.Size(335, 20);
            this.inNombreCan.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label10.Location = new System.Drawing.Point(7, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Poblacion ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label11.Location = new System.Drawing.Point(7, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Codigo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label12.Location = new System.Drawing.Point(4, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nombre";
            // 
            // panelParroquia
            // 
            this.panelParroquia.BackColor = System.Drawing.Color.Teal;
            this.panelParroquia.Controls.Add(this.label16);
            this.panelParroquia.Controls.Add(this.inCantonIdPar);
            this.panelParroquia.Controls.Add(this.label13);
            this.panelParroquia.Controls.Add(this.inParrId);
            this.panelParroquia.Controls.Add(this.txtparr);
            this.panelParroquia.Controls.Add(this.inTipoParr);
            this.panelParroquia.Controls.Add(this.inCodigoParr);
            this.panelParroquia.Controls.Add(this.inNombrePar);
            this.panelParroquia.Controls.Add(this.label17);
            this.panelParroquia.Controls.Add(this.label18);
            this.panelParroquia.Location = new System.Drawing.Point(25, 37);
            this.panelParroquia.Name = "panelParroquia";
            this.panelParroquia.Size = new System.Drawing.Size(400, 160);
            this.panelParroquia.TabIndex = 21;
            this.panelParroquia.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label16.Location = new System.Drawing.Point(7, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Tipo ";
            // 
            // inCantonIdPar
            // 
            this.inCantonIdPar.Location = new System.Drawing.Point(68, 69);
            this.inCantonIdPar.Name = "inCantonIdPar";
            this.inCantonIdPar.Size = new System.Drawing.Size(317, 20);
            this.inCantonIdPar.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label13.Location = new System.Drawing.Point(4, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Canton_id ";
            // 
            // inParrId
            // 
            this.inParrId.Location = new System.Drawing.Point(68, 5);
            this.inParrId.Name = "inParrId";
            this.inParrId.Size = new System.Drawing.Size(317, 20);
            this.inParrId.TabIndex = 15;
            // 
            // txtparr
            // 
            this.txtparr.AutoSize = true;
            this.txtparr.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.txtparr.Location = new System.Drawing.Point(4, 8);
            this.txtparr.Name = "txtparr";
            this.txtparr.Size = new System.Drawing.Size(69, 13);
            this.txtparr.TabIndex = 14;
            this.txtparr.Text = "Parroquia_id ";
            this.txtparr.Click += new System.EventHandler(this.label14_Click);
            // 
            // inTipoParr
            // 
            this.inTipoParr.Location = new System.Drawing.Point(54, 133);
            this.inTipoParr.Name = "inTipoParr";
            this.inTipoParr.Size = new System.Drawing.Size(331, 20);
            this.inTipoParr.TabIndex = 7;
            // 
            // inCodigoParr
            // 
            this.inCodigoParr.Location = new System.Drawing.Point(50, 101);
            this.inCodigoParr.Name = "inCodigoParr";
            this.inCodigoParr.Size = new System.Drawing.Size(335, 20);
            this.inCodigoParr.TabIndex = 6;
            // 
            // inNombrePar
            // 
            this.inNombrePar.Location = new System.Drawing.Point(50, 36);
            this.inNombrePar.Name = "inNombrePar";
            this.inNombrePar.Size = new System.Drawing.Size(335, 20);
            this.inNombrePar.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label17.Location = new System.Drawing.Point(7, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Codigo ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label18.Location = new System.Drawing.Point(4, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Nombre";
            // 
            // bSelectAll
            // 
            this.bSelectAll.Location = new System.Drawing.Point(250, 249);
            this.bSelectAll.Name = "bSelectAll";
            this.bSelectAll.Size = new System.Drawing.Size(75, 23);
            this.bSelectAll.TabIndex = 22;
            this.bSelectAll.Text = "Select(*)";
            this.bSelectAll.UseVisualStyleBackColor = true;
            this.bSelectAll.Click += new System.EventHandler(this.bSelectAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem1,
            this.fToolStripMenuItem2,
            this.cantonToolStripMenuItem});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.fToolStripMenuItem.Text = "Eliga la tabla";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem1
            // 
            this.fToolStripMenuItem1.Name = "fToolStripMenuItem1";
            this.fToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.fToolStripMenuItem1.Text = "Provincia";
            this.fToolStripMenuItem1.Click += new System.EventHandler(this.fToolStripMenuItem1_Click);
            // 
            // fToolStripMenuItem2
            // 
            this.fToolStripMenuItem2.Name = "fToolStripMenuItem2";
            this.fToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.fToolStripMenuItem2.Text = "Parroquia";
            this.fToolStripMenuItem2.Click += new System.EventHandler(this.fToolStripMenuItem2_Click);
            // 
            // cantonToolStripMenuItem
            // 
            this.cantonToolStripMenuItem.Name = "cantonToolStripMenuItem";
            this.cantonToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cantonToolStripMenuItem.Text = "Canton";
            this.cantonToolStripMenuItem.Click += new System.EventHandler(this.cantonToolStripMenuItem_Click);
            // 
            // panelProvincia
            // 
            this.panelProvincia.BackColor = System.Drawing.Color.Teal;
            this.panelProvincia.Controls.Add(this.txtCodigoProvincia);
            this.panelProvincia.Controls.Add(this.txtCodigoPr);
            this.panelProvincia.Controls.Add(this.txtIdPr);
            this.panelProvincia.Controls.Add(this.txtProvinciaId);
            this.panelProvincia.Controls.Add(this.txtRegionProv);
            this.panelProvincia.Controls.Add(this.txtNombreProvincia);
            this.panelProvincia.Controls.Add(this.txtRegionPr);
            this.panelProvincia.Controls.Add(this.txtNombrePr);
            this.panelProvincia.Location = new System.Drawing.Point(25, 37);
            this.panelProvincia.Name = "panelProvincia";
            this.panelProvincia.Size = new System.Drawing.Size(400, 133);
            this.panelProvincia.TabIndex = 20;
            this.panelProvincia.Visible = false;
            // 
            // txtCodigoProvincia
            // 
            this.txtCodigoProvincia.Location = new System.Drawing.Point(50, 69);
            this.txtCodigoProvincia.Name = "txtCodigoProvincia";
            this.txtCodigoProvincia.Size = new System.Drawing.Size(335, 20);
            this.txtCodigoProvincia.TabIndex = 17;
            // 
            // txtCodigoPr
            // 
            this.txtCodigoPr.AutoSize = true;
            this.txtCodigoPr.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.txtCodigoPr.Location = new System.Drawing.Point(4, 72);
            this.txtCodigoPr.Name = "txtCodigoPr";
            this.txtCodigoPr.Size = new System.Drawing.Size(40, 13);
            this.txtCodigoPr.TabIndex = 16;
            this.txtCodigoPr.Text = "Codigo";
            this.txtCodigoPr.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // txtIdPr
            // 
            this.txtIdPr.Location = new System.Drawing.Point(68, 5);
            this.txtIdPr.Name = "txtIdPr";
            this.txtIdPr.Size = new System.Drawing.Size(317, 20);
            this.txtIdPr.TabIndex = 15;
            // 
            // txtProvinciaId
            // 
            this.txtProvinciaId.AutoSize = true;
            this.txtProvinciaId.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.txtProvinciaId.Location = new System.Drawing.Point(4, 8);
            this.txtProvinciaId.Name = "txtProvinciaId";
            this.txtProvinciaId.Size = new System.Drawing.Size(68, 13);
            this.txtProvinciaId.TabIndex = 14;
            this.txtProvinciaId.Text = "Provincia_id ";
            this.txtProvinciaId.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtRegionProv
            // 
            this.txtRegionProv.Location = new System.Drawing.Point(50, 101);
            this.txtRegionProv.Name = "txtRegionProv";
            this.txtRegionProv.Size = new System.Drawing.Size(335, 20);
            this.txtRegionProv.TabIndex = 6;
            // 
            // txtNombreProvincia
            // 
            this.txtNombreProvincia.Location = new System.Drawing.Point(50, 36);
            this.txtNombreProvincia.Name = "txtNombreProvincia";
            this.txtNombreProvincia.Size = new System.Drawing.Size(335, 20);
            this.txtNombreProvincia.TabIndex = 5;
            // 
            // txtRegionPr
            // 
            this.txtRegionPr.AutoSize = true;
            this.txtRegionPr.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.txtRegionPr.Location = new System.Drawing.Point(7, 104);
            this.txtRegionPr.Name = "txtRegionPr";
            this.txtRegionPr.Size = new System.Drawing.Size(44, 13);
            this.txtRegionPr.TabIndex = 2;
            this.txtRegionPr.Text = "Region ";
            // 
            // txtNombrePr
            // 
            this.txtNombrePr.AutoSize = true;
            this.txtNombrePr.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.txtNombrePr.Location = new System.Drawing.Point(4, 39);
            this.txtNombrePr.Name = "txtNombrePr";
            this.txtNombrePr.Size = new System.Drawing.Size(44, 13);
            this.txtNombrePr.TabIndex = 1;
            this.txtNombrePr.Text = "Nombre";
            // 
            // PanelSelect
            // 
            this.PanelSelect.Controls.Add(this.bRegresarSelect);
            this.PanelSelect.Controls.Add(this.tablaSelect);
            this.PanelSelect.Location = new System.Drawing.Point(49, 124);
            this.PanelSelect.Name = "PanelSelect";
            this.PanelSelect.Size = new System.Drawing.Size(855, 357);
            this.PanelSelect.TabIndex = 16;
            this.PanelSelect.Visible = false;
            // 
            // bRegresarSelect
            // 
            this.bRegresarSelect.Location = new System.Drawing.Point(402, 315);
            this.bRegresarSelect.Name = "bRegresarSelect";
            this.bRegresarSelect.Size = new System.Drawing.Size(75, 23);
            this.bRegresarSelect.TabIndex = 1;
            this.bRegresarSelect.Text = "Regresar";
            this.bRegresarSelect.UseVisualStyleBackColor = true;
            this.bRegresarSelect.Click += new System.EventHandler(this.bRegresarSelect_Click);
            // 
            // tablaSelect
            // 
            this.tablaSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSelect.Location = new System.Drawing.Point(21, 26);
            this.tablaSelect.Name = "tablaSelect";
            this.tablaSelect.Size = new System.Drawing.Size(808, 283);
            this.tablaSelect.TabIndex = 0;
            this.tablaSelect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Oracle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.bBack;
            this.ClientSize = new System.Drawing.Size(944, 522);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelSelect);
            this.Controls.Add(this.bBack);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Oracle";
            this.Text = "Oracle_DataBase";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelCanton.ResumeLayout(false);
            this.panelCanton.PerformLayout();
            this.panelParroquia.ResumeLayout(false);
            this.panelParroquia.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelProvincia.ResumeLayout(false);
            this.panelProvincia.PerformLayout();
            this.PanelSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bInsertar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel PanelSelect;
        private System.Windows.Forms.DataGridView tablaSelect;
        private System.Windows.Forms.Button bRegresarSelect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cantonToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Panel panelProvincia;
        private System.Windows.Forms.TextBox txtCodigoProvincia;
        private System.Windows.Forms.Label txtCodigoPr;
        private System.Windows.Forms.TextBox txtIdPr;
        private System.Windows.Forms.Label txtProvinciaId;
        private System.Windows.Forms.TextBox txtRegionProv;
        private System.Windows.Forms.TextBox txtNombreProvincia;
        private System.Windows.Forms.Label txtRegionPr;
        private System.Windows.Forms.Label txtNombrePr;
        private System.Windows.Forms.Panel panelCanton;
        private System.Windows.Forms.TextBox inProviIdCan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inCantonId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inPoblaciCan;
        private System.Windows.Forms.TextBox inCodigoCan;
        private System.Windows.Forms.TextBox inNombreCan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelParroquia;
        private System.Windows.Forms.TextBox inCantonIdPar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox inParrId;
        private System.Windows.Forms.Label txtparr;
        private System.Windows.Forms.TextBox inTipoParr;
        private System.Windows.Forms.TextBox inCodigoParr;
        private System.Windows.Forms.TextBox inNombrePar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button bSelectAll;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Button bBuscarTablas;
        private System.Windows.Forms.TextBox inputProvincia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputCanton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputParroquia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bRegresarBusqueda;
    }
}
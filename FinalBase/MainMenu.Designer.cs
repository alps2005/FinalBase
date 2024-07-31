namespace FinalBase
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oraclToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postgresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLserverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(994, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mySQLToolStripMenuItem,
            this.oraclToolStripMenuItem,
            this.postgresToolStripMenuItem,
            this.sQLserverToolStripMenuItem});
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.baseDeDatosToolStripMenuItem.Text = "Base de Datos";
            // 
            // mySQLToolStripMenuItem
            // 
            this.mySQLToolStripMenuItem.Name = "mySQLToolStripMenuItem";
            this.mySQLToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.mySQLToolStripMenuItem.Text = "MySQL";
            this.mySQLToolStripMenuItem.Click += new System.EventHandler(this.mySQLToolStripMenuItem_Click);
            // 
            // oraclToolStripMenuItem
            // 
            this.oraclToolStripMenuItem.Name = "oraclToolStripMenuItem";
            this.oraclToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.oraclToolStripMenuItem.Text = "Oracle";
            this.oraclToolStripMenuItem.Click += new System.EventHandler(this.oraclToolStripMenuItem_Click);
            // 
            // postgresToolStripMenuItem
            // 
            this.postgresToolStripMenuItem.Name = "postgresToolStripMenuItem";
            this.postgresToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.postgresToolStripMenuItem.Text = "PostgresSQL";
            this.postgresToolStripMenuItem.Click += new System.EventHandler(this.postgresToolStripMenuItem_Click_1);
            // 
            // sQLserverToolStripMenuItem
            // 
            this.sQLserverToolStripMenuItem.Name = "sQLserverToolStripMenuItem";
            this.sQLserverToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.sQLserverToolStripMenuItem.Text = "SQLserver";
            this.sQLserverToolStripMenuItem.Click += new System.EventHandler(this.sQLserverToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(238, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROYECTO BASE DE DATOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(51, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "INTEGRANTES:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Mateo Rubio",
            "Fransua Cordero",
            "Josue",
            "Adrian Palma",
            "Jostin Coronel"});
            this.listBox1.Location = new System.Drawing.Point(12, 196);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 104);
            this.listBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(386, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "DOCENTE:";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "Christian Robert Anton Cedeño"});
            this.listBox2.Location = new System.Drawing.Point(327, 196);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(255, 104);
            this.listBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(742, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "GUIA:";
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Items.AddRange(new object[] {
            "Para utilizar el programa eliga una ",
            "base de datos utilizando el MenuStrip ubicado en la",
            "esquina superior izquierda de la ventana.",
            "Opciones que tendra:",
            "- MySQL",
            "- PostgreSQL",
            "- Oracle",
            "- SQL Server"});
            this.listBox3.Location = new System.Drawing.Point(630, 196);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(352, 104);
            this.listBox3.TabIndex = 7;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(994, 536);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oraclToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postgresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLserverToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox3;
    }
}


namespace FinalBase
{
    partial class MySQL
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_parroquias = new System.Windows.Forms.Button();
            this.btn_cantones = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Provincias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_parroquias
            // 
            this.btn_parroquias.Location = new System.Drawing.Point(288, 158);
            this.btn_parroquias.Name = "btn_parroquias";
            this.btn_parroquias.Size = new System.Drawing.Size(177, 89);
            this.btn_parroquias.TabIndex = 1;
            this.btn_parroquias.Text = "Parroquias";
            this.btn_parroquias.UseVisualStyleBackColor = true;
            this.btn_parroquias.Click += new System.EventHandler(this.btn_parroquias_Click);
            // 
            // btn_cantones
            // 
            this.btn_cantones.Location = new System.Drawing.Point(547, 158);
            this.btn_cantones.Name = "btn_cantones";
            this.btn_cantones.Size = new System.Drawing.Size(175, 89);
            this.btn_cantones.TabIndex = 2;
            this.btn_cantones.Text = "Cantones";
            this.btn_cantones.UseVisualStyleBackColor = true;
            this.btn_cantones.Click += new System.EventHandler(this.btn_cantones_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(308, 333);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(139, 47);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenido a Consultas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_cantones);
            this.Controls.Add(this.btn_parroquias);
            this.Controls.Add(this.button1);
            this.Name = "MySQL";
            this.Text = "MySQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_parroquias;
        private System.Windows.Forms.Button btn_cantones;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label1;
    }
}


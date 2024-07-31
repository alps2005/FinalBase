namespace FinalBase
{
    partial class Postgres
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
            this.txt_provincias = new System.Windows.Forms.TextBox();
            this.txt_cantones = new System.Windows.Forms.TextBox();
            this.txt_parroquias = new System.Windows.Forms.TextBox();
            this.labelProvincias = new System.Windows.Forms.Label();
            this.labelCantones = new System.Windows.Forms.Label();
            this.labelParroquias = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_provincias
            // 
            this.txt_provincias.Location = new System.Drawing.Point(120, 12);
            this.txt_provincias.Name = "txt_provincias";
            this.txt_provincias.Size = new System.Drawing.Size(200, 20);
            this.txt_provincias.TabIndex = 0;
            // 
            // txt_cantones
            // 
            this.txt_cantones.Location = new System.Drawing.Point(120, 64);
            this.txt_cantones.Name = "txt_cantones";
            this.txt_cantones.Size = new System.Drawing.Size(200, 20);
            this.txt_cantones.TabIndex = 2;
            // 
            // txt_parroquias
            // 
            this.txt_parroquias.Location = new System.Drawing.Point(120, 116);
            this.txt_parroquias.Name = "txt_parroquias";
            this.txt_parroquias.Size = new System.Drawing.Size(200, 20);
            this.txt_parroquias.TabIndex = 4;
            // 
            // labelProvincias
            // 
            this.labelProvincias.AutoSize = true;
            this.labelProvincias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelProvincias.Location = new System.Drawing.Point(38, 12);
            this.labelProvincias.Name = "labelProvincias";
            this.labelProvincias.Size = new System.Drawing.Size(76, 20);
            this.labelProvincias.TabIndex = 6;
            this.labelProvincias.Text = "Provincia:";
            // 
            // labelCantones
            // 
            this.labelCantones.AutoSize = true;
            this.labelCantones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCantones.Location = new System.Drawing.Point(49, 64);
            this.labelCantones.Name = "labelCantones";
            this.labelCantones.Size = new System.Drawing.Size(65, 20);
            this.labelCantones.TabIndex = 8;
            this.labelCantones.Text = "Canton:";
            // 
            // labelParroquias
            // 
            this.labelParroquias.AutoSize = true;
            this.labelParroquias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelParroquias.Location = new System.Drawing.Point(33, 116);
            this.labelParroquias.Name = "labelParroquias";
            this.labelParroquias.Size = new System.Drawing.Size(81, 20);
            this.labelParroquias.TabIndex = 10;
            this.labelParroquias.Text = "Parroquia:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(24, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(116, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(204, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Aqua;
            this.button4.Location = new System.Drawing.Point(296, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Actualizar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(393, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Cerrar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Postgres
            // 
            this.ClientSize = new System.Drawing.Size(504, 217);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelParroquias);
            this.Controls.Add(this.labelCantones);
            this.Controls.Add(this.labelProvincias);
            this.Controls.Add(this.txt_parroquias);
            this.Controls.Add(this.txt_cantones);
            this.Controls.Add(this.txt_provincias);
            this.Name = "Postgres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txt_provincias;
        private System.Windows.Forms.TextBox txt_cantones;
        private System.Windows.Forms.TextBox txt_parroquias;
        private System.Windows.Forms.Label labelProvincias;
        private System.Windows.Forms.Label labelCantones;
        private System.Windows.Forms.Label labelParroquias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;

        #endregion
    }
}
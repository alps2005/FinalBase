namespace FinalBase
{
    partial class ID_SearchPostgres
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(179, 77);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(123, 20);
            this.txt_id.TabIndex = 0;
            // 
            // label_id
            // 
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_id.Location = new System.Drawing.Point(88, 43);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(321, 22);
            this.label_id.TabIndex = 6;
            this.label_id.Text = " Ingrese el ID del registro que quiere ver:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Location = new System.Drawing.Point(78, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(317, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 76);
            this.dataGridView1.TabIndex = 14;
            // 
            // ID_SearchPostgres
            // 
            this.ClientSize = new System.Drawing.Size(497, 303);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ID_SearchPostgres";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
namespace FinalBase
{
    partial class EditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.ComboBox comboBoxEntityType;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxList;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelEdit = new System.Windows.Forms.Label();
            this.comboBoxEntityType = new System.Windows.Forms.ComboBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxList = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxCantones = new System.Windows.Forms.ComboBox();
            this.comboBoxProvincias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.Location = new System.Drawing.Point(13, 13);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(57, 20);
            this.labelEdit.TabIndex = 0;
            this.labelEdit.Text = "Editar";
            // 
            // comboBoxEntityType
            // 
            this.comboBoxEntityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEntityType.FormattingEnabled = true;
            this.comboBoxEntityType.Location = new System.Drawing.Point(17, 50);
            this.comboBoxEntityType.Name = "comboBoxEntityType";
            this.comboBoxEntityType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxEntityType.TabIndex = 1;
            this.comboBoxEntityType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEntityType_SelectedIndexChanged);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(17, 80);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 13);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(80, 77);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(17, 107);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Nuevo Nombre:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(106, 104);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(17, 130);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Cargar";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(205, 130);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxList
            // 
            this.comboBoxList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxList.FormattingEnabled = true;
            this.comboBoxList.Location = new System.Drawing.Point(17, 160);
            this.comboBoxList.Name = "comboBoxList";
            this.comboBoxList.Size = new System.Drawing.Size(200, 21);
            this.comboBoxList.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 398);
            this.dataGridView1.TabIndex = 11;
            // 
            // comboBoxCantones
            // 
            this.comboBoxCantones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCantones.FormattingEnabled = true;
            this.comboBoxCantones.Location = new System.Drawing.Point(17, 230);
            this.comboBoxCantones.Name = "comboBoxCantones";
            this.comboBoxCantones.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCantones.TabIndex = 10;
            this.comboBoxCantones.SelectedIndexChanged += new System.EventHandler(this.comboBoxCantones_SelectedIndexChanged);
            // 
            // comboBoxProvincias
            // 
            this.comboBoxProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvincias.FormattingEnabled = true;
            this.comboBoxProvincias.Location = new System.Drawing.Point(17, 200);
            this.comboBoxProvincias.Name = "comboBoxProvincias";
            this.comboBoxProvincias.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProvincias.TabIndex = 9;
            this.comboBoxProvincias.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvincias_SelectedIndexChanged);
            // 
            // EditForm
            // 
            this.ClientSize = new System.Drawing.Size(715, 423);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxCantones);
            this.Controls.Add(this.comboBoxProvincias);
            this.Controls.Add(this.comboBoxList);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.comboBoxEntityType);
            this.Controls.Add(this.labelEdit);
            this.Name = "EditForm";
            this.Text = "Editar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox comboBoxCantones;
        private System.Windows.Forms.ComboBox comboBoxProvincias;
    }
}
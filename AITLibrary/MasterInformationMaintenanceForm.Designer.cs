namespace AITLibrary
{
    partial class MasterInformationMaintenanceForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelSelectInformation = new System.Windows.Forms.Label();
            this.buttonList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.groupBoxInformationMaintenance = new System.Windows.Forms.GroupBox();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.radioUpdate = new System.Windows.Forms.RadioButton();
            this.radioInsert = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxInformationMaintenance.SuspendLayout();
            this.SuspendLayout();

            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // labelSelectInformation
            // 
            this.labelSelectInformation.AutoSize = true;
            this.labelSelectInformation.Location = new System.Drawing.Point(12, 39);
            this.labelSelectInformation.Name = "labelSelectInformation";
            this.labelSelectInformation.Size = new System.Drawing.Size(109, 13);
            this.labelSelectInformation.TabIndex = 3;
            this.labelSelectInformation.Text = "Select the information";
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(135, 85);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(75, 23);
            this.buttonList.TabIndex = 4;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(650, 194);
            this.dataGridView1.TabIndex = 5;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(204, 98);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 7;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            // 
            // groupBoxInformationMaintenance
            // 
            this.groupBoxInformationMaintenance.Controls.Add(this.radioButtonDelete);
            this.groupBoxInformationMaintenance.Controls.Add(this.radioUpdate);
            this.groupBoxInformationMaintenance.Controls.Add(this.radioInsert);
            this.groupBoxInformationMaintenance.Controls.Add(this.textBoxName);
            this.groupBoxInformationMaintenance.Controls.Add(this.labelName);
            this.groupBoxInformationMaintenance.Controls.Add(this.buttonExecute);
            this.groupBoxInformationMaintenance.Location = new System.Drawing.Point(12, 114);
            this.groupBoxInformationMaintenance.Name = "groupBoxInformationMaintenance";
            this.groupBoxInformationMaintenance.Size = new System.Drawing.Size(297, 138);
            this.groupBoxInformationMaintenance.TabIndex = 8;
            this.groupBoxInformationMaintenance.TabStop = false;
            this.groupBoxInformationMaintenance.Text = "Information  Maintenance ";
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(223, 47);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(56, 17);
            this.radioButtonDelete.TabIndex = 12;
            this.radioButtonDelete.TabStop = true;
            this.radioButtonDelete.Text = "Delete";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            // 
            // radioUpdate
            // 
            this.radioUpdate.AutoSize = true;
            this.radioUpdate.Location = new System.Drawing.Point(138, 47);
            this.radioUpdate.Name = "radioUpdate";
            this.radioUpdate.Size = new System.Drawing.Size(60, 17);
            this.radioUpdate.TabIndex = 11;
            this.radioUpdate.TabStop = true;
            this.radioUpdate.Text = "Update";
            this.radioUpdate.UseVisualStyleBackColor = true;
            // 
            // radioInsert
            // 
            this.radioInsert.AutoSize = true;
            this.radioInsert.Location = new System.Drawing.Point(49, 47);
            this.radioInsert.Name = "radioInsert";
            this.radioInsert.Size = new System.Drawing.Size(51, 17);
            this.radioInsert.TabIndex = 10;
            this.radioInsert.TabStop = true;
            this.radioInsert.Text = "Insert";
            this.radioInsert.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(49, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(230, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // MasterInformationMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.groupBoxInformationMaintenance);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.labelSelectInformation);
            this.Controls.Add(this.comboBox1);
            this.Name = "MasterInformationMaintenanceForm";
            this.Text = "MasterInformationMaintenanceForm";

            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.labelSelectInformation, 0);
            this.Controls.SetChildIndex(this.buttonList, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.groupBoxInformationMaintenance, 0);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxInformationMaintenance.ResumeLayout(false);
            this.groupBoxInformationMaintenance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelSelectInformation;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.GroupBox groupBoxInformationMaintenance;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioUpdate;
        private System.Windows.Forms.RadioButton radioInsert;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;

    }
}
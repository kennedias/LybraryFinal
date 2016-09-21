namespace AITLibrary
{
    partial class UserMaintenanceForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxStudentSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearchStudent = new System.Windows.Forms.Button();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.labelOrStudentSearch = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelSearchStudentby = new System.Windows.Forms.Label();
            this.groupBoxUserMaintenance = new System.Windows.Forms.GroupBox();
            this.comboBoxUserLevel = new System.Windows.Forms.ComboBox();
            this.labelUserLevel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.radioUpdate = new System.Windows.Forms.RadioButton();
            this.radioInsert = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxStudentSearch.SuspendLayout();
            this.groupBoxUserMaintenance.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(817, 134);
            this.dataGridView1.TabIndex = 15;
            // 
            // groupBoxStudentSearch
            // 
            this.groupBoxStudentSearch.Controls.Add(this.buttonSearchStudent);
            this.groupBoxStudentSearch.Controls.Add(this.textBoxStudentId);
            this.groupBoxStudentSearch.Controls.Add(this.labelStudentId);
            this.groupBoxStudentSearch.Controls.Add(this.textBoxStudentName);
            this.groupBoxStudentSearch.Controls.Add(this.labelOrStudentSearch);
            this.groupBoxStudentSearch.Controls.Add(this.labelStudentName);
            this.groupBoxStudentSearch.Controls.Add(this.labelSearchStudentby);
            this.groupBoxStudentSearch.Location = new System.Drawing.Point(11, 44);
            this.groupBoxStudentSearch.Name = "groupBoxStudentSearch";
            this.groupBoxStudentSearch.Size = new System.Drawing.Size(214, 134);
            this.groupBoxStudentSearch.TabIndex = 14;
            this.groupBoxStudentSearch.TabStop = false;
            this.groupBoxStudentSearch.Text = "Student Search";
            // 
            // buttonSearchStudent
            // 
            this.buttonSearchStudent.Location = new System.Drawing.Point(104, 103);
            this.buttonSearchStudent.Name = "buttonSearchStudent";
            this.buttonSearchStudent.Size = new System.Drawing.Size(102, 23);
            this.buttonSearchStudent.TabIndex = 14;
            this.buttonSearchStudent.Text = "Search";
            this.buttonSearchStudent.UseVisualStyleBackColor = true;
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Location = new System.Drawing.Point(70, 36);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(136, 20);
            this.textBoxStudentId.TabIndex = 8;
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Location = new System.Drawing.Point(50, 39);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(18, 13);
            this.labelStudentId.TabIndex = 13;
            this.labelStudentId.Text = "ID";
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(70, 77);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(136, 20);
            this.textBoxStudentName.TabIndex = 12;
            // 
            // labelOrStudentSearch
            // 
            this.labelOrStudentSearch.AutoSize = true;
            this.labelOrStudentSearch.Location = new System.Drawing.Point(69, 59);
            this.labelOrStudentSearch.Name = "labelOrStudentSearch";
            this.labelOrStudentSearch.Size = new System.Drawing.Size(16, 13);
            this.labelOrStudentSearch.TabIndex = 11;
            this.labelOrStudentSearch.Text = "or";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(33, 80);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(35, 13);
            this.labelStudentName.TabIndex = 9;
            this.labelStudentName.Text = "Name";
            // 
            // labelSearchStudentby
            // 
            this.labelSearchStudentby.AutoSize = true;
            this.labelSearchStudentby.Location = new System.Drawing.Point(6, 16);
            this.labelSearchStudentby.Name = "labelSearchStudentby";
            this.labelSearchStudentby.Size = new System.Drawing.Size(98, 13);
            this.labelSearchStudentby.TabIndex = 8;
            this.labelSearchStudentby.Text = "Search Student by:";
            // 
            // groupBoxUserMaintenance
            // 
            this.groupBoxUserMaintenance.Controls.Add(this.comboBoxUserLevel);
            this.groupBoxUserMaintenance.Controls.Add(this.labelUserLevel);
            this.groupBoxUserMaintenance.Controls.Add(this.textBox2);
            this.groupBoxUserMaintenance.Controls.Add(this.labelConfirmPassword);
            this.groupBoxUserMaintenance.Controls.Add(this.textBox1);
            this.groupBoxUserMaintenance.Controls.Add(this.labelPassword);
            this.groupBoxUserMaintenance.Controls.Add(this.radioButtonDelete);
            this.groupBoxUserMaintenance.Controls.Add(this.radioUpdate);
            this.groupBoxUserMaintenance.Controls.Add(this.radioInsert);
            this.groupBoxUserMaintenance.Controls.Add(this.textBoxName);
            this.groupBoxUserMaintenance.Controls.Add(this.labelName);
            this.groupBoxUserMaintenance.Controls.Add(this.buttonExecute);
            this.groupBoxUserMaintenance.Location = new System.Drawing.Point(235, 197);
            this.groupBoxUserMaintenance.Name = "groupBoxUserMaintenance";
            this.groupBoxUserMaintenance.Size = new System.Drawing.Size(448, 197);
            this.groupBoxUserMaintenance.TabIndex = 16;
            this.groupBoxUserMaintenance.TabStop = false;
            this.groupBoxUserMaintenance.Text = "User Maintenance ";
            // 
            // comboBoxUserLevel
            // 
            this.comboBoxUserLevel.FormattingEnabled = true;
            this.comboBoxUserLevel.Items.AddRange(new object[] {
            "Administrator",
            "Supervisor",
            "User"});
            this.comboBoxUserLevel.Location = new System.Drawing.Point(105, 128);
            this.comboBoxUserLevel.Name = "comboBoxUserLevel";
            this.comboBoxUserLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUserLevel.TabIndex = 18;
            // 
            // labelUserLevel
            // 
            this.labelUserLevel.AutoSize = true;
            this.labelUserLevel.Location = new System.Drawing.Point(42, 133);
            this.labelUserLevel.Name = "labelUserLevel";
            this.labelUserLevel.Size = new System.Drawing.Size(58, 13);
            this.labelUserLevel.TabIndex = 17;
            this.labelUserLevel.Text = "User Level";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 20);
            this.textBox2.TabIndex = 16;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Location = new System.Drawing.Point(8, 96);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.labelConfirmPassword.TabIndex = 15;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 14;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(46, 59);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Password";
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(291, 168);
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
            this.radioUpdate.Location = new System.Drawing.Point(206, 168);
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
            this.radioInsert.Location = new System.Drawing.Point(117, 168);
            this.radioInsert.Name = "radioInsert";
            this.radioInsert.Size = new System.Drawing.Size(51, 17);
            this.radioInsert.TabIndex = 10;
            this.radioInsert.TabStop = true;
            this.radioInsert.Text = "Insert";
            this.radioInsert.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(105, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(230, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(64, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(367, 168);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 7;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            // 
            // UserMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 487);
            this.Controls.Add(this.groupBoxUserMaintenance);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxStudentSearch);
            this.Name = "UserMaintenanceForm";
            this.Text = "UserMaintenanceForm";
            this.Controls.SetChildIndex(this.groupBoxStudentSearch, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.groupBoxUserMaintenance, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxStudentSearch.ResumeLayout(false);
            this.groupBoxStudentSearch.PerformLayout();
            this.groupBoxUserMaintenance.ResumeLayout(false);
            this.groupBoxUserMaintenance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxStudentSearch;
        private System.Windows.Forms.Button buttonSearchStudent;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label labelOrStudentSearch;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelSearchStudentby;
        private System.Windows.Forms.GroupBox groupBoxUserMaintenance;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioUpdate;
        private System.Windows.Forms.RadioButton radioInsert;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.ComboBox comboBoxUserLevel;
        private System.Windows.Forms.Label labelUserLevel;
    }
}
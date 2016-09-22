namespace AITLibrary
{
    partial class BookMaintenanceForm
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
            this.groupBoxUserMaintenance = new System.Windows.Forms.GroupBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.labelPages = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxISBNMaintenace = new System.Windows.Forms.TextBox();
            this.textBoxNameMaintenance = new System.Windows.Forms.TextBox();
            this.labelNameMaintenance = new System.Windows.Forms.Label();
            this.labelISBNMaintenance = new System.Windows.Forms.Label();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.radioUpdate = new System.Windows.Forms.RadioButton();
            this.radioInsert = new System.Windows.Forms.RadioButton();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxBookSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearchStudent = new System.Windows.Forms.Button();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.labelOrStudentSearch = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelSearchStudentby = new System.Windows.Forms.Label();
            
            this.groupBoxUserMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxBookSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSystemMessage
            // 
            
            // 
            // groupBoxUserMaintenance
            // 
            this.groupBoxUserMaintenance.Controls.Add(this.textBoxPublisher);
            this.groupBoxUserMaintenance.Controls.Add(this.labelPublisher);
            this.groupBoxUserMaintenance.Controls.Add(this.textBoxPages);
            this.groupBoxUserMaintenance.Controls.Add(this.labelPages);
            this.groupBoxUserMaintenance.Controls.Add(this.comboBoxLanguage);
            this.groupBoxUserMaintenance.Controls.Add(this.labelLanguage);
            this.groupBoxUserMaintenance.Controls.Add(this.comboBoxCategory);
            this.groupBoxUserMaintenance.Controls.Add(this.labelCategory);
            this.groupBoxUserMaintenance.Controls.Add(this.comboBoxAuthor);
            this.groupBoxUserMaintenance.Controls.Add(this.labelAuthor);
            this.groupBoxUserMaintenance.Controls.Add(this.textBoxYear);
            this.groupBoxUserMaintenance.Controls.Add(this.labelYear);
            this.groupBoxUserMaintenance.Controls.Add(this.textBoxISBNMaintenace);
            this.groupBoxUserMaintenance.Controls.Add(this.textBoxNameMaintenance);
            this.groupBoxUserMaintenance.Controls.Add(this.labelNameMaintenance);
            this.groupBoxUserMaintenance.Controls.Add(this.labelISBNMaintenance);
            this.groupBoxUserMaintenance.Controls.Add(this.radioButtonDelete);
            this.groupBoxUserMaintenance.Controls.Add(this.radioUpdate);
            this.groupBoxUserMaintenance.Controls.Add(this.radioInsert);
            this.groupBoxUserMaintenance.Controls.Add(this.buttonExecute);
            this.groupBoxUserMaintenance.Location = new System.Drawing.Point(242, 189);
            this.groupBoxUserMaintenance.Name = "groupBoxUserMaintenance";
            this.groupBoxUserMaintenance.Size = new System.Drawing.Size(666, 197);
            this.groupBoxUserMaintenance.TabIndex = 19;
            this.groupBoxUserMaintenance.TabStop = false;
            this.groupBoxUserMaintenance.Text = "Book Maintenance ";
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(386, 106);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(230, 20);
            this.textBoxPublisher.TabIndex = 26;
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(335, 109);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(50, 13);
            this.labelPublisher.TabIndex = 25;
            this.labelPublisher.Text = "Publisher";
            // 
            // textBoxPages
            // 
            this.textBoxPages.Location = new System.Drawing.Point(386, 78);
            this.textBoxPages.MaxLength = 5;
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(41, 20);
            this.textBoxPages.TabIndex = 24;
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(346, 81);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(37, 13);
            this.labelPages.TabIndex = 23;
            this.labelPages.Text = "Pages";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "Administrator",
            "Supervisor",
            "User"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(105, 105);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLanguage.TabIndex = 22;
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(51, 108);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(55, 13);
            this.labelLanguage.TabIndex = 21;
            this.labelLanguage.Text = "Language";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Administrator",
            "Supervisor",
            "User"});
            this.comboBoxCategory.Location = new System.Drawing.Point(105, 78);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 20;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(55, 81);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(49, 13);
            this.labelCategory.TabIndex = 19;
            this.labelCategory.Text = "Category";
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Items.AddRange(new object[] {
            "Administrator",
            "Supervisor",
            "User"});
            this.comboBoxAuthor.Location = new System.Drawing.Point(105, 51);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAuthor.TabIndex = 18;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(65, 54);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 17;
            this.labelAuthor.Text = "Author";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(386, 52);
            this.textBoxYear.MaxLength = 4;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(41, 20);
            this.textBoxYear.TabIndex = 16;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(351, 55);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 13);
            this.labelYear.TabIndex = 15;
            this.labelYear.Text = "Year";
            // 
            // textBoxISBNMaintenace
            // 
            this.textBoxISBNMaintenace.Location = new System.Drawing.Point(103, 25);
            this.textBoxISBNMaintenace.Name = "textBoxISBNMaintenace";
            this.textBoxISBNMaintenace.Size = new System.Drawing.Size(230, 20);
            this.textBoxISBNMaintenace.TabIndex = 14;
            // 
            // textBoxNameMaintenance
            // 
            this.textBoxNameMaintenance.Location = new System.Drawing.Point(386, 25);
            this.textBoxNameMaintenance.Name = "textBoxNameMaintenance";
            this.textBoxNameMaintenance.Size = new System.Drawing.Size(230, 20);
            this.textBoxNameMaintenance.TabIndex = 9;
            // 
            // labelNameMaintenance
            // 
            this.labelNameMaintenance.AutoSize = true;
            this.labelNameMaintenance.Location = new System.Drawing.Point(345, 28);
            this.labelNameMaintenance.Name = "labelNameMaintenance";
            this.labelNameMaintenance.Size = new System.Drawing.Size(35, 13);
            this.labelNameMaintenance.TabIndex = 8;
            this.labelNameMaintenance.Text = "Name";
            // 
            // labelISBNMaintenance
            // 
            this.labelISBNMaintenance.AutoSize = true;
            this.labelISBNMaintenance.Location = new System.Drawing.Point(65, 28);
            this.labelISBNMaintenance.Name = "labelISBNMaintenance";
            this.labelISBNMaintenance.Size = new System.Drawing.Size(32, 13);
            this.labelISBNMaintenance.TabIndex = 13;
            this.labelISBNMaintenance.Text = "ISBN";
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
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(367, 168);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 7;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(242, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(730, 134);
            this.dataGridView1.TabIndex = 18;
            // 
            // groupBoxBookSearch
            // 
            this.groupBoxBookSearch.Controls.Add(this.buttonSearchStudent);
            this.groupBoxBookSearch.Controls.Add(this.textBoxStudentId);
            this.groupBoxBookSearch.Controls.Add(this.labelISBN);
            this.groupBoxBookSearch.Controls.Add(this.textBoxStudentName);
            this.groupBoxBookSearch.Controls.Add(this.labelOrStudentSearch);
            this.groupBoxBookSearch.Controls.Add(this.labelBookName);
            this.groupBoxBookSearch.Controls.Add(this.labelSearchStudentby);
            this.groupBoxBookSearch.Location = new System.Drawing.Point(18, 36);
            this.groupBoxBookSearch.Name = "groupBoxBookSearch";
            this.groupBoxBookSearch.Size = new System.Drawing.Size(214, 134);
            this.groupBoxBookSearch.TabIndex = 17;
            this.groupBoxBookSearch.TabStop = false;
            this.groupBoxBookSearch.Text = "Book Search";
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
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(37, 39);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 13);
            this.labelISBN.TabIndex = 13;
            this.labelISBN.Text = "ISBN";
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
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(33, 80);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(35, 13);
            this.labelBookName.TabIndex = 9;
            this.labelBookName.Text = "Name";
            // 
            // labelSearchStudentby
            // 
            this.labelSearchStudentby.AutoSize = true;
            this.labelSearchStudentby.Location = new System.Drawing.Point(6, 16);
            this.labelSearchStudentby.Name = "labelSearchStudentby";
            this.labelSearchStudentby.Size = new System.Drawing.Size(86, 13);
            this.labelSearchStudentby.TabIndex = 8;
            this.labelSearchStudentby.Text = "Search Book by:";
            // 
            // BookMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.groupBoxUserMaintenance);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxBookSearch);
            this.Name = "BookMaintenanceForm";
            this.Text = "BookMaintenanceForm";
            this.Controls.SetChildIndex(this.groupBoxBookSearch, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.groupBoxUserMaintenance, 0);
            this.groupBoxUserMaintenance.ResumeLayout(false);
            this.groupBoxUserMaintenance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxBookSearch.ResumeLayout(false);
            this.groupBoxBookSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUserMaintenance;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxISBNMaintenace;
        private System.Windows.Forms.Label labelISBNMaintenance;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioUpdate;
        private System.Windows.Forms.RadioButton radioInsert;
        private System.Windows.Forms.TextBox textBoxNameMaintenance;
        private System.Windows.Forms.Label labelNameMaintenance;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxBookSearch;
        private System.Windows.Forms.Button buttonSearchStudent;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label labelOrStudentSearch;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelSearchStudentby;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.Label labelPages;
    }
}
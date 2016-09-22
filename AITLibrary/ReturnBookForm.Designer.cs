namespace AITLibrary
{
    partial class ReturnBookForm
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
            this.dataGridViewBooksBorrowed = new System.Windows.Forms.DataGridView();
            this.groupBoxReturnBook = new System.Windows.Forms.GroupBox();
            this.buttonSearchBorroedBook = new System.Windows.Forms.Button();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.labelOrBookSearch = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.buttonReturnBook = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksBorrowed)).BeginInit();
            this.groupBoxReturnBook.SuspendLayout();
            this.SuspendLayout();

            // 
            // dataGridViewBooksBorrowed
            // 
            this.dataGridViewBooksBorrowed.AllowUserToAddRows = false;
            this.dataGridViewBooksBorrowed.AllowUserToDeleteRows = false;
            this.dataGridViewBooksBorrowed.AllowUserToOrderColumns = true;
            this.dataGridViewBooksBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooksBorrowed.Location = new System.Drawing.Point(226, 62);
            this.dataGridViewBooksBorrowed.Name = "dataGridViewBooksBorrowed";
            this.dataGridViewBooksBorrowed.ReadOnly = true;
            this.dataGridViewBooksBorrowed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooksBorrowed.Size = new System.Drawing.Size(746, 143);
            this.dataGridViewBooksBorrowed.TabIndex = 2;
            // 
            // groupBoxReturnBook
            // 
            this.groupBoxReturnBook.Controls.Add(this.buttonSearchBorroedBook);
            this.groupBoxReturnBook.Controls.Add(this.textBoxBookName);
            this.groupBoxReturnBook.Controls.Add(this.labelBookName);
            this.groupBoxReturnBook.Controls.Add(this.labelSearchBy);
            this.groupBoxReturnBook.Controls.Add(this.labelOrBookSearch);
            this.groupBoxReturnBook.Controls.Add(this.textBoxISBN);
            this.groupBoxReturnBook.Controls.Add(this.labelISBN);
            this.groupBoxReturnBook.Location = new System.Drawing.Point(12, 55);
            this.groupBoxReturnBook.Name = "groupBoxReturnBook";
            this.groupBoxReturnBook.Size = new System.Drawing.Size(209, 150);
            this.groupBoxReturnBook.TabIndex = 3;
            this.groupBoxReturnBook.TabStop = false;
            this.groupBoxReturnBook.Text = "Borrowed Book Search";
            // 
            // buttonSearchBorroedBook
            // 
            this.buttonSearchBorroedBook.Location = new System.Drawing.Point(103, 119);
            this.buttonSearchBorroedBook.Name = "buttonSearchBorroedBook";
            this.buttonSearchBorroedBook.Size = new System.Drawing.Size(100, 23);
            this.buttonSearchBorroedBook.TabIndex = 12;
            this.buttonSearchBorroedBook.Text = "Search";
            this.buttonSearchBorroedBook.UseVisualStyleBackColor = true;
            this.buttonSearchBorroedBook.Click += new System.EventHandler(this.buttonSearchBorroedBook_Click);
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(70, 80);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(134, 20);
            this.textBoxBookName.TabIndex = 11;
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(6, 83);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(63, 13);
            this.labelBookName.TabIndex = 10;
            this.labelBookName.Text = "Book Name";
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.Location = new System.Drawing.Point(5, 22);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(86, 13);
            this.labelSearchBy.TabIndex = 9;
            this.labelSearchBy.Text = "Search Book by:";
            // 
            // labelOrBookSearch
            // 
            this.labelOrBookSearch.AutoSize = true;
            this.labelOrBookSearch.Location = new System.Drawing.Point(70, 64);
            this.labelOrBookSearch.Name = "labelOrBookSearch";
            this.labelOrBookSearch.Size = new System.Drawing.Size(16, 13);
            this.labelOrBookSearch.TabIndex = 8;
            this.labelOrBookSearch.Text = "or";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(70, 41);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(134, 20);
            this.textBoxISBN.TabIndex = 7;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(37, 44);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 13);
            this.labelISBN.TabIndex = 6;
            this.labelISBN.Text = "ISBN";
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.Location = new System.Drawing.Point(115, 212);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(100, 23);
            this.buttonReturnBook.TabIndex = 4;
            this.buttonReturnBook.Text = "Return Book";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.buttonReturnBook);
            this.Controls.Add(this.groupBoxReturnBook);
            this.Controls.Add(this.dataGridViewBooksBorrowed);
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBookForm";

            this.Controls.SetChildIndex(this.dataGridViewBooksBorrowed, 0);
            this.Controls.SetChildIndex(this.groupBoxReturnBook, 0);
            this.Controls.SetChildIndex(this.buttonReturnBook, 0);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksBorrowed)).EndInit();
            this.groupBoxReturnBook.ResumeLayout(false);
            this.groupBoxReturnBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooksBorrowed;
        private System.Windows.Forms.GroupBox groupBoxReturnBook;
        private System.Windows.Forms.Button buttonSearchBorroedBook;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelSearchBy;
        private System.Windows.Forms.Label labelOrBookSearch;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Button buttonReturnBook;
    }
}
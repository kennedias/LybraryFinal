﻿namespace AITLibrary
{
    partial class BorrowBookForm
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
            this.buttonBorrowBook = new System.Windows.Forms.Button();
            this.groupBoxSearchBooks = new System.Windows.Forms.GroupBox();
            this.buttonSearchBooks = new System.Windows.Forms.Button();
            this.buttonListAllBooks = new System.Windows.Forms.Button();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.labelOrBookSearch = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.dataGridViewListBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxStudentSearch.SuspendLayout();
            this.groupBoxSearchBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(817, 134);
            this.dataGridView1.TabIndex = 13;
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
            this.groupBoxStudentSearch.Location = new System.Drawing.Point(14, 34);
            this.groupBoxStudentSearch.Name = "groupBoxStudentSearch";
            this.groupBoxStudentSearch.Size = new System.Drawing.Size(214, 134);
            this.groupBoxStudentSearch.TabIndex = 12;
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
            // buttonBorrowBook
            // 
            this.buttonBorrowBook.Location = new System.Drawing.Point(12, 367);
            this.buttonBorrowBook.Name = "buttonBorrowBook";
            this.buttonBorrowBook.Size = new System.Drawing.Size(216, 23);
            this.buttonBorrowBook.TabIndex = 11;
            this.buttonBorrowBook.Text = "Borrow Book";
            this.buttonBorrowBook.UseVisualStyleBackColor = true;
            this.buttonBorrowBook.Click += new System.EventHandler(this.buttonBorrowBook_Click);
            // 
            // groupBoxSearchBooks
            // 
            this.groupBoxSearchBooks.Controls.Add(this.buttonSearchBooks);
            this.groupBoxSearchBooks.Controls.Add(this.buttonListAllBooks);
            this.groupBoxSearchBooks.Controls.Add(this.textBoxAuthor);
            this.groupBoxSearchBooks.Controls.Add(this.labelAuthor);
            this.groupBoxSearchBooks.Controls.Add(this.textBoxBookName);
            this.groupBoxSearchBooks.Controls.Add(this.labelBookName);
            this.groupBoxSearchBooks.Controls.Add(this.labelSearchBy);
            this.groupBoxSearchBooks.Controls.Add(this.labelOrBookSearch);
            this.groupBoxSearchBooks.Controls.Add(this.textBoxISBN);
            this.groupBoxSearchBooks.Controls.Add(this.labelISBN);
            this.groupBoxSearchBooks.Location = new System.Drawing.Point(12, 171);
            this.groupBoxSearchBooks.Name = "groupBoxSearchBooks";
            this.groupBoxSearchBooks.Size = new System.Drawing.Size(216, 190);
            this.groupBoxSearchBooks.TabIndex = 10;
            this.groupBoxSearchBooks.TabStop = false;
            this.groupBoxSearchBooks.Text = "Books Search ";
            // 
            // buttonSearchBooks
            // 
            this.buttonSearchBooks.Location = new System.Drawing.Point(106, 130);
            this.buttonSearchBooks.Name = "buttonSearchBooks";
            this.buttonSearchBooks.Size = new System.Drawing.Size(100, 23);
            this.buttonSearchBooks.TabIndex = 10;
            this.buttonSearchBooks.Text = "Search";
            this.buttonSearchBooks.UseVisualStyleBackColor = true;
            this.buttonSearchBooks.Click += new System.EventHandler(this.buttonSearchBooks_Click);
            // 
            // buttonListAllBooks
            // 
            this.buttonListAllBooks.Location = new System.Drawing.Point(106, 159);
            this.buttonListAllBooks.Name = "buttonListAllBooks";
            this.buttonListAllBooks.Size = new System.Drawing.Size(100, 23);
            this.buttonListAllBooks.TabIndex = 1;
            this.buttonListAllBooks.Text = "List All Books";
            this.buttonListAllBooks.UseVisualStyleBackColor = true;
            this.buttonListAllBooks.Click += new System.EventHandler(this.buttonListAllBooks_Click);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(72, 102);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(134, 20);
            this.textBoxAuthor.TabIndex = 7;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(33, 105);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 6;
            this.labelAuthor.Text = "Author";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(72, 75);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(134, 20);
            this.textBoxBookName.TabIndex = 5;
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(8, 78);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(63, 13);
            this.labelBookName.TabIndex = 4;
            this.labelBookName.Text = "Book Name";
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.Location = new System.Drawing.Point(7, 20);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(86, 13);
            this.labelSearchBy.TabIndex = 3;
            this.labelSearchBy.Text = "Search Book by:";
            // 
            // labelOrBookSearch
            // 
            this.labelOrBookSearch.AutoSize = true;
            this.labelOrBookSearch.Location = new System.Drawing.Point(72, 59);
            this.labelOrBookSearch.Name = "labelOrBookSearch";
            this.labelOrBookSearch.Size = new System.Drawing.Size(16, 13);
            this.labelOrBookSearch.TabIndex = 2;
            this.labelOrBookSearch.Text = "or";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(72, 36);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(134, 20);
            this.textBoxISBN.TabIndex = 1;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(39, 39);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 13);
            this.labelISBN.TabIndex = 0;
            this.labelISBN.Text = "ISBN";
            // 
            // dataGridViewListBooks
            // 
            this.dataGridViewListBooks.AllowUserToAddRows = false;
            this.dataGridViewListBooks.AllowUserToDeleteRows = false;
            this.dataGridViewListBooks.AllowUserToOrderColumns = true;
            this.dataGridViewListBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListBooks.Location = new System.Drawing.Point(238, 177);
            this.dataGridViewListBooks.Name = "dataGridViewListBooks";
            this.dataGridViewListBooks.ReadOnly = true;
            this.dataGridViewListBooks.Size = new System.Drawing.Size(817, 184);
            this.dataGridViewListBooks.TabIndex = 9;
            // 
            // BorrowBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxStudentSearch);
            this.Controls.Add(this.buttonBorrowBook);
            this.Controls.Add(this.groupBoxSearchBooks);
            this.Controls.Add(this.dataGridViewListBooks);
            this.Name = "BorrowBookForm";
            this.Text = "BorrowBookForm";
            this.Controls.SetChildIndex(this.dataGridViewListBooks, 0);
            this.Controls.SetChildIndex(this.groupBoxSearchBooks, 0);
            this.Controls.SetChildIndex(this.buttonBorrowBook, 0);
            this.Controls.SetChildIndex(this.groupBoxStudentSearch, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxStudentSearch.ResumeLayout(false);
            this.groupBoxStudentSearch.PerformLayout();
            this.groupBoxSearchBooks.ResumeLayout(false);
            this.groupBoxSearchBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListBooks)).EndInit();
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
        private System.Windows.Forms.Button buttonBorrowBook;
        private System.Windows.Forms.GroupBox groupBoxSearchBooks;
        private System.Windows.Forms.Button buttonSearchBooks;
        private System.Windows.Forms.Button buttonListAllBooks;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelSearchBy;
        private System.Windows.Forms.Label labelOrBookSearch;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.DataGridView dataGridViewListBooks;
    }
}
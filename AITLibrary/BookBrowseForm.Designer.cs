namespace AITLibrary
{
    partial class BookBrowseForm
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
            this.dataGridViewBookBrowse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookBrowse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookBrowse
            // 
            this.dataGridViewBookBrowse.AllowUserToAddRows = false;
            this.dataGridViewBookBrowse.AllowUserToDeleteRows = false;
            this.dataGridViewBookBrowse.AllowUserToOrderColumns = true;
            this.dataGridViewBookBrowse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookBrowse.Location = new System.Drawing.Point(28, 27);
            this.dataGridViewBookBrowse.MultiSelect = false;
            this.dataGridViewBookBrowse.Name = "dataGridViewBookBrowse";
            this.dataGridViewBookBrowse.ReadOnly = true;
            this.dataGridViewBookBrowse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookBrowse.Size = new System.Drawing.Size(1022, 555);
            this.dataGridViewBookBrowse.TabIndex = 3;
            // 
            // BookBrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.dataGridViewBookBrowse);
            this.Name = "BookBrowseForm";
            this.Text = "Book Browse";
            this.Load += new System.EventHandler(this.BookBrowseForm_Load);
            this.Controls.SetChildIndex(this.labelSystemMessage, 0);
            this.Controls.SetChildIndex(this.dataGridViewBookBrowse, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookBrowse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBookBrowse;
    }
}
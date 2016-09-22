using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace AITLibrary
{
    public partial class BorrowBookForm : LybraryTemplateForm
    {
        public BorrowBookForm()
        {
            InitializeComponent();
        }

        private void buttonSearchBooks_Click(object sender, EventArgs e)
        {
            labelSystemMessage.Text = "";
            BookLogic bookLogic = new BookLogic();
            dataGridViewListBooks.DataSource = bookLogic.BookSearch(textBoxISBN.Text, textBoxBookName.Text, textBoxAuthor.Text);

            if (dataGridViewListBooks.RowCount == 0)
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "No matches found.";
            }
        }

        private void buttonListAllBooks_Click(object sender, EventArgs e)
        {
            labelSystemMessage.Text = "";
            textBoxISBN.Text = "";
            textBoxBookName.Text = "";
            textBoxAuthor.Text = "";

            BookLogic bookLogic = new BookLogic();
            dataGridViewListBooks.DataSource = bookLogic.GetAllAvailableBooks();
        }

        private void buttonBorrowBook_Click(object sender, EventArgs e)
        {
            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
            labelSystemMessage.Text = "";

            if (dataGridViewListBooks.DataSource != null && dataGridViewListBooks.SelectedRows.Count > 0)
            {
                try
                {
                    String isbn = dataGridViewListBooks.SelectedRows[0].Cells[(int)AppEnum.ViewBook.Isbn].Value.ToString();

                    BookLogic bookLogic = new BookLogic();
                    int resultOperation = bookLogic.InsertBorrowBook(staticUserID, isbn, DateTime.Today.ToString(), DateTime.Today.AddDays(7).ToString(), Constants.actualDateReturnForInsert, Constants.lateFee);

                    if (resultOperation == 0)
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = "Borrow could not be included. Contact the System Administrator.";
                    }
                    else
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                        labelSystemMessage.Text = "Borrow included with success.";
                    }
                }
                catch (BookException ex)
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = ex.Message;
                }
            }
            else
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "You need to select a book first.";
            }
        }
    }
}

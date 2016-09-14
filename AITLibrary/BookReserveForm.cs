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
    public partial class BookReserveForm : LybraryBaseForm
    {
        public BookReserveForm()
        {
            InitializeComponent();
        }

        private void buttonListAllBooks_Click(object sender, EventArgs e)
        {
            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
            labelSystemMessage.Text = "";
            textBoxISBN.Text = "";
            textBoxBookName.Text = "";
            textBoxAuthor.Text = "";

            BookLogic bookLogic = new BookLogic();
            dataGridViewListBooks.DataSource = bookLogic.GetAllBooksView();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
            labelSystemMessage.Text = "";

            if (textBoxISBN.Text.Length == 0 && textBoxBookName.Text.Length == 0 && textBoxAuthor.Text.Length == 0)
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "No search criteria was informed.";
            }
            else
            {
                BookLogic bookLogic = new BookLogic();
                dataGridViewListBooks.DataSource = bookLogic.BookSearch(textBoxISBN.Text, textBoxBookName.Text, textBoxAuthor.Text);

                if (dataGridViewListBooks.RowCount == 0)
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = "No matches found.";
                }
            }
        }

        private void textBoxISBN_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxBookName.Text = "";
            textBoxAuthor.Text = "";
        }

        private void textBoxBookName_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxISBN.Text = "";
        }

        private void textBoxAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxISBN.Text = "";
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
            labelSystemMessage.Text = "";

            if (dataGridViewListBooks.DataSource != null && dataGridViewListBooks.SelectedRows.Count > 0)
            {
                String isbn = dataGridViewListBooks.SelectedRows[0].Cells[(int)AppEnum.ViewBook.Isbn].Value.ToString();
                labelSystemMessage.Text = isbn;

                BookLogic bookLogic = new BookLogic();
                int resultOperation = bookLogic.insertBookReserved(staticUserID, isbn, DateTime.Today.ToString());

                if (resultOperation == 0)
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = "Reserve could not be included. Contact the System Administrator.";
                }
                else
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                    labelSystemMessage.Text = "Reserve included with success.";
                }


            }
            else
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "You need to select a book first.";
            }
           // 
            
        }


    }
}

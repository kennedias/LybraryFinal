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
    public partial class BookForm : MyForm
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void buttonListBooks_Click(object sender, EventArgs e)
        {
            labelMessageForUser.Text = "";
            textBoxISBN.Text = "";
            textBoxBookName.Text = "";
            textBoxAuthor.Text = "";

            BookLogic bookLogic = new BookLogic();
            dataGridViewListBooks.DataSource = bookLogic.GetAllBooksView();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            labelMessageForUser.Text = "";
            BookLogic bookLogic = new BookLogic();
            dataGridViewListBooks.DataSource = bookLogic.BookSearch(textBoxISBN.Text, textBoxBookName.Text, textBoxAuthor.Text);

            if (dataGridViewListBooks.RowCount == 0)
            {
                labelMessageForUser.ForeColor = System.Drawing.Color.Red;
                labelMessageForUser.Text = "No matches found.";
            }

        }

        private void textBoxISBN_TextChanged(object sender, EventArgs e)
        {
            textBoxBookName.Text = "";
            textBoxAuthor.Text = "";
        }

        private void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {
            textBoxISBN.Text = "";
        }

        private void textBoxBookName_TextChanged(object sender, EventArgs e)
        {
            textBoxISBN.Text = "";
        }


    }
}

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
    public partial class BookSearchForm : LybraryTemplateForm
    {
        public BookSearchForm()
        {
            InitializeComponent();
        }

        private void buttonListBooks_Click(object sender, EventArgs e)
        {
            try
            {
                labelMessageForUser.Text = "";
                textBoxISBN.Text = "";
                textBoxBookName.Text = "";
                textBoxAuthor.Text = "";
                dataGridViewListBooks.DataSource = null;
                BookLogic bookLogic = new BookLogic();
                dataGridViewListBooks.DataSource = bookLogic.GetAllBooksView();
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewListBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "This action can not be completed! Please contact the system support team.";
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewListBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "Sorry, something went wrong! Please contact the system support team.";
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxISBN.Text.Length == 0 && textBoxBookName.Text.Length == 0 && textBoxAuthor.Text.Length == 0)
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = "No search criteria was informed.";
                }
                else
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
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewListBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "This action can not be completed! Please contact the system support team.";
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewListBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "Sorry, something went wrong! Please contact the system support team.";
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

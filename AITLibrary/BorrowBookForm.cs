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
            try
            {
                labelSystemMessage.Text = "";
                BookLogic bookLogic = new BookLogic();
                dataGridViewListBooks.DataSource = bookLogic.GetAllBooksAvailableByBookNameAndAuthor(textBoxBookName.Text, textBoxAuthor.Text);

                if (dataGridViewListBooks.RowCount == 0)
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = "No matches found.";
                }
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "This action can not be completed! " + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "Sorry, something went wrong! Please contact the system support team.";
            }
        }

        private void buttonListAllBooks_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = "";
                textBoxBookName.Text = "";
                textBoxAuthor.Text = "";
                dataGridViewListBooks.DataSource = null;
                BookLogic bookLogic = new BookLogic();
                dataGridViewListBooks.DataSource = bookLogic.GetAllAvailableBooks();
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewListBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "This action can not be completed! " + ex.Message;
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

        private void buttonBorrowBook_Click(object sender, EventArgs e)
        {
            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
            labelSystemMessage.Text = "[...]";

            try
            {
                if ((dataGridViewListBooks.DataSource != null && dataGridViewListBooks.SelectedRows.Count > 0) &&
                    (dataGridViewUser.DataSource != null && dataGridViewUser.SelectedRows.Count > 0))
                {

                    String isbn = dataGridViewListBooks.SelectedRows[0].Cells[(int)AppEnum.ViewBook.Isbn].Value.ToString();
                    int userId = (int) dataGridViewUser.SelectedRows[0].Cells[(int)AppEnum.TabUser.ID].Value;

                    BookLogic bookLogic = new BookLogic();
                    int resultOperation = bookLogic.InsertBorrowBook(userId, isbn);

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
                else
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = "You need to select a student and a book first.";
                }
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "This action can not be completed! " + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "Sorry, something went wrong! Please contact the system support team.";
            }
        }

        private void buttonSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = "";

                if (textBoxUserName.Text == "")
                {
                    labelSystemMessage.Text = "User name is blank.";
                }
                else
                {
                    UserLogic userLogic = new UserLogic();

                    dataGridViewUser.DataSource = userLogic.GetUsersByName(textBoxUserName.Text);
                    dataGridViewUser.Columns["ID"].Visible = false;
                    dataGridViewUser.Columns["LevelCode"].Visible = false;
                    dataGridViewUser.Columns["LevelDescription"].Visible = false;

                    if (dataGridViewUser.RowCount == 0)
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = "No matches found.";
                    }

                }

            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "This action can not be completed! " + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "Sorry, something went wrong! Please contact the system support team.";
            }
        }
    }
}

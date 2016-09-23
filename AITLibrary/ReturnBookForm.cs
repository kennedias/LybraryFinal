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
    public partial class ReturnBookForm : LybraryTemplateForm
    {
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void buttonSearchByCriteria_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                labelSystemMessage.Text = "";

                if (textBoxBookName.Text.Length == 0)
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = "No search criteria was informed.";
                }
                else
                {
                    BookLogic bookLogic = new BookLogic();
                    dataGridViewBooksBorrowed.DataSource = bookLogic.GetBooksBorrowedViewByName(textBoxBookName.Text);
                    dataGridViewBooksBorrowed.Columns["UserId"].Visible = false;
                    dataGridViewBooksBorrowed.Columns["BorrowId"].Visible = false;
                    dataGridViewBooksBorrowed.Columns["Latefee"].Visible = false;

                    if (dataGridViewBooksBorrowed.RowCount == 0)
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

        private void buttonListAllBorrowedBooks_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxBookName.Text = "";
                labelSystemMessage.Text = "";
                BookLogic bookLogic = new BookLogic();
                dataGridViewBooksBorrowed.DataSource = bookLogic.GetAllBooksBorrowedWithUserView();
                dataGridViewBooksBorrowed.Columns["UserId"].Visible = false;
                dataGridViewBooksBorrowed.Columns["BorrowId"].Visible = false;
                dataGridViewBooksBorrowed.Columns["Latefee"].Visible = false;

                if (dataGridViewBooksBorrowed.RowCount == 0)
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

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                labelSystemMessage.Text = "";

                if (dataGridViewBooksBorrowed.DataSource != null && dataGridViewBooksBorrowed.SelectedRows.Count > 0)
                {
                    int bidColumnIndex = (int)AppEnum.ViewBookBorrowedWithUserModel.BorrowId;
                    int returnDateColumnIndex = (int)AppEnum.ViewBookBorrowedWithUserModel.Return;

                    int bid = (int)dataGridViewBooksBorrowed.SelectedRows[0].Cells[bidColumnIndex].Value;
                    String returnDate = dataGridViewBooksBorrowed.SelectedRows[0].Cells[returnDateColumnIndex].Value.ToString();

                    BookLogic bookLogic = new BookLogic();                    
                    int resultOperation = bookLogic.ReturnBorrowBook(bid, returnDate);

                    if (resultOperation == 0)
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = "Book could not be returned. Contact the System Administrator.";
                    }
                    else
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                        labelSystemMessage.Text = "Return done with success.";
                    }
                }
                else
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = "You need to select a book first.";
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

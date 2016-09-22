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
    public partial class BooksBorrowedAndReservedForm : LybraryTemplateForm
    {
        public BooksBorrowedAndReservedForm()
        {
            InitializeComponent();
        }

        private void radioBorrowed_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = "[..]";
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                dataGridViewBooks.DataSource = null;

                BookLogic bookLogic = new BookLogic();
                dataGridViewBooks.DataSource = bookLogic.GetAllBorrowedBooks();
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "This action can not be completed! Please contact the system support team.";
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "Sorry, something went wrong! Please contact the system support team.";
            }
        }

        private void radioButtonReserved_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = "[..]";
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                dataGridViewBooks.DataSource = null;

                BookLogic bookLogic = new BookLogic();
                dataGridViewBooks.DataSource = bookLogic.GetAllBooksReservedView();
                dataGridViewBooks.Columns["ReserveId"].Visible = false;
                dataGridViewBooks.Columns["UserId"].Visible = false;
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "This action can not be completed! Please contact the system support team.";
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "Sorry, something went wrong! Please contact the system support team.";
            }
        }
    }
}

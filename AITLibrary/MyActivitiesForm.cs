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
    public partial class MyActivitiesForm : LybraryTemplateForm
    {
        public MyActivitiesForm()
        {
            InitializeComponent();
        }

        private void radioButtonBorrowed_CheckedChanged(object sender, EventArgs e)
        {
            labelSystemMessage.Text = "";
            labelSystemMessage.Text = "Borrowed";

            BookLogic bookLogic = new BookLogic();
            dataGridViewUserBookActivity.DataSource = bookLogic.GetAllBorrowedBooksByUserId(staticUserID);


        }

        private void radioButtonReserved_CheckedChanged(object sender, EventArgs e)
        {
            labelSystemMessage.Text = "";
            labelSystemMessage.Text = "Reserved";

            BookLogic bookLogic = new BookLogic();
            dataGridViewUserBookActivity.DataSource = bookLogic.GetAllBooksReservedViewByUserId(staticUserID);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AITLibrary
{
    public partial class LybraryBaseForm : LybraryPrincipalForm
    {
        public LybraryBaseForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemUserDetails_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadUserDetailsForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenUserDetailsForm));
            threadUserDetailsForm.Start();
            this.Close();
        }

        private void OpenUserDetailsForm()
        {
            Application.Run(new UserDetailsForm());
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadLoginForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
            threadLoginForm.Start();
            this.Close();
        }

        private void OpenLoginForm()
        {
            Application.Run(new LoginForm());
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadBookForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenBookForm));
            threadBookForm.Start();
            this.Close();
        }

        private void OpenBookForm()
        {
            Application.Run(new BookSearchForm());
        }

        private void consultCancelReserveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadConsultAndCancelBookReservedForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenConsultAndCancelBookReservedForm));
            threadConsultAndCancelBookReservedForm.Start();
            this.Close();
        }

        private void OpenConsultAndCancelBookReservedForm()
        {
            Application.Run(new ConsultAndCancelBookReservedForm());
        }

        private void reserveABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadBookReserveForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenBookReserveForm));
            threadBookReserveForm.Start();
            this.Close();
        }

        private void OpenBookReserveForm()
        {
            Application.Run(new BookReserveForm());
        }

        private void reserveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void borrowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadBorrowBookForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenBorrowBookForm));
            threadBorrowBookForm.Start();
            this.Close();
        }

        private void OpenBorrowBookForm()
        {
            Application.Run(new BorrowBookFormXX());
        }

        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadReturnBookForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenReturnBookForm));
            threadReturnBookForm.Start();
            this.Close();
        }

        private void OpenReturnBookForm()
        {
            Application.Run(new ReturnBookForm());
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadBrowseBookForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenBookBrowseForm));
            threadBrowseBookForm.Start();
            this.Close();

        }

        private void OpenBookBrowseForm()
        {
            Application.Run(new BookBrowseForm());
        }

        private void viewBorrowedReservedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadBorrowedReservedBookForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenBooksBorrowedAndReservedForm));
            threadBorrowedReservedBookForm.Start();
            this.Close();
        }

        private void OpenBooksBorrowedAndReservedForm()
        {
            Application.Run(new BooksBorrowedAndReservedForm());
        }

        private void myActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadMyActivityBookForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMyActivityForm));
            threadMyActivityBookForm.Start();
            this.Close();
        }

        private void OpenMyActivityForm()
        {
            Application.Run(new MyActivityForm());
        }
    }
}

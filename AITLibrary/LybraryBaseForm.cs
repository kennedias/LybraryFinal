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

        public void OpenUserDetailsForm()
        {
            Application.Run(new UserDetailsForm());
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadLoginForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
            threadLoginForm.Start();
            this.Close();

        }

        public void OpenLoginForm()
        {
            Application.Run(new LoginForm());
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadBookForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenBookForm));
            threadBookForm.Start();
            this.Close();
        }

        public void OpenBookForm()
        {
            Application.Run(new BookForm());
        }

        private void reserveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadBookReserveForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenBookReserveForm));
            threadBookReserveForm.Start();
            this.Close();
        }

        public void OpenBookReserveForm()
        {
            Application.Run(new BookReserveForm());
        }

    }
}

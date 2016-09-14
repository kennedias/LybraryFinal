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
    public partial class ConsultAndCancelBookReservedForm : LybraryBaseForm
    {
        public ConsultAndCancelBookReservedForm()
        {
            InitializeComponent();
        }

        private void buttonCancelBookReserve_Click(object sender, EventArgs e)
        {
            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
            labelSystemMessage.Text = "";

            if (dataGridViewBookReserved.DataSource != null && dataGridViewBookReserved.SelectedRows.Count > 0)
            {
                try
                {
                    String isbn = dataGridViewBookReserved.SelectedRows[0].Cells[(int)AppEnum.ViewBook.Isbn].Value.ToString();
                    labelSystemMessage.Text = isbn;

                    BookLogic bookLogic = new BookLogic();
                    int resultOperation = bookLogic.DeleteBookReserved();
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

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
    public partial class ConsultAndCancelBookReservedForm : LybraryTemplateForm
    {
        public ConsultAndCancelBookReservedForm()
        {
            InitializeComponent();
        }

        private void buttonCancelBookReserve_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                labelSystemMessage.Text = "";

                if (dataGridViewBookReserved.DataSource != null && dataGridViewBookReserved.SelectedRows.Count > 0)
                {
                    int reserveId = (int) dataGridViewBookReserved.SelectedRows[0].Cells[(int)AppEnum.ViewBookReserved.ReserveId].Value;
                    labelSystemMessage.Text = reserveId.ToString();

                    BookLogic bookLogic = new BookLogic();
                    int resultOperation = bookLogic.DeleteBookReserved(reserveId);
                    if (resultOperation == 0)
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = "Reserve could not be canceled. Contact the System Administrator.";
                    }
                    else
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                        labelSystemMessage.Text = "Reserve canceled with success.";
                        dataGridViewBookReserved.Refresh();
                        dataGridViewBookReserved.RefreshEdit();
                        dataGridViewBookReserved.Update();
                        //TODO

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

        private void ConsultAndCancelBookReservedForm_Load(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = "";
                BookLogic bookLogic = new BookLogic();
                dataGridViewBookReserved.DataSource = bookLogic.GetAllBooksReservedViewByUserId(staticUserID);

                if (dataGridViewBookReserved.RowCount == 0)
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = "There are no book reserved.";
                }
                else
                {
                    dataGridViewBookReserved.Columns["User"].Visible = false;
                    dataGridViewBookReserved.Columns["ReserveId"].Visible = false;
                    dataGridViewBookReserved.Columns["UserId"].Visible = false;
                }
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewBookReserved.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "This action can not be completed! " + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewBookReserved.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "Sorry, something went wrong! Please contact the system support team.";
            }
        }
    }
}

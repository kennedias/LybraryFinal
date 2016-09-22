﻿using System;
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
            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
            labelSystemMessage.Text = "";

            if (dataGridViewBookReserved.DataSource != null && dataGridViewBookReserved.SelectedRows.Count > 0)
            {
                try
                {
                    String isbn = dataGridViewBookReserved.SelectedRows[0].Cells[(int)AppEnum.ViewBook.Isbn].Value.ToString();
                    labelSystemMessage.Text = isbn;
                    int reserveId = 0;

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
                    }
                }
                catch (BusinessLogicException ex)
                {
                    //Error log simulate
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine(ex.GetBaseException().ToString());
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = "This action can not be completed! Please contact the system support team.";
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
            else
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "You need to select a book first.";
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
                    dataGridViewBookReserved.Columns["UserName"].Visible = false;
                }
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewBookReserved.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "This action can not be completed! Please contact the system support team.";
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

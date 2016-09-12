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
    public partial class ChangePasswordForm : LybraryPrincipalForm
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            labelReturnMsg.Text = "";
            LoginLogic loginLogic = new LoginLogic();

            if (textBoxNewPassword.Text == staticUserPassword)
            {
                labelReturnMsg.Text = "New Password is equals to the previous.";
            }
            else if (textBoxNewPassword.Text == "")
            {
                labelReturnMsg.Text = "New Password is blank.";
            }
            else if (!loginLogic.passwordFormatValidation(textBoxNewPassword.Text))
            {
                labelReturnMsg.Text = "New Password. " + loginLogic.MessageOfValidation;

            } else if (textBoxConfirmPassword.Text == "")
            {
                labelReturnMsg.Text = "Confirm Password is blank.";
            }
            else if (!loginLogic.passwordFormatValidation(textBoxConfirmPassword.Text))
            {
                labelReturnMsg.Text = "Confirm Password. " + loginLogic.MessageOfValidation;

            }
            else if (textBoxNewPassword.Text != textBoxConfirmPassword.Text)
            {
                labelReturnMsg.Text = "New and Confirm Password have to be equals.";

            }
            else
            {
                try
                {
                    UserLogic userLogic = new UserLogic();
                    int resultQuery = userLogic.updateUser(staticUserName, textBoxNewPassword.Text, staticUserLevelDescription, staticUserID);
                    if (resultQuery < 1)
                    {
                        throw new UserException("No record were updated.");
                    }
                    else
                    {
                        staticUserPassword = textBoxNewPassword.Text;
                        this.Close();
                    }

                    

                }

                catch (FormatException ex)
                {
                    //logging for admin to be inspect IF TRY TO PASS ABC FOR EXAMPLE
                }

                catch (UserException ex)
                {

                    //logging for admin to be inspect
                }

                catch (Exception ex)
                {
                    //logging for admin to be inspect
                }
            }
        }

        public void OpenBookForm()
        {
            Application.Run(new BookForm());
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

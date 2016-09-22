/* Form for maintenance of User details by the User logged
 * 
 * Project: Assignment 2 - AIT
 * Developer: Kennedy Oliveira - ID 5399
 * Data of release: 19/08/2016
 * Version: 1.0 - Release
 * 
 */
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
    /// <summary>
    ///  Form for maintenance of User details by the User logged.
    /// </summary>
    public partial class UserDetailsForm : LybraryTemplateForm
    {
        public UserDetailsForm()
        {
            InitializeComponent();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = "";
                System.Threading.Thread threadForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenChangePasswordForm));
                threadForm.Start();
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

        public void OpenChangePasswordForm()
        {
            try
            {
                Application.Run(new ChangePasswordForm());
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

        private void UserDetailsForm_Load(object sender, EventArgs e)
        {
            try
            {
                /* User can not change his User Level */
                if (staticUserLevelCode == Constants.userCode)
                {
                    comboBoxUserLevel.Enabled = false;
                }

                textBoxUserName.Text = staticUserName;
                comboBoxUserLevel.SelectedText = staticUserLevelDescription;
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

        private void buttonSaveUserModification_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = "";

                if (textBoxUserName.Text == null)
                {
                    labelSystemMessage.Text = "User Name is blank.";
                }
                else
                {
                    UserLogic userLogic = new UserLogic();
                    int returnOperation = userLogic.updateUser(textBoxUserName.Text, staticUserPassword, comboBoxUserLevel.Text, staticUserID);
                    if (returnOperation < 1)
                    {
                        labelSystemMessage.Text = "No record were updated!";
                        // throw new UserException("No record were updated.");
                    }
                    else
                    {
                        labelSystemMessage.Text = "Operation completed with success!";
                        staticUserName = textBoxUserName.Text;
                    }
                }
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

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
    public partial class UserDetailsForm : LybraryBaseForm
    {
        public UserDetailsForm()
        {
            InitializeComponent();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            labelSystemMessage.Text = "...";
            System.Threading.Thread threadForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenChangePasswordForm));
            threadForm.Start();
        }

        public void OpenChangePasswordForm()
        {
            Application.Run(new ChangePasswordForm());
        }

        private void UserDetailsForm_Load(object sender, EventArgs e)
        {
            if (staticUserLevelCode == Constants.userCode)
            {
                comboBoxUserLevel.Enabled = false;
            }

            textBoxUserName.Text = staticUserName;
            comboBoxUserLevel.SelectedText = staticUserLevelDescription;
        }

        private void buttonSaveUserModification_Click(object sender, EventArgs e)
        {
            labelSystemMessage.Text = "...";

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
    }
}

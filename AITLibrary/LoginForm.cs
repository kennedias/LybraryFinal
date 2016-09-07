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
    public partial class LoginForm : MyForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            labelReturnMsg.Text = "";
            LoginLogic loginLogic = new LoginLogic();

            if ((textBoxUserName.Text == "") && (textBoxPassword.Text == ""))
            {
                labelReturnMsg.Text = "User name and password are blank.";
            }
            else if (textBoxUserName.Text == "")
            {
                labelReturnMsg.Text = "User name is blank."; 
            }
            else if (textBoxPassword.Text == "")
            {
                labelReturnMsg.Text = "Password is blank.";
            }
            else if (!loginLogic.passwordFormatValidation(textBoxPassword.Text))
            {
                labelReturnMsg.Text = loginLogic.MessageOfValidation;

            } else
            {
                UserLogic userLogic = new UserLogic();
                List<TabUserModel> tmpListUser = userLogic.PerformLogin(textBoxUserName.Text, textBoxPassword.Text);

                if (tmpListUser.Count > 0)
                {
                    //pass to Myform the informations of the user
                    staticUserID = tmpListUser[0].UserID;
                    staticUserName = tmpListUser[0].UserName;
                    staticUserLevelCode = tmpListUser[0].UserLevelCode;
                    staticUserLevelDescription = tmpListUser[0].UserLevelDescription;

                    if (staticUserLevelCode == Constants.userCode)
                    {
                        staticUserPassword = textBoxPassword.Text;
                        System.Threading.Thread threadChangePasswordForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenChangePasswordForm));
                        threadChangePasswordForm.Start();
                        this.Close();
                    }
                    else
                    {

                        System.Threading.Thread threadUserForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenBookForm));
                        threadUserForm.Start();
                        this.Close();
                    }

                }
                else
                {
                    labelReturnMsg.Text = "User not found or password invalid.";
                }
            }

        }

        public void OpenBookForm()
        {
            Application.Run(new BookForm());
        }

        public void OpenChangePasswordForm()
        {
            Application.Run(new ChangePasswordForm());
        }
    }
}

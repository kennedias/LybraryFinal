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
    public partial class LoginForm : LybraryPrincipalForm
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
                    staticUserPassword = textBoxPassword.Text;

                    if (staticUserLevelCode == Constants.userCode) //TODO Constants.userCode)
                    {
                        
                        System.Threading.Thread threadChangePasswordForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenChangePasswordForm));
                        threadChangePasswordForm.Start();
                        System.Threading.Thread threadLybraryBaseForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLybraryTemplateForm));
                        threadLybraryBaseForm.Start();
                        this.Close();
                    }
                    else
                    {

                        System.Threading.Thread threadLybraryBaseForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLybraryTemplateForm));
                        threadLybraryBaseForm.Start();
                        this.Close();
                    }

                }
                else
                {
                    labelReturnMsg.Text = "User not found or password invalid.";
                }
            }

        }

        public void OpenLybraryTemplateForm()
        {
            Application.Run(new LybraryTemplateForm());
        }

        public void OpenChangePasswordForm()
        {
            Application.Run(new ChangePasswordForm());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            /* Once this form is loaded, all the user information should be cleaned.
             * This works for a login/logoff functionality.
            */
            staticUserID = 0;
            staticUserName = null;
            staticUserLevelCode = 0;
            staticUserLevelDescription = null;
        }



    }
}

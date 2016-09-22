/* Form to list all users. 
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
    ///   Form to list all users.
    /// </summary>
    public partial class UserForm : LybraryTemplateForm
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void buttonListUsers_Click(object sender, EventArgs e)
        {
            try
            {
                UserLogic userLogic = new UserLogic();
                dataGridViewListUsers.DataSource = userLogic.GetAllUser();
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
    }
}

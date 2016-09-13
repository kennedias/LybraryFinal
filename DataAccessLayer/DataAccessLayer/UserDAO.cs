/* Data Access Object for the User data
 * 
 * Project: Assignment 1 - AIT
 * Developer: Kennedy Oliveira - ID 5399
 * Data of release: 19/08/2016
 * Version: 1.0 - Release
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.UserDSTableAdapters;

namespace DataAccessLayer
{

    /// <summary>
    /// Classe designed for access the User data.
    /// </summary>
    /// <remarks>
    /// All access of data from User should be implemented here.</remarks>
    /// 
    public class UserDAO
    {
        private UserDS _userDataSet;
        private TabUserTableAdapter _tabUserTableAdapter;

        /// <summary>
        /// Class constructor
        /// </summary>
        public UserDAO()
        {
            //Initialize objects
            _userDataSet = new UserDS();
            _tabUserTableAdapter = new TabUserTableAdapter();
        }

        /// <summary>
        /// Returns all registers from User table.
        /// </summary>
        /// <returns>UserDS.TabUserDataTable</returns>
        public UserDS.TabUserDataTable GetAllUser()
        {
            _tabUserTableAdapter.FillAllUsers(_userDataSet.TabUser);
            return _userDataSet.TabUser;
        }

        /// <summary>
        /// Return register from User table based on login details.
        /// </summary>
        /// <param name="userName">string userName</param>
        /// <param name="password">string password</param>
        /// <returns>UserDS.TabUserDataTable</returns>
        public UserDS.TabUserDataTable GetLogin(string userName, string password)
        {
            _tabUserTableAdapter.FillByUserNamePassword(_userDataSet.TabUser, userName, password);
            return _userDataSet.TabUser;
        }

        /// <summary>
        /// Delete a user from User table.
        /// </summary>
        /// <param name="userId">int userId</param>
        /// <returns>int rowsAffected</returns>
        public int DeleteUser(int userId)
        {
            return _tabUserTableAdapter.DeleteUser(userId);
        }

        /// <summary>
        /// Insert a user from User table.
        /// </summary>
        /// <param name="username">string username</param>
        /// <param name="password">string password</param>
        /// <param name="userLevel">int userLevel</param>
        /// <returns>int rowsAffected</returns>
        public int InsertUser(string userName, string userPassword, int userLevel)
        {
            return _tabUserTableAdapter.InsertUser(userName, userPassword, userLevel);
        }

        /// <summary>
        /// Update a user from User table.
        /// </summary>
        /// <param name="userName">string userName</param>
        /// <param name="password">string password</param>
        /// <param name="userLevel">int userLevel</param>
        /// <param name="userId">int userId</param>
        /// <returns>int rowsAffected</returns>
        public int UpdateUser(string userName, string userPassword, int userLevel, int userId)
        {
            return _tabUserTableAdapter.UpdateUser(userName, userPassword, userLevel, userId);
        }

        /// <summary>
        /// Select count in User table by userName.
        /// The count search for user name despite the name of the actual userID.
        /// </summary>
        /// <param name="userName">string userName</param>
        /// <param name="userID">int userID</param>
        /// <returns>int countResult</returns>
        public int SelectCountUserByName(string userName, int userID)
        {
            return (int)_tabUserTableAdapter.SelectCountUserByName(userName, userID);
        }

    }
}

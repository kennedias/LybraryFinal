/* Contains all business logic of User 
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
using DataAccessLayer;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    /// <summary>
    /// Business logic related with the User.
    /// </summary>
    public class UserLogic
    {
        private UserDAO _userDAO; 
        private List<TabUserModel> _users;
        private UserDS.TabUserDataTable _tabUserTable;

        /// <summary>
        /// Constructor method
        /// </summary>
        public UserLogic()
        {
            _userDAO = new UserDAO();
            _users = new List<TabUserModel>();
            _tabUserTable = new UserDS.TabUserDataTable();
        }

        /// <summary>
        /// Returns all users data from table User.
        /// </summary>
        /// <returns>List<TabUserModel></returns>
        public List<TabUserModel> GetAllUser()
        {
            _users = new List<TabUserModel>();

            _tabUserTable = _userDAO.GetAllUser();

            foreach (UserDS.TabUserRow row in _tabUserTable.Rows)
            {
                _users.Add(TabUserModel.Parse(row));

            }
            return _users;
        }

        /// <summary>
        /// Get the user data based on the username and password.
        /// </summary>
        /// <param name="username">string username</param>
        /// <param name="password">string password</param>
        /// <returns>List<TabUserModel></returns>
        public List<TabUserModel> PerformLogin(string username, string password)
        {
            _users = new List<TabUserModel>();

            if (true)
            {
                _tabUserTable = _userDAO.GetLogin(username, password);

                foreach (UserDS.TabUserRow row in _tabUserTable.Rows)
                {
                    _users.Add(TabUserModel.Parse(row));
                }
            }
            return _users;
        }


    }
}


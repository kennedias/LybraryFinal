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
            try
            {
                _users = new List<TabUserModel>();
                _tabUserTable = _userDAO.GetAllUser();

                foreach (UserDS.TabUserRow row in _tabUserTable.Rows)
                {
                    _users.Add(TabUserModel.Parse(row));
                }
                return _users;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                throw new BusinessLogicException(ex.Message);
            }
        }

        /// <summary>
        /// Get the user data based on the username and password.
        /// </summary>
        /// <param name="username">string username</param>
        /// <param name="password">string password</param>
        /// <returns>List<TabUserModel></returns>
        public List<TabUserModel> PerformLogin(string username, string password)
        {
            try
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
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                throw new BusinessLogicException(ex.Message);
            }
        }

        /// <summary>
        /// Update a user from User table.
        /// </summary>
        /// <param name="username">string username</param>
        /// <param name="password">string password</param>
        /// <param name="userLevel">string userLevelDescription</param>
        /// <param name="userID">int userID</param>
        /// <returns>int rowsAffected</returns>
        public int updateUser(string userName, string password, string userLevelDescription, int userID)
        {
            try
            {
                int resultQuery;

                resultQuery = _userDAO.SelectCountUserByName(userName, userID);

                if (resultQuery > 0)
                {
                    throw new BusinessLogicException("User name is already in use.");
                }

                resultQuery = 0;
                int userLevelCode = getUserLevelCodeByLevelDescription(userLevelDescription);
                resultQuery = _userDAO.UpdateUser(userName, password, userLevelCode, userID);
                if (resultQuery < 1)
                {
                    throw new BusinessLogicException("No record were updated.");
                }
                return resultQuery;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                throw new BusinessLogicException(ex.Message);
            }
        }

        /// <summary>
        /// Returns the level description from a level code.
        /// </summary>
        /// <param name="int">int userLevelCode</param>
        /// <returns>string userLevelDescription</returns>
        ///<exception cref="UserException">Thrown when user level code is invalid.</exception>
        public String getUserLevelDescriptionByLevelCode(int userLevelCode)
        {
            try
            {
                string userLevelDescription;
                switch (userLevelCode)
                {
                    case Constants.administratorCode:
                        userLevelDescription = Constants.administratorDescription;
                        break;
                    case Constants.supervisorCode:
                        userLevelDescription = Constants.supervisorDescription;
                        break;
                    case Constants.userCode:
                        userLevelDescription = Constants.userDescription;
                        break;
                    default:
                        throw new BusinessLogicException("Invalid user level code for the code: " + userLevelCode);
                }
                return userLevelDescription;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                throw new BusinessLogicException(ex.Message);
            }
        }

        /// <summary>
        /// Returns the level code from a level description.
        /// </summary>
        /// <param name="string">string userLevelDescription</param>
        /// <returns>int userLevelCode</returns>
        ///<exception cref="UserException">Thrown when user level description is invalid.</exception>
        public int getUserLevelCodeByLevelDescription(string userLevelDescription)
        {
            try
            {
                int userLevelCode;
                switch (userLevelDescription)
                {
                    case Constants.administratorDescription:
                        userLevelCode = Constants.administratorCode;
                        break;
                    case Constants.supervisorDescription:
                        userLevelCode = Constants.supervisorCode;
                        break;
                    case Constants.userDescription:
                        userLevelCode = Constants.userCode;
                        break;
                    default:
                        throw new BusinessLogicException("Invalid user level description for the description: " + userLevelDescription);
                }
                return userLevelCode;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                throw new BusinessLogicException(ex.Message);
            }
        }
    }
}


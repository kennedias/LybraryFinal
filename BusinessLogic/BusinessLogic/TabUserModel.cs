﻿/* Model Object for the User data
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

namespace BusinessLogic
{
    /// <summary>
    /// Model Object of the User data.
    /// </summary>
    /// 
    public class TabUserModel
    {
        # region fields

        private int    _userID;
        private string _userName;
        private int    _userLevelCode;
        private string _userLevelDescription;

        #endregion

        # region properties

        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public int UserLevelCode
        {
            get { return _userLevelCode; }
            set { _userLevelCode = value; }
        }

        public string UserLevelDescription
        {
            get { return _userLevelDescription; }
            set { _userLevelDescription = value; }
        }

        #endregion

        #region methods

        /// <summary>
        /// Parse of data from the DS object to the model object.
        /// Include de description of the user level code.
        /// Returns null if the row is null.
        /// </summary>
        /// <param name="row">UserDS.TabUserRow row</param>
        /// <returns>TabUserModel</returns>
        ///<exception cref="UserException">Thrown when user level code is invalid.</exception>
        public static TabUserModel Parse(UserDS.TabUserRow row) 
        {
            if (row == null)
                return null;
            else
            {
                TabUserModel userModel = new TabUserModel();

                //Model data = Database data
                userModel.UserID = row.UID;
                userModel.UserName = row.UserName;
                userModel.UserLevelCode = row.UserLevel;

                if (userModel.UserLevelCode == Constants.administratorCode)
                    userModel._userLevelDescription = Constants.administratorDescription;
                else if (userModel.UserLevelCode == Constants.supervisorCode)
                    userModel._userLevelDescription = Constants.supervisorDescription;
                else if (userModel.UserLevelCode == Constants.userCode)
                    userModel._userLevelDescription = Constants.userDescription;
                else
                    throw new UserException("Invalid user level code for the userID: " + userModel.UserID
                        + " userName: " + userModel.UserName + " level code: " + row.UserLevel);

                return userModel;

            }
        }

        #endregion

    }
}


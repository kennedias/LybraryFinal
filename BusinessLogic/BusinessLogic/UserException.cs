/* Exceptions used with User data
 * 
 * Project: Assignment 2 - AIT
 * Developer: Kennedy Oliveira - ID 5399
 * Data of release: 07/09/2016
 * Version: 1.0 - Release
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    /// <summary>
    /// Exceptions related with the User.
    /// </summary>
    public class UserException: Exception
    {
        /// <summary>
        /// Exception from User.
        /// </summary>
        /// <param name="message">string message</param>
        public UserException(string message)
        : base(message)
        {
        }
    }
}

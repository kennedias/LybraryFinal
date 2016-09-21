/* Model Object for the ViewBookReservedModel view data
 * 
 * Project: Assignment 2 - AIT
 * Developer: Kennedy Oliveira - ID 5399
 * Data of release: 19/09/2016
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
    /// Model Object of the ViewBookReservedModel view data.
    /// </summary>
    /// 
    public class ViewBookReservedModel
    {
        #region fields

        private string _bookBorrowedISBN;
        private string _bookBorrowedName;
        private string _bookBorrowedAuthorName;
        private string _bookBorrowedUserName;
        private DateTime _bookBorrowedReserveDate;
        private int      _bookBorrowedReserveId;
        private int      _bookBorrowedUserId;
 
        #endregion

        #region Properties

        public string BookBorrowedISBN
        {
            set { _bookBorrowedISBN = value; }
            get { return _bookBorrowedISBN; }
        }

        public string BooBorrowedkName
        {
            set { _bookBorrowedName = value; }
            get { return _bookBorrowedName; }
        }

        public string BookBorrowedAuthorName
        {
            set { _bookBorrowedAuthorName = value; }
            get { return _bookBorrowedAuthorName; }
        }

        public string BookBorrowedUserName
        {
            set { _bookBorrowedUserName = value; }
            get { return _bookBorrowedUserName; }
        }

        public DateTime BookBorrowedReserveDate
        {
            set { _bookBorrowedReserveDate = value; }
            get { return _bookBorrowedReserveDate; }
        }

        public int BookBorrowedReserveId
        {
            set { _bookBorrowedReserveId = value; }
            get { return _bookBorrowedReserveId; }
        }

        public int BookBorrowedUserId
        {
            set { _bookBorrowedUserId = value; }
            get { return _bookBorrowedUserId; }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Parse of data from the DS object to the model object.
        /// Returns null if the row is null.
        /// </summary>
        /// <param name="row">BookDS.ViewBookReserved row</param>
        /// <returns>ViewBookReservedModel</returns>
        public static ViewBookReservedModel Parse(BookDS.ViewBookReservedRow row)
        {
            if (row == null)
                return null;
            else
            {
                ViewBookReservedModel viewBookReservedModel = new ViewBookReservedModel();
                viewBookReservedModel._bookBorrowedISBN = row.ISBN;
                viewBookReservedModel._bookBorrowedName = row.BookName;
                viewBookReservedModel._bookBorrowedAuthorName = row.AuthorName;
                viewBookReservedModel._bookBorrowedUserName = row.UserName;
                viewBookReservedModel._bookBorrowedReserveDate = row.ReservedDate;
                viewBookReservedModel._bookBorrowedReserveId = row.RID;
                viewBookReservedModel._bookBorrowedUserId = row.UID;
                return viewBookReservedModel;
            }
        }
        #endregion
    }
}

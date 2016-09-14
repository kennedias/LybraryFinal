/* Data Access Object for the Book data
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
using DataAccessLayer.BookDSTableAdapters;

namespace DataAccessLayer
{
    /// <summary>
    /// Classe designed for access the Book data.
    /// </summary>
    /// <remarks>
    /// All access of data from Book, tabble and view, should be implemented here.</remarks>
    /// 
    public class BookDAO
    {

        private BookDS _bookDataSet;
        private TabBookTableAdapter _tabBookTableAdapter;        
        private TabReservedTableAdapter _tabReservedTableAdapter;
        private TabBorrowTableAdapter _tabBorrowTableAdapter;
        private ViewBookTableAdapter _viewBookTableAdapter;
        private ViewBookAvailableTableAdapter _viewBookAvailableTableAdapter;
        private ViewBookBorrowedTableAdapter _viewBookBorrowedTableAdapter;

        /// <summary>
        /// Class constructor
        /// </summary>
        public BookDAO()
        {
            //Initialize objects
            _bookDataSet = new BookDS();
            _tabBookTableAdapter = new TabBookTableAdapter();
            _tabReservedTableAdapter = new TabReservedTableAdapter();
            _tabBorrowTableAdapter = new TabBorrowTableAdapter();
            _viewBookTableAdapter = new ViewBookTableAdapter();
            _viewBookAvailableTableAdapter = new ViewBookAvailableTableAdapter();
            _viewBookBorrowedTableAdapter = new ViewBookBorrowedTableAdapter();
        }

        /// <summary>
        /// Returns all registers from Book view.
        /// </summary>
        /// <returns>BookDS.ViewBookDataTable</returns>
        public BookDS.ViewBookDataTable GetAllBooksView()
        {
            _viewBookTableAdapter.FillAllBooks(_bookDataSet.ViewBook);
            return _bookDataSet.ViewBook;
        }

        /* BOOK VIEW */

        /// <summary>
        /// Return registers from Book view filtred by bookName and Author, only bookName or only bookAuthor.
        /// </summary>
        /// <param name="bookname">string bookname</param>
        /// <param name="authorname">string authorname</param>
        /// <returns>BookDS.ViewBookDataTable</returns>
        public BookDS.ViewBookDataTable GetAllBooksViewByBookNameAndAuthor(string bookname, string authorname)
        {
            bookname = "%" + bookname + "%";
            authorname = "%" + authorname + "%";
            _viewBookTableAdapter.FillByBookNameAndAuthorName(_bookDataSet.ViewBook, bookname, authorname);
            return _bookDataSet.ViewBook;
        }

        /// <summary>
        /// Return registers from Book view filtred by ISBN.
        /// </summary>
        /// <param name="isbn">string isbn</param>
        /// <returns>BookDS.ViewBookDataTable</returns>
        public BookDS.ViewBookDataTable GetAllBooksViewByISBN(string isbn)
        {
            _viewBookTableAdapter.FillByISBN(_bookDataSet.ViewBook, isbn);
            return _bookDataSet.ViewBook;
        }


        /* RESERVED BOOK */

        /// <summary>
        /// Return all registers from Reserved.
        /// </summary>
        /// <returns>BookDS.TabReservedDataTable</returns>
        public BookDS.TabReservedDataTable GetAllReserverdBooks()
        {
            _tabReservedTableAdapter.FillAllReservedBooks(_bookDataSet.TabReserved);
            return _bookDataSet.TabReserved;
        }

        /// <summary>
        /// Delete a book reserv from Reserved table.
        /// </summary>
        /// <param name="reservId">int reservId</param>
        /// <returns>int rowsAffected</returns>
     //   public int DeleteBookReserv(int reservId)
     //   {
     //       return _tabUserTableAdapter.DeleteUser(userId);
     //       return _tabReservedTableAdapter.DeleteBookReserv
    //    }

    }
}

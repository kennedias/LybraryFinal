/* Contains all business logic of Book 
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
using System.Data.SqlClient;

namespace BusinessLogic
{
    /// <summary>
    /// Business logic related with the Book.
    /// </summary>
    public class BookLogic
    {
        private BookDAO _bookDAO;
        private List<ViewBookModel> _listBooksView;
        private BookDS.ViewBookDataTable _viewBookView;
        private List<TabReservedModel> _listTabReservedModel;
        private BookDS.TabReservedDataTable _tabReservedDataTable;
        private BookDS.ViewBookBorrowedDataTable _viewBookBorrowedDataTable;
        private List<ViewBookBorrowedModel> _listBooksBorrowedView;
        private BookDS.ViewBookAvailableDataTable _viewBookAvailableDataTable;
        private List<ViewBookAvailableModel> _listBooksAvailableView;


        /// <summary>
        /// Constructor
        /// </summary>
        public BookLogic()
        {
            _bookDAO = new BookDAO();
            _listBooksView = new List<ViewBookModel>();
            _viewBookView = new BookDS.ViewBookDataTable();
            _listTabReservedModel = new List<TabReservedModel>();
            _tabReservedDataTable = new BookDS.TabReservedDataTable();

            _viewBookAvailableDataTable = new BookDS.ViewBookAvailableDataTable();
            _listBooksAvailableView = new List<ViewBookAvailableModel>();
        }

        #region Book View
        /// <summary>
        ///  Returns all books data from view Book.
        /// </summary>
        /// <returns>List<ViewBookModel></returns>
        public List<ViewBookModel> GetAllBooksView()
        {
            _listBooksView = new List<ViewBookModel>();
            _viewBookView = _bookDAO.GetAllBooksView();

            foreach (BookDS.ViewBookRow row in _viewBookView.Rows)
            {
                _listBooksView.Add(ViewBookModel.Parse(row));
            }

            return _listBooksView;
        }

        /// <summary>
        /// Search books using ISBN, book name and author, only book name and only author.
        /// The book name and author are searched with partialy letter, it is not mandotory
        /// to inform the exact name.
        /// </summary>
        /// <param name="bookISBN">string bookISBN</param>
        /// <param name="bookName">string bookName</param>
        /// <param name="author">string author</param>
        /// <returns>List<ViewBookModel></returns>
        public List<ViewBookModel> BookSearch(string bookISBN, string bookName, string author)
        {
            _listBooksView = new List<ViewBookModel>();

            if (bookISBN != "")
            {
                _viewBookView = _bookDAO.GetAllBooksViewByISBN(bookISBN);
            }
            else if (bookName != "" || author != "")
            {
                _viewBookView = _bookDAO.GetAllBooksViewByBookNameAndAuthor(bookName, author);
            }

            foreach (BookDS.ViewBookRow row in _viewBookView.Rows)
            {
                _listBooksView.Add(ViewBookModel.Parse(row));
            }

            return _listBooksView;
        }
        #endregion

        #region Reserved

        /// <summary>
        /// Insert a book reservation into Reserved table.
        /// </summary>
        /// <param name="userId">int userId</param>
        /// <param name="isbn">string isbn</param>
        /// <param name="reservedDate">string reservedDate</param>
        /// <returns>int rowsAffected</returns>
        public int insertBookReserved(int userId, string isbn, string reservedDate)
        {
            int resultQuery = 0;

            resultQuery = SelectCountBookReservedByIsbn(isbn);
            if (resultQuery > 0)
            {
                throw new BookException("Book already reserved.");
            }

            resultQuery = _bookDAO.InsertBookReserved(userId, isbn, reservedDate);
            if (resultQuery == 0)
            {
                throw new BookException("Reserve not inserted.");
            }

        /*    catch (Exception ex)
            {
                //logging for admin to be inspect
            }
            */
            return resultQuery;

        }

        /// <summary>
        /// Select Count(*) from Reserved by ISBN.
        /// </summary>
        /// <param name="reserveId">string isbn</param>
        /// <returns>int numbers of registers found</returns>
        public int SelectCountBookReservedByIsbn(string isbn)
        {
            try
            {
                _bookDAO = new BookDAO();
                return _bookDAO.SelectCountBookReservedByIsbn(isbn);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Delete book Reserve.
        /// </summary>
        /// <param name="reserveId">string isbn</param>
        /// <returns>int rowsAffected</returns>
        public int DeleteBookReserved(int reservedId)
        {
            try
            {
                _bookDAO = new BookDAO();
                return _bookDAO.DeleteBookReserved(reservedId);
            }
            catch
            {
                throw;
            }
        }


        /// <summary>
        /// Return all registers from Reserved table by UserID.
        /// </summary>
        /// <param name="userId">int userId</param>
        /// <returns>List<TabReservedModel></returns>
        public List<TabReservedModel> GetAllReservedBooksByUserId(int userId)
        {
            try
            {
                _listTabReservedModel = new List<TabReservedModel>();
                _tabReservedDataTable = _bookDAO.GetAllReservedBooksByUserId(userId);

                foreach (BookDS.TabReservedDataTable row in _tabReservedDataTable.Rows)
                {
                    _listTabReservedModel.Add(TabReservedModel.Parse(row));
                }

                return _listTabReservedModel;
            }
            catch (SqlException ex)
            {
                // Error log
                Console.WriteLine(ex.ToString());
                throw;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region Book Available

        /// <summary>
        /// Return all registers from Book Available.
        /// </summary>
        /// <returns>List<T</returns>
        public List<ViewBookAvailableModel> GetAllAvailableBooks()
        {
            try
            {
                _listBooksAvailableView = new List<ViewBookAvailableModel>();
                _viewBookAvailableDataTable = _bookDAO.GetAllBooksAvailableView();

                foreach (BookDS.ViewBookAvailableRow row in _viewBookAvailableDataTable.Rows)
                {
                    _listBooksAvailableView.Add(ViewBookAvailableModel.Parse(row));
                }

                return _listBooksAvailableView;
            }
            catch (SqlException ex)
            {
                // Error log
                Console.WriteLine(ex.ToString());
                throw;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region Book Borrowed

        /// <summary>
        /// Return all registers from Book Borrowed.
        /// </summary>
        /// <returns>List<T</returns>
        public List<ViewBookBorrowedModel> GetAllBorrowedBooks()
        {
            try
            {
                _listBooksBorrowedView = new List<ViewBookBorrowedModel>();
                _viewBookBorrowedDataTable = _bookDAO.GetAllBooksBorrowedView();

                foreach (BookDS.ViewBookBorrowedRow row in _viewBookBorrowedDataTable.Rows)
                {
                    _listBooksBorrowedView.Add(ViewBookBorrowedModel.Parse(row));
                }

                return _listBooksBorrowedView;
            }
            catch (SqlException ex)
            {
                // Error log
                Console.WriteLine(ex.ToString());
                throw;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Insert a book borrow into Borrow.
        /// </summary>
        /// <param name="userId">int userId</param>
        /// <param name="isbn">string isbn</param>
        /// <param name="borrowDate">string borrowDate</param>
        /// <param name="returnDate">string returnDate</param>
        /// <param name="actualReturnDate">string actualReturnDate</param>
        /// <param name="lateFee">decimal lateFee</param>
        /// <returns>int rowsAffected</returns>
        public int InsertBorrowBook(int userId, string isbn, string borrowDate, string returnDate, string actualReturnDate, decimal lateFee)
        {

            int resultQuery = 0;

            resultQuery = _bookDAO.SelectCountBookAvailableViewByIsbn(isbn);
            if (resultQuery > 0)
            {
                throw new BookException("Book not available to borrow.");
            }

            resultQuery = _bookDAO.InsertBorrowBook(userId, isbn, borrowDate, returnDate, actualReturnDate, lateFee);
            if (resultQuery == 0)
            {
                throw new BookException("Borrow not completed. Contact the Administrator.");
            }

        /*    catch (Exception ex)
            {
                //logging for admin to be inspect
            }
            */
            return resultQuery;
        }








        #endregion
    }
}

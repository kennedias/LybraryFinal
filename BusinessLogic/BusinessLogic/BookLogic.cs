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
        
        private BookDS.ViewBookDataTable _viewBookView;
        private List<ViewBookModel> _listBooksView;

        private BookDS.TabReservedDataTable _tabReservedDataTable;
        private List<TabReservedModel> _listTabReservedModel;

        private BookDS.ViewBookBorrowedDataTable _viewBookBorrowedDataTable;
        private List<ViewBookBorrowedModel> _listViewBooksBorrowedModel;

        private BookDS.ViewBookAvailableDataTable _viewBookAvailableDataTable;
        private List<ViewBookAvailableModel> _listViewBooksAvailableModel;

        private BookDS.ViewBookReservedDataTable _viewBookReservedDataTable;
        private List<ViewBookReservedModel> _listViewBooksReservedModel;

        private BookDS.ViewBookBorrowedWithUserDataTable _viewBookBorrowedWithUserDataTable;
        private List<ViewBookBorrowedWithUserModel> _listViewBooksBorrowedWithUserModel;



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
            _listViewBooksAvailableModel = new List<ViewBookAvailableModel>();

            _viewBookReservedDataTable = new BookDS.ViewBookReservedDataTable();
            _listViewBooksReservedModel = new List<ViewBookReservedModel>();

            _viewBookBorrowedWithUserDataTable = new BookDS.ViewBookBorrowedWithUserDataTable();
            _listViewBooksBorrowedWithUserModel = new List<ViewBookBorrowedWithUserModel>();

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
                _listViewBooksAvailableModel = new List<ViewBookAvailableModel>();
                _viewBookAvailableDataTable = _bookDAO.GetAllBooksAvailableView();

                foreach (BookDS.ViewBookAvailableRow row in _viewBookAvailableDataTable.Rows)
                {
                    _listViewBooksAvailableModel.Add(ViewBookAvailableModel.Parse(row));
                }

                return _listViewBooksAvailableModel;
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
        /// <returns>List<ViewBookBorrowedModel></returns>
        public List<ViewBookBorrowedModel> GetAllBorrowedBooks()
        {
            try
            {
                _listViewBooksBorrowedModel = new List<ViewBookBorrowedModel>();
                _viewBookBorrowedDataTable = _bookDAO.GetAllBooksBorrowedView();

                foreach (BookDS.ViewBookBorrowedRow row in _viewBookBorrowedDataTable.Rows)
                {
                    _listViewBooksBorrowedModel.Add(ViewBookBorrowedModel.Parse(row));
                }

                return _listViewBooksBorrowedModel;
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

        /// <summary>
        /// Return all registers from Book Borrowed by UserId.
        /// </summary>
        /// <param name="userId">int userId</param>
        /// <returns>List<ViewBookBorrowedModel></returns>
        public List<ViewBookBorrowedModel> GetAllBorrowedBooksByUserId(int userId)
        {
            try
            {
                _listViewBooksBorrowedModel = new List<ViewBookBorrowedModel>();
                _viewBookBorrowedDataTable = _bookDAO.GetAllBooksBorrowedView();

                foreach (BookDS.ViewBookBorrowedRow row in _viewBookBorrowedDataTable.Rows)
                {
                    _listViewBooksBorrowedModel.Add(ViewBookBorrowedModel.Parse(row));
                }

                return _listViewBooksBorrowedModel;
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

        #region BookViewReserved
        /// <summary>
        ///  Returns all books data from view BookViewReserved.
        /// </summary>
        /// <returns>List<ViewBookReservedModel></returns>
        public List<ViewBookReservedModel> GetAllBooksReservedView()
        {
            _listViewBooksReservedModel = new List<ViewBookReservedModel>();
            _viewBookReservedDataTable = _bookDAO.GetAllBooksReservedView();

            foreach (BookDS.ViewBookReservedRow row in _viewBookReservedDataTable.Rows)
            {
                _listViewBooksReservedModel.Add(ViewBookReservedModel.Parse(row));
            }

            return _listViewBooksReservedModel;
        }

        /// <summary>
        ///  Returns all books data from view BookViewReserved By UserId.
        /// </summary>
        /// <param name="userId">int userId</param>
        /// <returns>List<ViewBookReservedModel></returns>
        public List<ViewBookReservedModel> GetAllBooksReservedViewByUserId(int userId)
        {
            _listViewBooksReservedModel = new List<ViewBookReservedModel>();
            _viewBookReservedDataTable = _bookDAO.GetAllBooksReservedViewByUserId(userId);

            foreach (BookDS.ViewBookReservedRow row in _viewBookReservedDataTable.Rows)
            {
                _listViewBooksReservedModel.Add(ViewBookReservedModel.Parse(row));
            }

            return _listViewBooksReservedModel;
        }

        #endregion

        #region BookViewBorrowedWithUser
        /// <summary>
        ///  Returns all books data from view ViewBookBorrowedWithUser.
        /// </summary>
        /// <returns>List<ViewBookBorrowedWithUserModel></returns>
        public List<ViewBookBorrowedWithUserModel> GetAllBooksBorrowedWithUserView()
        {
            _listViewBooksBorrowedWithUserModel = new List<ViewBookBorrowedWithUserModel>();
            _viewBookBorrowedWithUserDataTable = _bookDAO.GetAllBooksBorrowedWithUserView();

            foreach (BookDS.ViewBookBorrowedWithUserRow row in _viewBookBorrowedWithUserDataTable.Rows)
            {
                _listViewBooksBorrowedWithUserModel.Add(ViewBookBorrowedWithUserModel.Parse(row));
            }

            return _listViewBooksBorrowedWithUserModel;
        }

        /// <summary>
        ///  Returns all books data from view ViewBookBorrowedWithUser By UserId.
        /// </summary>
        /// <param name="userId">int userId</param>
        /// <returns>List<ViewBookBorrowedWithUserModel></returns>
        public List<ViewBookBorrowedWithUserModel> GetAllBooksBorrowedWithUserViewByUserId(int userId)
        {
            _listViewBooksBorrowedWithUserModel = new List<ViewBookBorrowedWithUserModel>();
            _viewBookBorrowedWithUserDataTable = _bookDAO.GetAllBooksBorrowedWithUserViewByUserId(userId);

            foreach (BookDS.ViewBookBorrowedWithUserRow row in _viewBookBorrowedWithUserDataTable.Rows)
            {
                _listViewBooksBorrowedWithUserModel.Add(ViewBookBorrowedWithUserModel.Parse(row));
            }

            return _listViewBooksBorrowedWithUserModel;
        }

        #endregion
    }
}

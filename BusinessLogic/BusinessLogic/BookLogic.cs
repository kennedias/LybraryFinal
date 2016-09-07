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

        /// <summary>
        /// Constructor
        /// </summary>
        public BookLogic()
        {
            _bookDAO = new BookDAO();
            _listBooksView = new List<ViewBookModel>();
            _viewBookView = new BookDS.ViewBookDataTable();
        }

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

    }
}

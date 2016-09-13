/* Data Access Object for the Author, Category and Language data
 * 
 * Project: Assignment 2 - AIT
 * Developer: Kennedy Oliveira - ID 5399
 * Data of release: 13/09/2016
 * Version: 1.0 - Release
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.MasterDSTableAdapters;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    /// <summary>
    /// Classe designed for access the  Author, Category and Language data.
    /// </summary>
    /// <remarks>
    /// All access of data from  Author, Category and Language should be implemented here.</remarks>
    /// 
    public class MasterDAO
    {
        private MasterDS _masterDataSet;
        private TabAuthorTableAdapter _tabAuthorTableAdapter;
        private TabCategoryTableAdapter _tabCategoryTableAdapter;
        private TabLanguageTableAdapter _tabLanguageTableAdapter;

        /// <summary>
        /// Class Constructor
        /// </summary>
        public MasterDAO()
        {
            _masterDataSet = new MasterDS();
            _tabAuthorTableAdapter = new TabAuthorTableAdapter();
            _tabCategoryTableAdapter = new TabCategoryTableAdapter();
            _tabLanguageTableAdapter = new TabLanguageTableAdapter();
        }


        /* AUTHOR */

        /// <summary>
        /// Returns all registers from TabAuthor
        /// </summary>
        /// <returns>MasterDS.TabAuthorDataTable</returns>
        public MasterDS.TabAuthorDataTable GetAllAuthors()
        {
            _tabAuthorTableAdapter.FillAll(_masterDataSet.TabAuthor);
            return _masterDataSet.TabAuthor;
        }

        /// <summary>
        /// Delete register from TabAuthor.
        /// It HAVE to be done a select first in the Book table to certificate that the Author
        /// is not in use for any register.        
        /// </summary>
        /// <param name="authorID">int authorID</param>
        /// <returns>int rowsAffected</returns>
        public int DeleteAuthor(int authorID)
        {
            return (int)_tabAuthorTableAdapter.DeleteAuthor(authorID);
        }

        /// <summary>
        /// Insert register into TabAuthor.
        /// </summary>
        /// <param name="authorName">string authorName</param>
        /// <returns>int rowsAffected</returns>
        public int InsertAuthor(string authorName)
        {
            return (int)_tabAuthorTableAdapter.InsertAuthor(authorName);
        }

        /// <summary>
        /// Select count in Author table by authorName.
        /// </summary>
        /// <param name="authorName">string authorName</param>
        /// <returns>int countResult</returns>
        public int SelectCountUserByAuthorName(string authorName)
        {
            return (int)_tabAuthorTableAdapter.SelectCountByAuthorName(authorName);
        }


        /// <summary>
        /// Update register from TabAuthor.
        /// </summary>
        /// <param name="authorName">string authorName</param>
        /// <param name="authorID">int authorID</param>
        /// <returns>int rowsAffected</returns>
        public int UpdateAuthor(string authorName, int authorID)
        {
            return (int)_tabAuthorTableAdapter.UpdateAuthor(authorName, authorID);
        }


        /* CATEGORY */


        /// <summary>
        /// Returns all registers from TabCategory
        /// </summary>
        /// <returns>MasterDS.TabCategoryDataTable</returns>
        public MasterDS.TabCategoryDataTable GetAllCategories()
        {
            _tabCategoryTableAdapter.FillAll(_masterDataSet.TabCategory);
            return _masterDataSet.TabCategory;
        }

        /// <summary>
        /// Delete register from TabCategory.
        /// It HAVE to be done a select first in the Book table to certificate that the Category
        /// is not in use for any register.        
        /// </summary>
        /// <param name="categoryID">int categoryID</param>
        /// <returns>int rowsAffected</returns>
        public int DeleteCategory(int categoryID)
        {
            return (int)_tabCategoryTableAdapter.DeleteCategory(categoryID);
        }

        /// <summary>
        /// Insert register into TabCategory.
        /// </summary>
        /// <param name="categoryName">string categoryName</param>
        /// <returns>int rowsAffected</returns>
        public int InsertCategory(string categoryName)
        {
            return (int)_tabCategoryTableAdapter.InsertCategory(categoryName);
        }

        /// <summary>
        /// Select count in TabCategory table by categoryName.
        /// </summary>
        /// <param name="categoryName">string categoryName</param>
        /// <returns>int countResult</returns>
        public int SelectCountUserByCategoryName(string categoryName)
        {
            return (int)_tabCategoryTableAdapter.SelectCountByCategoryName(categoryName);
        }


        /// <summary>
        /// Update register from TabCategory.
        /// </summary>
        /// <param name="categoryName">string categoryName</param>
        /// <param name="authorID">int authorID</param>
        /// <returns>int rowsAffected</returns>
        public int UpdateCategory(string categoryName, int authorID)
        {
            return (int)_tabCategoryTableAdapter.UpdateCategory(categoryName, authorID);
        }



        /* Language */

        /// <summary>
        /// Returns all registers from TabLanguage
        /// </summary>
        /// <returns>MasterDS.TabLanguageDataTable</returns>
        public MasterDS.TabLanguageDataTable GetAllLanguages()
        {
            _tabLanguageTableAdapter.FillAll(_masterDataSet.TabLanguage);
            return _masterDataSet.TabLanguage;
        }

        /// <summary>
        /// Delete register from TabLanguage.
        /// It HAVE to be done a select first in the Book table to certificate that the Category
        /// is not in use for any register.        
        /// </summary>
        /// <param name="languageID">int languageID</param>
        /// <returns>int rowsAffected</returns>
        public int DeleteLanguage(int languageID)
        {
            return (int)_tabLanguageTableAdapter.DeleteLanguage(languageID);
        }

        /// <summary>
        /// Insert register into TabLanguage.
        /// </summary>
        /// <param name="languageName">string languageName</param>
        /// <returns>int rowsAffected</returns>
        public int InsertLanguage(string languageName)
        {
            return (int)_tabLanguageTableAdapter.InsertLanguage(languageName);
        }

        /// <summary>
        /// Select count in TabLanguage table by langaugeName.
        /// </summary>
        /// <param name="languageName">string languageName</param>
        /// <returns>int countResult</returns>
        public int SelectCountUserByLanguageName(string languageName)
        {
            return (int)_tabLanguageTableAdapter.SelectCountByLanguageName(languageName);
        }


        /// <summary>
        /// Update register from TabLanguage.
        /// </summary>
        /// <param name="languageName">string languageName</param>
        /// <param name="languageID">int languageID</param>
        /// <returns>int rowsAffected</returns>
        public int UpdateLanguage(string languageName, int languageID)
        {
            return (int)_tabLanguageTableAdapter.UpdateLanguage(languageName, languageID);
        }

    }
}

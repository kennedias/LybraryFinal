using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public static class AppEnum
    {
        public enum ViewBook
        {
            Isbn,
            BookName,
            Publisher,
            PublishYear,
            Pages,
            Author,
            Category,
            Language
        }

        public enum ViewBookReserved
        {
            Isbn,
            Name,
            Author,
            User,
            ReserveDate,
            ReserveId,
            UserId

        }

        public enum TabUser
        {
            ID,
            Name,
            LevelCode,
            LevelDescription
        }


        public enum ViewBookBorrowedWithUserModel
        {
            ISBN,
            Name,
            Author,
            User,
            Borrow,
            Return,
            LateFee,
            UserId,
            BorrowId
        }

        public enum TabMasterModel
        {
            ID,
            Description
        }
    }
}

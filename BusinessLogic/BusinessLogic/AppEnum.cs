﻿using System;
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
            UserId,

        }

        /*
         * label.text = dataGridView.SelectedRows[].Cells[(int)AppEnum.ViewBook.Isbn].Value.ToString();
         * 
         * strok
         */
    }
}

using System;
using System.Collections.Generic;
using LibraryApplication.Model;

namespace LibraryApplication.DAL
{
    public class BookDAO
    {
        private static List<Book> ListOfBook = new List<Book>();

        public static bool Register(Book b)
        {

            foreach (Book item in ListOfBook)
            {
                if (!b.BookName.Equals(item.BookName))
                {
                    ListOfBook.Add(item.BookName);
                    return true;
                }
            }

            return false;
    }
    }

   
}

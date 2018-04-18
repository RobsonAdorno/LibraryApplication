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
                if (b.BookName.Equals(item.BookName))
                {
                    return false;
                }
            }

            ListOfBook.Add(b);
            return true;
    }

        public static bool CallRegister(string name){

            foreach (Book item in ListOfBook)
            {
                if (name.Equals(item.BookName))
                {
                    return true;
                }
            }

            return false;
        }

        public static List<Book> CallTheList(){
            return ListOfBook;
        }
    }

   
}

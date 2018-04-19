using System;
using LibraryApplication.Model;
using System.Collections.Generic;

namespace LibraryApplication.DAL
{
    public class GiveBackDAO
    {
        private static List<Book> ListGiveBack = new List<Book>();

        public static bool RegisterGiveBack(Book b){

            foreach (Book item in ListGiveBack)
            {
                if (item.BookName.Equals(b.BookName))
                {
                    return false;

                }
            }

            ListGiveBack.Add(b);
            return true;
           
        }
    }
}

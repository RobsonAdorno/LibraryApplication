using System;
using LibraryApplication.Model;
using System.Collections.Generic;

namespace LibraryApplication.DAL
{
    public class GiveBackDAO
    {
        private static List<GiveBack> ListGiveBack = new List<GiveBack>();


        public static bool TratamentOfError(string book){
            Book b = new Book();

            foreach (LendABook item in LendABookDAO.ReturnStatus())
            {
                Console.WriteLine(item.Book.BookName);
                if (item.Book.BookName.Equals(book) && item.Status == true)
                {
                    item.Status = false;
                    return true;
                }
            }

            return false;
        }
       

        public static GiveBack CallGiveBack(GiveBack g)
        {
                 Book b = new Book();
            LendABook aBook = new LendABook();
                foreach (GiveBack item in ListGiveBack)
                    {
                        if (!item.Book.BookName.Equals(b.BookName))
                        {
                            return item;
                        }
                    }
            return null;
        }
        public static bool RegisterGiveBack(GiveBack b)
        {
           
            if (CallGiveBack(b) == null)
                {
                ListGiveBack.Add(b);
                return true;
            }

            return false;

        }

        public static List<GiveBack> CallBack(){
            return ListGiveBack;
        }

    }
}

using System;
using System.Collections.Generic;
using LibraryApplication.Model;

namespace LibraryApplication.DAL
{
    public class LendABookDAO
    {
        private static List<LendABook> ListOfLend = new List<LendABook>();


        public static LendABook RegisterLend(LendABook l){
            foreach (LendABook item in ListOfLend)
            {
                Console.WriteLine(item.Status);
                if (item.Book.BookName.Equals(l.Book.BookName) && item.Status == true)
                {
                    return item;
                }
            }

            return null;

        }

        public static bool CallLend(LendABook l){
            LendABook lend = new LendABook();
            if (RegisterLend(l) == null)
            {
                ListOfLend.Add(l);
                return true;
            }

            return false;
        }

        public static List<LendABook> ReturnStatus()
        {

            return ListOfLend;
        }
    }
}

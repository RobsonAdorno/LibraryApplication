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
                if (item.Book.BookName.Equals(l.Book.BookName)){
                    l.Status = true;
                    return item;
                }

            }

            return null;

        }

        public static bool CallLend(LendABook l){
            if (RegisterLend(l) == null && l.Status == false)
            {
                Console.WriteLine(l.Status = true);
                ListOfLend.Add(l);
                return true;
            }

            return false;
        }

        public static List<LendABook> lstagem()
        {

            return ListOfLend;
        }
    }
}

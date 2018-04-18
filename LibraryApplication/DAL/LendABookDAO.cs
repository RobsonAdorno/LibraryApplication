using System;
using System.Collections.Generic;
using LibraryApplication.Model;

namespace LibraryApplication.DAL
{
    public class LendABookDAO
    {
        private static List<LendABook> ListOfLend = new List<LendABook>();



        public static bool RegisterLend(LendABook l){
            foreach (LendABook item in ListOfLend)
            {
                Console.WriteLine(item.NameClient);
                if (item.Equals(l.Book.BookName) && (item.NameClient == null)){
                    return true;
                }

            }

            return false;

        }

        public static bool CallLend(LendABook l){
            if (RegisterLend(l))
            {
                return false;
            }
            ListOfLend.Add(l);
            return true;
        }

    }
}

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
                if (item.Book.BookName.Equals(l.Book.BookName))
                {
                    return item;
                }


            }

            return null;

        }
        public static GiveBack Verification(LendABook b)
        {

            foreach (GiveBack item in GiveBackDAO.CallBack())
            {
                try
                {
                    if (item.Book.BookName.Equals(b.Book.BookName))
                    {
                        return item;
                    }

                }catch(Exception){
                    return null;
                }
            }
            return null;
        }

        public static bool CallLend(LendABook l){
            if (RegisterLend(l) == null && Verification(l) == null)
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

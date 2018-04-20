using System;
using LibraryApplication.Model;
using System.Collections.Generic;

namespace LibraryApplication.DAL
{
    public class GiveBackDAO
    {
        private static List<GiveBack> ListGiveBack = new List<GiveBack>();

        public static GiveBack CallGiveBack(GiveBack g){

            foreach (GiveBack item in ListGiveBack)
            {
                if (item.Book.BookName.Equals(g.Book.BookName))
                {
                    g.LendABook.Status = false;
                    return item;
                }
            }

            return null;
        }


        public static bool RegisterGiveBack(GiveBack b){

            foreach (GiveBack item in ListGiveBack)
            {
                if (CallGiveBack(b) == null && b.LendABook.Status == true)
                {
                    return false;

                }else{

                    b.LendABook.Status = false;
                    ListGiveBack.Add(b);

                }
            }

           
            return true;
           
        }
    }
}

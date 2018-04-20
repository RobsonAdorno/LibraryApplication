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
                try
                {
                    if (item.Book.BookName.Equals(g.Book.BookName))
                    {
                        return item;
                    }

                    }
                catch (Exception)
                {
                    Console.WriteLine("Por favor, cadastrar um emprestimo primeiro!");
                }

            }

            return null;
        }


        public static bool RegisterGiveBack(GiveBack b){

            foreach (GiveBack item in ListGiveBack)
            {
                if (CallGiveBack(b) == null && !Verification(b))
                {
                    ListGiveBack.Add(b);
                    return true;

                }
            }

            return false;
           
        }

        public static bool Verification(GiveBack b){
            
            foreach (LendABook item in LendABookDAO.ReturnStatus())
            {
                if (item.Book.BookName.Equals(b.Book.BookName))
                {
                    return true;
                }
            }

            return false;
        }

        public static List<GiveBack> CallBack(){
            return ListGiveBack;
        }

    }
}

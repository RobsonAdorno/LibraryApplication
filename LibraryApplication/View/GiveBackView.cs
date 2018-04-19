using System;
using LibraryApplication.Model;
using LibraryApplication.DAL;

namespace LibraryApplication.View
{
    public class GiveBackView
    {
        public static void Checked()
        {
            Book book = new Book();
            Console.WriteLine("Por favor, digite o nome do livro");
            book.BookName = Console.ReadLine();

            if(GiveBackDAO.RegisterGiveBack(book)){
                
            }
        }
    }
}

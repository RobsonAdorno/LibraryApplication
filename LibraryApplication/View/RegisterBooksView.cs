using System;
using LibraryApplication.Model;
using LibraryApplication.DAL;
namespace LibraryApplication.View
{
    public class RegisterBooksView
    {
        public static void ShowRegisterBookView()
        {
            Book book = new Book();

            Console.WriteLine("Digite o nome do livro, por favor!");
            book.BookName = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de páginas do livro!");
            book.PagesOfBook = Console.ReadLine();
            book.CurrentDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
          
            if (BookDAO.Register(book) == null)
            {
                Console.WriteLine("Livro " + book.BookName + " cadastrado com sucesso!");

            }
            else
            {
                Console.WriteLine("Erro! Livro já cadastrado!");
            }
            Console.WriteLine("Digite qualquer tecla para voltar ao menu principal!");
            Console.ReadKey();

        }







       
    }
}

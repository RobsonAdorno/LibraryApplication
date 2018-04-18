using System;
using LibraryApplication.DAL;
using LibraryApplication.Model;

namespace LibraryApplication.View
{
    public class LendBookView
    {
        public static void Checked(){
            LendABook lb = new LendABook();
            Book book = new Book();
            Console.WriteLine("Por favor, qual o nome do livro?");
            book.BookName =  Console.ReadLine();
            if (BookDAO.CallRegister(book.BookName)){
                Console.WriteLine("Encontrado o cadastro do livro: " + book.BookName + " na base de dados!");

                lb.Book.BookName = book.BookName;

                Console.WriteLine("Por favor, digite o nome do cliente!");
                lb.NameClient = Console.ReadLine();
                lb.DateLend = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                if (LendABookDAO.RegisterLend(lb)){

                    Console.WriteLine("Emprestimo efetuado com sucesso, para o(a) " + lb.NameClient + " !");
                }else{
                    Console.WriteLine("Livro já está emprestado!");
                }

            }else
            {
                Console.WriteLine("Não encontramos o livro cadastrado em nossa base de dados!");
            }

            Console.WriteLine("Por favor, pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
        }

    }
}

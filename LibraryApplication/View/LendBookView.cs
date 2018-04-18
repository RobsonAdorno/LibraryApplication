using System;
using LibraryApplication.DAL;
using LibraryApplication.Model;

namespace LibraryApplication.View
{
    public class LendBookView
    {
        public static void Checked(){
            LendABook lb = new LendABook();
            Console.WriteLine("Por favor, qual o nome do livro?");
            string name = Console.ReadLine();
            if (BookDAO.CallRegister(name)){

                Console.WriteLine("Encontrado o cadastro do livro: " + name + " na base de dados!");

                Console.WriteLine("Por favor, digite o nome do cliente!");
                lb.NameClient = Console.ReadLine();
                lb.DateLend = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            }else
            {
                Console.WriteLine("Não encontramos o livro cadastrado em nossa base de dados!");
            }

            Console.WriteLine("Por favor, pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
        }

    }
}

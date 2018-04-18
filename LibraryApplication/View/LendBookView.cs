using System;
using LibraryApplication.DAL;

namespace LibraryApplication.View
{
    public class LendBookView
    {
        public static void Checked(){
            Console.WriteLine("Por favor, qual o nome do livro?");
            string name = Console.ReadLine();
            if (BookDAO.CallRegister(name)){

                Console.WriteLine("Encontrado o cadastro do livro: " + name + " na base de dados!");
            }else
            {
                Console.WriteLine("Não encontramos o livro cadastrado em nossa base de dados!");
            }

            Console.WriteLine("Por favor, pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
        }

    }
}

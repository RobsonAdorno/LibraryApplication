using System;
using LibraryApplication.Model;
using LibraryApplication.DAL;

namespace LibraryApplication.View
{
    public class ShowOperation
    {

        public static void Checked()
        {
            //Console.WriteLine("Por favor, digite o nome do livro");

            LendABook lend = new LendABook();
            foreach ( LendABook item in LendABookDAO.ReturnStatus())
            {

                Console.WriteLine("Nome: " + item.Book.BookName);
                Console.WriteLine("Páginas : " + item.Book.PagesOfBook);
                Console.WriteLine("Data de Cadastro: " + item.Book.CurrentDate);
                if (item.Status == true)
                {
                    Console.WriteLine("--- Movimentaçãoes ---\n");
                    Console.WriteLine("Tipo: Emprestimo! \t\t Cliente: " + item.NameClient + "\t Data: " + item.DateLend);
                }else{
                    
                    Console.WriteLine("Tipo: Devolução! \t\t Cliente: " + item.NameClient + "\t Data: " + item.GiveBack.givebackdate);
                }
            }

            Console.WriteLine("Pressione um botao para sair");
            Console.ReadKey();

        }
    }
}

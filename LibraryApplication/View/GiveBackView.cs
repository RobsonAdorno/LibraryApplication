using System;
using LibraryApplication.Model;
using LibraryApplication.DAL;

namespace LibraryApplication.View
{
    public class GiveBackView
    {
        public static void Checked()
        {
            LendABook lend = new LendABook();
            Book book = new Book();
            GiveBack giveBack = new GiveBack();
            Console.WriteLine("Por favor, digite o nome do livro");
            book.BookName = Console.ReadLine();

            if(GiveBackDAO.TratamentOfError(book.BookName)){
                Console.WriteLine("Livro está emprestado!");
                lend.Status = false;
                Console.WriteLine("Você gostaria realmente de devolver o livro? [S/N]");
                string decision = Console.ReadLine();

                if (decision.Equals("S"))
                {
                    giveBack.givebackdate = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                    if (GiveBackDAO.RegisterGiveBack(giveBack))
                    {
                        Console.WriteLine("Devolução com sucesso!");
                        lend.Status = false;
                        GiveBackDAO.RegisterGiveBack(giveBack);
                    }
                    else
                    {
                        Console.WriteLine("Não foi possivel realizar devolucao!");
                    }
                }

            }else{
                Console.WriteLine("Desculpa, esse livro não está emprestado!");
            }

           
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
        }
    }
}

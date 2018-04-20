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
            GiveBack giveBack = new GiveBack();
            Console.WriteLine("Por favor, digite o nome do livro");
            book.BookName = Console.ReadLine();

            if(GiveBackDAO.RegisterGiveBack(giveBack)){
                Console.WriteLine("Livro está cadastrado na base de dados!");
            }else{
                Console.WriteLine("Desculpa, esse livro não está cadastrado em nossa base de dados!");
            }

            Console.WriteLine("Você gostaria realmente de devolver o livro? [S/N]");
            string decision = Console.ReadLine();

            if (decision.Equals("S") && !decision.Equals("N"))
            {
                giveBack.givebackdate = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                if (GiveBackDAO.RegisterGiveBack(giveBack)){

                    Console.WriteLine("Devolução com sucesso!");
                }else{
                    Console.WriteLine("Não foi possivel realizar devolucao!");
                }
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
        }
    }
}

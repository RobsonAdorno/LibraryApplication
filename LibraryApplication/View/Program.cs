using System;

namespace LibraryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            do
            {
                Console.WriteLine("Selecione abaixo a opção desejada!");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1 – Cadastrar Livro");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("2 – Emprestar Livro");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("3 – Devolver Livro");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("4 – Histórico de movimentação do livro");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("5 – Consultar Livro");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("0 – Sair");
                 op = Console.ReadLine();

                switch (op)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    case "0":
                        Console.WriteLine("Encerrando...");
                        break;

                    default:
                        Console.WriteLine("Opção não encontrada!");
                        break;
                }

            } while (op != "0");






        }
    }
}

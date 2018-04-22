using System;
using LibraryApplication.DAL;
using LibraryApplication.Model;
using LibraryApplication.View;

namespace LibraryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            do
            {
                Console.Clear();
                LendABook lend = new LendABook();
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
                Console.WriteLine("-----------------------------------");
                Console.WriteLine(" ");
                 op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        RegisterBooksView.ShowRegisterBookView();
                        break;
                    case "2":
                        LendBookView.Checked();
                        break;
                    case "3":
                        GiveBackView.Checked();
                        break;
                    case "4":
                        ShowOperation.Checked();
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

using System;

namespace LibraryApplication.Model
{


    public class LendABook
    {
        public LendABook()
        {
            Book = new Book();
            GiveBack = new GiveBack();

        }
        public string NameClient { get; set; }
        public string DateLend { get; set; }
        public Book Book { get; set; }
        public GiveBack GiveBack { get; set; }
        public bool Status { get; set; }

		public override string ToString()
		{
                return "Nome do livro : " + Book.BookName +
             "Quantidade de páginas : " + Book.PagesOfBook +                               
           "\nNome do Cliente: " + NameClient +
           "\nData do Emprestimo: " + DateLend +
           "\nData do Cadastro: " + Book.CurrentDate+
          "\nStatus:" + Status;
           
		}

	}





}

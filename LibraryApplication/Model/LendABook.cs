using System;

namespace LibraryApplication.Model
{


    public class LendABook
    {
        public LendABook()
        {
            Book = new Book();
        }

        public string NameClient { get; set; }
        public string DateLend { get; set; }
        public Book Book { get; set; }

		public override string ToString()
		{
            return "Nome do livro : " + Book.BookName+
             "\nNome do Cliente: " + NameClient +
             "\nData do Emprestimo: " + DateLend;
		}

	}





}

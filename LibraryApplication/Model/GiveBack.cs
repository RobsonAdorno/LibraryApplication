using System;
using LibraryApplication.Model;

namespace LibraryApplication.Model
{
    public class GiveBack
    {
        public GiveBack()
        {
            Book = new Book();
        }

        public Book Book { get; set; }
        public LendABook LendABook { get; set; }
        public string givebackdate { get; set; }

		public override string ToString()
		{
            return "Nome do livro: " + Book.BookName +
            "Data da devolução: " + givebackdate +
            "Status :" + LendABook.Status;
		}
	}

   
}

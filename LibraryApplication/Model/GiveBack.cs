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
        public string givebackdate { get; set; }

		public override string ToString()
		{
            return "Nome do livro: " + Book.BookName;     
		}
	}

   
}

using System;
namespace LibraryApplication.Model
{
    public class Book
    {
        public string BookName { get; set; }
        public string PagesOfBook { get; set; }
        public string CurrentDate { get; set; }

		public override string ToString()
		{
            return PagesOfBook; 
		}

	}


}

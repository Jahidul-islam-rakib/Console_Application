using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
	public class Book
	{
		public int BId {  get; set; }
		public string BTitle { get; set; }
		public string Auther { get; set; }
        public int BIsbn { get; set; }

        public Book(int id, string title, string auther, int isbn)
        {
            BId = id;
            BTitle = title;
            Auther = auther;
            BIsbn = isbn;
        }
    }
}

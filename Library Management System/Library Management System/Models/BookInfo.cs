using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
	    public class BookInfo
	{
		public int id { get; set; }

		public string BookName { get; set; }

		public string  BookAuthor { get; set; }

		public string BookPublicationName { get; set; }

		public DateTime BookPurchaseDate { get; set; }

		public string BookPrice { get; set; }

		public int BookQuantity { get; set; }
	}
}

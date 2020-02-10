using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Library_Management_System.Models;
using Library_Management_System.Forms;

namespace Library_Management_System.Services
{
	class BookService : BaseService
	{
		public void insert(BookInfo book)
		{
			_connection.Open();

			string Query = "INSERT INTO BookInfo([BookName],[BookAuthor],[BookPublicationName],[BookPurchaseDate],[BookPrice],[BookQuantity]) VALUES('" + book.BookName + "','" + book.BookAuthor + "','" + book.BookPublicationName + "','" + book.BookPurchaseDate + "','" + book.BookPrice + "','" + book.BookQuantity + "') ;";
			SqlCommand command = new SqlCommand(Query, _connection);

			command.ExecuteNonQuery();
			//          try
			//          {
			//              conDatabase.Open();
			//              reader = CmdDatabase.ExecuteReader();
			//              MessageBox.Show("Book Saved");
			//              while (reader.Read())
			//              {

			//              }
			//          }
			//          catch (Exception ex)
			//          {
			//              MessageBox.Show(ex.Message);
			//          }
			_connection.Close();
			//}



			//}

			//public void delete(int id)
			//{
			//	_connection.Open();


			//	_connection.Close();

			//}

			//public List<BookInfo> GetAll()
			//{
			//	_connection.Open();


			//	_connection.Close();

			//}
			//public BookInfo GetById()
			//{
			//	_connection.Open();


			//	_connection.Close();

			//}

			//public void Update(BookInfo book)
			//{
			//	_connection.Open();


			//	_connection.Close();

			//}
		}
	}
}

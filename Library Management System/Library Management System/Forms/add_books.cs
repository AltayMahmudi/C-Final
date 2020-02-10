using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library_Management_System.Data;
using Library_Management_System.Models;


namespace Library_Management_System.Forms
{
    public partial class add_books : Form
    {
		private readonly LibraryDbContext _context;
        public add_books()
        {

			_context = new LibraryDbContext();

            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBookName.Name))
            {
                MessageBox.Show("Insert Book Name");
                return;
            }
            BookInfo book = new BookInfo();
            book.BookName = textBoxBookName.Text;
            book.BookAuthor = textBoxAuthor.Text;
            book.BookPublicationName = textBoxPublication.Text;
            book.BookPurchaseDate =DateTime.Parse(dateTimePickerBook.Text);
            book.BookPrice = textBoxPrice.Text;
            book.BookQuantity = int.Parse(textBoxQuantity.Text);

			_context.Books.Add(book);
			_context.SaveChanges();
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;

            if (ch == 46 && textBoxPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void add_books_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.LibManagementSysConnectionString);
        }

   
    }
}

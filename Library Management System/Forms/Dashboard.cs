using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_System.Data;
using Library_Management_System.Models;

namespace Library_Management_System.Forms
{
	public partial class Dashboard : Form
	{

		BookEntities db = new BookEntities();
		BookInfo book= new BookInfo();
		public Dashboard()
		{
			InitializeComponent();
			PopulateDataGridView();
		}

		void PopulateDataGridView() 
		{
			using (BookEntities db=new BookEntities())

			{
				DGVBooks.DataSource = db.Bookİnfos.ToList<BookInfo>();
			}
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
	
			Clear();
		}
		void Clear()
		{
			textBoxBookName.Text = textBoxAuthor.Text = textBoxPublication.Text = textBoxPrice.Text = textBoxQuantity.Text = "";
			BTNSave.Text = "Save";
			BTNBookDelete.Enabled = false;
			book.BookID = 0;
		}

		private void SearchBook_TextChanged(object sender, EventArgs e)
		{
			DGVBooks.DataSource = db.Bookİnfos.Where(x => x.BookName.Contains(SearchBook.Text) || x.BookAuthor.Contains(SearchBook.Text)).ToList();
		}

		private void SearchPrice_TextChanged(object sender, EventArgs e)
		{
			DGVBooks.DataSource = db.Bookİnfos.Where(x => x.BookPrice.Contains(SearchPrice.Text)).ToList();
		}

		private void InsertNewBook_Click(object sender, EventArgs e)
		{

			book.BookName = textBoxBookName.Text.Trim();
			book.BookAuthor = textBoxAuthor.Text.Trim();
			book.BookPublicationName = textBoxPublication.Text.Trim();
			book.BookPurchaseDate = dateTimePickerBook.Value;
			book.BookQuantity = textBoxQuantity.Text.Trim();
			book.BookPrice = textBoxPrice.Text.Trim();
            using (BookEntities db = new BookEntities()) 

            {
                if (book.BookID == 0)
                db.Bookİnfos.Add(book); //Insert

                else db.Entry(book).State=EntityState.Modified;
				db.SaveChanges(); //update
				
			}
			
			Clear();
			PopulateDataGridView();
			MessageBox.Show("Submit Successfull");
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

		private void DGVBooks_DoubleClick_1(object sender, EventArgs e)
		{
			if (DGVBooks.CurrentRow.Index != -1)
			{
				book.BookID = Convert.ToInt32(DGVBooks.CurrentRow.Cells["BookID"].Value);
				using (BookEntities db = new BookEntities())
				{
					book = db.Bookİnfos.Where(x => x.BookID == book.BookID).FirstOrDefault();
					textBoxBookName.Text = book.BookName;
					textBoxAuthor.Text = book.BookAuthor;
					textBoxPublication.Text = book.BookPublicationName;
					dateTimePickerBook.Value = book.BookPurchaseDate;
					textBoxQuantity.Text = book.BookQuantity;
					textBoxPrice.Text = book.BookPrice;

				}
				BTNSave.Text = ("Update");
				BTNBookDelete.Enabled = true;
			}
		}

		private void BTNBookDelete_Click_1(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure to Delete this", "EF CRUD Op", MessageBoxButtons.YesNo) == DialogResult.Yes)
				using (BookEntities db = new BookEntities())
				{
					var entry = db.Entry(book);
					if (entry.State == EntityState.Detached)
						db.Bookİnfos.Attach(book);
					db.Bookİnfos.Remove(book);
					db.SaveChanges();
					//PopulateDataGridView
					PopulateDataGridView();
					Clear();
					MessageBox.Show("Deleted Successfully");
				}
		}

		private void BTNCancel_Click_1(object sender, EventArgs e)
		{
			Clear();
		}


    }
		
}

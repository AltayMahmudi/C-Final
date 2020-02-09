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

namespace Library_Management_System.Forms
{
    public partial class add_books : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.LibManagementSysConnectionString);
        public add_books()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string constring = (Properties.Settings.Default.LibManagementSysConnectionString);
            string Query = "insert into BookInfo (BookName,BookAuthor,BookPublicationName,BookPurchaseDate,BookPrice,BookQuantity )" + "values('" + this.textBoxBookName.Text + "','" + this.textBoxAuthor.Text + "','" + this.textBoxPublication.Text + "','" + this.dateTimePickerBook.Text + "','" + this.textBoxPrice.Text + "','" + this.textBoxQuantity.Text + "') ;";
            SqlConnection conDatabase = new SqlConnection(constring);
            SqlCommand CmdDatabase = new SqlCommand(Query, conDatabase);
            SqlDataReader reader;
            try
            {
                conDatabase.Open();
                reader = CmdDatabase.ExecuteReader();
                MessageBox.Show("Book Saved");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
    }
}

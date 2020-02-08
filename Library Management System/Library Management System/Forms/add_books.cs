using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
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

 

        
    }
}

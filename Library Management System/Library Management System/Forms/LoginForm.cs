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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.LibManagementSysConnectionString);
        int count = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Login_Person where Username='"+ TxtboxUsername.Text + "' and password='"+ TxtboxPassword.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            count = Convert.ToInt32(dataTable.Rows.Count.ToString());
            if (count == 0) 
            {
                MessageBox.Show("Wrong/Empty Username or Password ");
            }
        
            else 
            {
                this.Hide();
                mdi_user mu = new mdi_user();
                mu.Show();
            }

           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
    }
}

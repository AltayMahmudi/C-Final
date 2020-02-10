using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library_Management_System.Services
{
	public abstract class BaseService
	{
		protected SqlConnection _connection;

		public BaseService()
			{
			_connection = new SqlConnection(Properties.Settings.Default.LibManagementSysConnectionString);
			
     }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Library_Management_System.Models;

namespace Library_Management_System.Data
{
	public class LibraryDbContext : DbContext
	{
		public LibraryDbContext() : base(Properties.Settings.Default.LibManagementSysConnectionString)
		{ }
			public DbSet<BookInfo> Books { get; set; }
		    public DbSet<Login_Person> Users { get; set; }

	}
}

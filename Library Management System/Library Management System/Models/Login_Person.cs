using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{

    public class Login_Person
    {
        public int İd { get; set; }
        public int Username { get; set; }

        public string Password { get; set; }

		public int BookInfoId { get; set; }

		public BookInfo BookInfo { get; set; }
	}
}

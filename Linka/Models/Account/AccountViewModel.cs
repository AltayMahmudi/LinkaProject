using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Linka.Models.Account;

namespace Linka.Models.Account
{
	public class AccountViewModel
	{
		public RegisterViewModel Register { get; set; }
		public LogInViewModel LogIn { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Account
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Required")]
		[EmailAddress(ErrorMessage = "Use valid E-Mail address")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required(ErrorMessage = "Required")]
		[MinLength(6, ErrorMessage = "Reached Minimum Allowed Length")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		public bool RememberMe { get; set; }
	}
}

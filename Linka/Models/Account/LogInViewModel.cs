using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Linka.Models.Account
{
	public class LogInViewModel
	{
		[Required(ErrorMessage = "Required")]
		[MaxLength(50, ErrorMessage = "Reached Maximum allowed Length")]
		[EmailAddress(ErrorMessage = "Use valid E-Mail address")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required(ErrorMessage = "Required")]
		[MaxLength(50, ErrorMessage = "Reached Maximum allowed Length")]
		[MinLength(6, ErrorMessage = "Reached Minimum Allowed Length")]
		[DataType(DataType.Password)]
		public string Password { get; set; }



		public bool RememberMe { get; set; }



	}
}

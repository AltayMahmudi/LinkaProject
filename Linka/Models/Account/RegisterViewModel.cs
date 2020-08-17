using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Linka.Models.Account
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage ="Required")]
		[MaxLength(50,ErrorMessage ="Reached Maximum allowed Length")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Required")]
		[MaxLength(50, ErrorMessage = "Reached Maximum allowed Length")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Required")]
		[MaxLength(50, ErrorMessage = "Reached Maximum allowed Length")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Required")]
		[MaxLength(50, ErrorMessage = "Reached Maximum allowed Length")]
		[MinLength(6, ErrorMessage = "Reached Minimum Allowed Length")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required(ErrorMessage = "Required")]
		[MaxLength(50, ErrorMessage = "Reached Maximum allowed Length")]
		[MinLength(6, ErrorMessage = "Reached Minimum Allowed Length")]
		[Compare("Password", ErrorMessage = "Password doesn't match")]
		[DataType(DataType.Password)]
		public string PasswordConfirm { get; set; }

		[Required(ErrorMessage = "Required")]
		[MaxLength(50, ErrorMessage = "Reached Maximum allowed Length")]
		[EmailAddress(ErrorMessage = "Use valid E-Mail address")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

	}
}

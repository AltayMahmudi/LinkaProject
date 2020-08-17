using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LinkaRepository.Models
{
	public class Admin:BaseEntity
	{
		[Required]
		[MaxLength(59)]
		public string FullName { get; set; }
		[Required]
		[MaxLength(59)]
		public string Email { get; set; }
		[Required]
		[MaxLength(100)]
		public string Password { get; set; }

		[MaxLength(59)]
		public string Token { get; set; }

		[MaxLength(59)]
		public string ForgetToken { get; set; }



	}
}

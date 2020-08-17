using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LinkaRepository.Models
{
	public class ProductPhoto:BaseEntity
	{
		public int ProductId { get; set; }
		public int OrderBy { get; set; }

		[Required]
		[MaxLength(100)]
		public string Image { get; set; }
		public Product Product { get; set; }
	}
}

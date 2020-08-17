using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LinkaRepository.Models
{
	public class BlogPhoto:BaseEntity
	{
		public int BlogId { get; set; }
		public int OrderBy { get; set; }

		[Required]
		[MaxLength(100)]
		public string Image { get; set; }
		public Blog Blog  { get; set; }

	}
}

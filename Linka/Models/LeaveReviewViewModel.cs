using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Linka.Models
{
	public class LeaveReviewViewModel
	{

		public int ProductId { get; set; }
		[Required]
		[Range(1,5)]
		public byte Star { get; set; } 
		[Required]
        [MaxLength (50)]
		public string Title { get; set; } = "";
		[Required]
		[MaxLength(1500)]
		public string Review { get; set; } = "";
	}
}

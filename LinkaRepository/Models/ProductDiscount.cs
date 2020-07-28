using System;
using System.Collections.Generic;
using System.Text;

namespace LinkaRepository.Models
{
	public class ProductDiscount:BaseEntity
	{
		public int Id { get; set; }

		public int DiscountId { get; set; }

		public int ProductId { get; set; }

		public Discount Discount { get; set; }

		public Product Product { get; set; }
	}
}

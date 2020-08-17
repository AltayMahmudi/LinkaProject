using LinkaRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Admin.Models.Shopping
{
	public class ProductViewModel 
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public byte StarCount { get; set; }
		public decimal Price { get; set; }
		public decimal DiscountPrice { get; set; }
		public bool IsSale { get; set; }
		public string SKU { get; set; }
		public bool Status { get; set; }
		public string Description { get; set; }
		public IList<string> Photos { get; set; }

	}
}

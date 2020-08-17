using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Linka.Models
{
	public class ProductViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public byte StarCount { get; set; }
		public decimal Price { get; set; }
		public decimal DiscountPrice { get; set; }
		public IList<string> Image { get; set; }
		//public CategoryViewModel Category { get; set; }
		public bool IsSale { get; set; }
		public string SKU { get; set; }

		public string Description { get; set; }
		public IList<string> Photos { get; set; }

		public IList<ReviewViewModel> Reviews { get; set; }
		public IList<ProductSpecViewModel> ProductSpecs { get; set; }


	}
}

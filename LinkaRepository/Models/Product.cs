using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LinkaRepository.Models
{
	public class Product:BaseEntity
	{
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        [Required]
        [MaxLength(150)]
        public string SKU { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }


        public decimal? DiscountPrice { get; set; }

    
        [Required]
        public bool IsSale { get; set; }

        [Required]
        public byte StarCount { get; set; }

        public ICollection<ProductReview> Reviews { get; set; }
        public ICollection<ProductDiscount> Discounts { get; set; }




    }
}

using System;
using System.Collections.Generic;
using System.Text;
using LinkaRepository.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace LinkaRepository.Data
{
	public class LinkaDbContext:DbContext
	{
		public LinkaDbContext(DbContextOptions<LinkaDbContext> options) : base(options) { }


        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDiscount> ProductDiscounts { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<ProductSpecs> ProductSpecs { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

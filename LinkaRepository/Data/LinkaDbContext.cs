using System;
using System.Collections.Generic;
using System.Text;
using LinkaRepository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Repository.Models;

namespace LinkaRepository.Data
{
	public class LinkaDbContext:DbContext
	{
		public LinkaDbContext(DbContextOptions<LinkaDbContext> options) : base(options) { }


        public DbSet<Product> Products { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<ProductSpecs> ProductSpecs { get; set; }
        public DbSet<ProductPhoto> Photos { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogPhoto> BlogPhotos { get; set; }

        public DbSet<Admin> Admins { get; set; }

    }
}

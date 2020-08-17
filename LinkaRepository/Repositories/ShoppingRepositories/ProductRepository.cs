using LinkaRepository.Data;
using LinkaRepository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkaRepository.Repositories.ShoppingRepositories
{
	public interface IProductRepository
	{
		IEnumerable<Product> GetProducts(int limit);
		Product GetProductById(int id);
		Product GetProductOnlyById(int id);
		void CreateReview(ProductReview productReview);
		IEnumerable<Product> GetProducts();
		Product CreateProduct(Product product);
	}
	public class ProductRepository:IProductRepository
	{
	
		private readonly LinkaDbContext _context;

		public ProductRepository(LinkaDbContext context)
		{
			_context = context;

		}

	

		public Product GetProductById(int id)
		{
			return _context.Products.Include("Photos").Include("Reviews").Include("ProductSpecs").FirstOrDefault(p => p.Status && p.Id == id);
		}
		
		public IEnumerable<Product> GetProducts(int limit)
		{
			return _context.Products.Include("Photos").Where(p => p.Status).OrderByDescending(p => p.AddedDate).Take(limit).ToList();
		}

		public Product GetProductOnlyById(int id)
		{

			return _context.Products.Include("Photos").Include("Reviews").Include("ProductSpecs").FirstOrDefault(p => p.Status && p.Id == id);


		}

		public void CreateReview(ProductReview productReview)
		{
			_context.ProductReviews.Add(productReview);
			_context.SaveChanges();
		}

		public IEnumerable<Product> GetProducts()
		{
			return _context.Products.Include("Photos").ToList();

		}

		public Product CreateProduct(Product product)
		{
			product.AddedDate = DateTime.Now;
			_context.Products.Add(product);
			_context.SaveChanges();
			return product;
		}
	}
	
}

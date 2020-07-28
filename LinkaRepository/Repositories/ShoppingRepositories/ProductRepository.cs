using LinkaRepository.Data;
using LinkaRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkaRepository.Repositories.ShoppingRepositories
{
	public class ProductRepository:IProductRepository
	{
		private readonly LinkaDbContext _context;
		public ProductRepository(LinkaDbContext context)
		{
			_context = context;
		}
	}
	
}

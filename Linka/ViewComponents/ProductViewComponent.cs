using AutoMapper;
using Linka.Models;
using LinkaRepository.Models;
using LinkaRepository.Repositories.ShoppingRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linka.ViewComponents
{
	public class ProductViewComponent:ViewComponent
	{
		private readonly IMapper _mapper;
		private readonly IProductRepository _productRepository;
		public ProductViewComponent(IMapper mapper, IProductRepository productRepository) 
		{
			_mapper = mapper;
			_productRepository = productRepository;
		}
		public IViewComponentResult Invoke()
		{
			var products = _productRepository.GetProducts(6);
			var model = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
			return View(model);
		}
	}
}

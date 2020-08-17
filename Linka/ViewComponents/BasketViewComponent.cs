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
	public class BasketViewComponent:ViewComponent
	{
		private readonly IMapper _mapper;
		private readonly IBasketRepository _basketRepository;
		public BasketViewComponent(IMapper mapper, IBasketRepository basketRepository) 
		{
			_mapper = mapper;
			_basketRepository = basketRepository;
		}
		public IViewComponentResult Invoke() 
		{
			Request.Cookies.TryGetValue("token", out string token);
			var basketItems = _basketRepository.GetBasketsByToken(token);
			var model = _mapper.Map<IEnumerable<Basket>, IEnumerable<BasketViewModel>>(basketItems);
			return View(model);
		}

	}
}

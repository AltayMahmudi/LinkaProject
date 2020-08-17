using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Linka.Models;
using LinkaRepository.Models;
using LinkaRepository.Repositories.ShoppingRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Linka.Controllers
{
    public class CartController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBasketRepository _basketRepository;
        public CartController(IMapper mapper ,IBasketRepository basketRepository)
        {
            _mapper = mapper;
            _basketRepository = basketRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Remove(int id) 
        {
            var basket = _basketRepository.GetBasketById(id);

            if (basket == null) return NotFound();

            Request.Cookies.TryGetValue("token", out string token);

            if (basket.Token != token) return NotFound();

            _basketRepository.RemoveBasket(basket);

            var basketItems = _basketRepository.GetBasketsByToken(token);
            var basketModel = _mapper.Map<IEnumerable<Basket>, IEnumerable<BasketViewModel>>(basketItems);
            var total = 0M;
            var finaltotal = 0M;

            foreach (var item in basketItems)
            {
                var price = item.Product.Price;
                var discountPrice = item.Product.DiscountPrice;
                if (discountPrice == 0)
                {
                    total += (price * item.Count);

                    int x = 50;

                    finaltotal = (total + x);
                }
                else {
                    total += (discountPrice * item.Count);

                    int x = 50;

                    finaltotal = (total + x);
                }


            }
            return Ok(new
            {
                count = basketItems.Count(),
                total = total.ToString("0.00"),
                finaltotal = finaltotal.ToString("0.00")
            });
          
            
        }

        public IActionResult Add(int id) 
        {
            Request.Cookies.TryGetValue("token", out string token);
            var basketItem = _basketRepository.GetBasketByProductIdAndToken(id, token);
            if (basketItem == null)
            {
                Basket basket = new Basket
                {
                    ProductId = id,
                    Token = token,
                    Count = 1,
                    AddedBy = "System",
                    ModifiedBy = "System"

                };
                _basketRepository.CreateBasket(basket);

            }
            else 
            {
                _basketRepository.ChangeCount(basketItem, basketItem.Count+1);
            }
            var basketItems = _basketRepository.GetBasketsByToken(token);
            var basketModel = _mapper.Map<IEnumerable<Basket>, IEnumerable<BasketViewModel>>(basketItems);
            var total = 0M;
            var finaltotal = 0M;

            foreach (var item in basketItems)
            {
                var price = item.Product.Price;
                var discountPrice = item.Product.DiscountPrice;
                if (discountPrice == 0)
                {
                    total += (price * item.Count);

                    int x = 50;

                    finaltotal = (total + x);
                }
                else
                {
                    total += (discountPrice * item.Count);

                    int x = 50;

                    finaltotal = (total + x);
                }


            }
            return Ok(new
            {
                count = basketItems.Count(),
                total = total.ToString("0.00"),
                finaltotal = finaltotal.ToString("0.00")
            });
        }
    }
}
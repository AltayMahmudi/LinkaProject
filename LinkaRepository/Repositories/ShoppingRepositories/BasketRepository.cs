using LinkaRepository.Data;
using LinkaRepository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkaRepository.Repositories.ShoppingRepositories
{
	public interface IBasketRepository 
	{
		IEnumerable<Basket> GetBasketsByToken(string token);
		Basket CreateBasket(Basket basket);
		Basket GetBasketById(int id);
		void RemoveBasket(Basket basket);
		Basket GetBasketByProductIdAndToken(int ProductId, string token);
		void ChangeCount(Basket basketItem, int count);
		void UpdateBasketsToken(string guestToken, string userToken);
	}
	public class BasketRepository : IBasketRepository 
	{
		private readonly LinkaDbContext _context;
		public BasketRepository(LinkaDbContext context)
		{
			_context = context;
		}

		public void ChangeCount(Basket basketItem, int count)
		{
			_context.Entry(basketItem).State = EntityState.Modified;
			basketItem.Count = count;
			_context.SaveChanges();
		}

		public Basket CreateBasket(Basket basket)
		{
			basket.AddedDate = DateTime.Now;
			basket.ModifiedDate = DateTime.Now;

			_context.Baskets.Add(basket);
			_context.SaveChanges();
			return basket;

		}

		public Basket GetBasketById(int id)
		{
			return _context.Baskets.Find(id);
		}

		public Basket GetBasketByProductIdAndToken(int ProductId, string token)
		{
			return _context.Baskets.FirstOrDefault(b => b.ProductId == ProductId && b.Token == token);
		}

		public IEnumerable<Basket> GetBasketsByToken(string token)
		{
			return _context.Baskets.Include("Product").Include("Product.Photos").Where(b => b.Token == token).ToList();
		}

		public void RemoveBasket(Basket basket)
		{
			_context.Baskets.Remove(basket);
			_context.SaveChanges();
		}

		public void UpdateBasketsToken(string guestToken, string userToken)
		{
			foreach (var item in _context.Baskets.Where(b => b.Token == guestToken).ToList()) 
			{
				item.Token = userToken;
			}
			_context.SaveChanges();

		}
	}
}

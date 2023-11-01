using LuzyMart.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LuzyMart.Data
{
	public class MartRepository : IMartRepository
	{
		private readonly MartDbContext _martDbContext;
		public MartRepository(MartDbContext martDbContext)
		{
			_martDbContext = martDbContext;
		}

		public Product GetProductbyId(Guid id)
		{
			var product = _martDbContext.Products.Include(x => x.Images).FirstOrDefault(p => p.Id == id);
			return product;
		}

		public ICollection<Product> GetProductByName(string productName)
		{
			ICollection<Product> products = new List<Product>();
			try
			{

				products = _martDbContext.Products
					 .Include(p => p.Images)
					 .Where(p => p.ProductName.ToUpper().StartsWith(productName.ToUpper()))
					 .ToList();
			}
			catch (Exception ex)
			{

			}

			return products;
		}

		public ICollection<Product> GetAllProducts()
		{
			return _martDbContext.Products.Include(x => x.Images).ToList();
		}
	}
}

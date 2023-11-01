using LuzyMart.Data;
using LuzyMart.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LuzyMart.Controllers
{
	public class ProductController : Controller
	{
		public IMartRepository _martRepository;
		public ProductController(IMartRepository martRepository)
		{
			_martRepository = martRepository;
		}
		[HttpGet]
		public IActionResult Page()
		{
			var products = _martRepository.GetAllProducts();
			return View(products);
		}
		public IActionResult Details(Guid productId)
		{
			var product = _martRepository.GetProductbyId(productId);
			return View(product);
		}

		[HttpPost]
		public IActionResult Page(string productName)
		{
			var products = _martRepository.GetProductByName(productName);
			return View(products);
		}


	}
}

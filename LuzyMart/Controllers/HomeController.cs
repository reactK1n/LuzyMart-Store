using LuzyMart.Data;
using LuzyMart.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LuzyMart.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMartRepository _martRepository;
        public HomeController(IMartRepository mart)
        {
            _martRepository = mart;

        }

        public IActionResult Index()
        {
            var products = _martRepository.GetAllProducts();
            return View(products);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

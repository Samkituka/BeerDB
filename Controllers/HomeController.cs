using BeerDB.Data;
using BeerDB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BeerDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BeerContext _beerContext;

        public HomeController(ILogger<HomeController> logger, BeerContext beerContext )
        {
            _logger = logger;
            _beerContext = beerContext;
        }

        public IActionResult Index()
        {
            var model = _beerContext.Beers.ToList();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using E2ETesting.Models;
using Microsoft.AspNetCore.Mvc;

namespace E2ETesting.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(HomeViewModel? model)
        {
            model ??= new HomeViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Increment(HomeViewModel model)
        {
            model.Count++;
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult Decrement(HomeViewModel model)
        {
            model.Count--;
            return View("Index", model);
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

using Jurassic_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Jurassic_Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DinoDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, DinoDbContext d)
        {
            _logger = logger;
            _dbContext = d;
        }

        public IActionResult Index()
        {
            List<Dino> dinos = _dbContext.dinosaurs.ToList();
            dinos.Reverse();
            ViewBag.dinos = dinos;
            return View();
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
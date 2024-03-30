using Microsoft.AspNetCore.Mvc;
using Select2Demo.Models;
using Select2Demo.Repositories;
using System.Diagnostics;

namespace Select2Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }             
        public IActionResult Info()
        {
            return View();
        }        
        public IActionResult SelectSimple()
        {
            List<string> colors = RepositoryColors.GetColors();
            return View(colors);
        }
        [HttpPost]
        public IActionResult SelectSimple(string color)
        {
            ViewData["RESULTS"] = color;
            List<string> colors = RepositoryColors.GetColors();
            return View(colors);
        }        
        public IActionResult SelectMultiple()
        {
            List<string> colors = RepositoryColors.GetColors();
            return View(colors);
        }
        [HttpPost]
        public IActionResult SelectMultiple(List<string> color)
        {
            ViewData["RESULTS"] = color;
            List<string> colors = RepositoryColors.GetColors();
            return View(colors);
        }
        public IActionResult SelectStyling()
        {
            List<string> colors = RepositoryColors.GetColors();
            return View(colors);
        }
        [HttpPost]
        public IActionResult SelectStyling(string color)
        {
            ViewData["RESULTS"] = color;
            List<string> colors = RepositoryColors.GetColors();
            return View(colors);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

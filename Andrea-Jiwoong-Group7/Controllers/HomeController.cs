using Andrea_Jiwoong_Group7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Andrea_Jiwoong_Group7.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BookTicket()
        {
            return View("BookTicket");
        }

        [HttpPost]
        public IActionResult PostBookTicket(string departureStn, string arrivalStn)
        {
            ViewData["departureStn"] = departureStn;
            ViewData["arrivalStn"] = arrivalStn;
            return View("ShowTicket");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
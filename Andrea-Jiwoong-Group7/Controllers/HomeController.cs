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

        [HttpGet]
        public IActionResult BookTicket()
        {
            return View("BookTicket");
        }

        [HttpPost]
        public IActionResult PostBookTicket(
            string departureStn, string arrivalStn, string seatClass, string seatBerth, string holderName, string email)
        {
            ViewData["departureStn"] = departureStn;
            ViewData["arrivalStn"] = arrivalStn;
            ViewData["seatClass"] = seatClass;
            ViewData["seatBerth"] = seatBerth;
            ViewData["holderName"] = holderName;
            ViewData["email"] = email;

            return View("ShowTicket");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
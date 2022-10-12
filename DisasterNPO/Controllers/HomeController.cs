using DisasterNPO.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DisasterNPO.Controllers
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
            return View("Index");
        }

        public IActionResult Login()
        {
            return View("Login");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Disaster()
        {
            return View();
        }

       public IActionResult ViewingDisaster()
        {
            return View(UserController.disasterModels);
        }


        public IActionResult Money()
        {
            return View();
        }

        public IActionResult Balance()
        {
            return View();
        }

        public IActionResult ViewinMoney()
        {
            return View(UserController.moneyModels);
        }

        public IActionResult Donation()
        {
            return View();
        }


        public IActionResult Viewing()
        {
            return View(UserController.donationModels)  ;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
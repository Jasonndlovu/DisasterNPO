using DisasterNPO.Data;
using DisasterNPO.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DisasterNPO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Class _dbContext;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _dbContext = new Class("Server=tcp:appr6312-10129876.database.windows.net,1433;Initial Catalog=Grand_Central;Persist Security Info=False;User ID=JasonN42;Password=khanajj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
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
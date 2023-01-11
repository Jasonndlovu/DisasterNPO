using DisasterNPO.Data;
using DisasterNPO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace DisasterNPO.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Class _dbContext;

        DisasterModel DM = new DisasterModel();
        DonationModel DMT = new DonationModel();
        MoneyModel MM = new MoneyModel();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _dbContext = new Class("Server=tcp:disasternpodbserver.database.windows.net,1433;Initial Catalog=DisasterNPO_db;Persist Security Info=False;User ID=JasonN42;Password=Khanajj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Login()
        {
            return View();
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
            return View(DM.Information2());
            //return View(UserController.disasterModels);
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
            return View(MM.Information());
        }

        public IActionResult Donation()
        {
            return View();
        }


        public IActionResult Viewing()
        {
            return View(DMT.Information1());
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
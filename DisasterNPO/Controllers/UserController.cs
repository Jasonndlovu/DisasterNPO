using DisasterNPO.Models;
using Microsoft.AspNetCore.Mvc;

namespace DisasterNPO.Controllers
{
    public class UserController:Controller

    {
        private readonly DisasterNPOContext context;
        public static List<MoneyModel> moneyModels = new List<MoneyModel>();
        public static List<DonationModel> donationModels = new List<DonationModel>();
        public static List<DisasterModel> disasterModels = new List<DisasterModel>();

        public UserController()
        {
            context = new DisasterNPOContext();
        }

        [HttpPost]
        public ActionResult Verify(LoginModel vw) 
        {
             return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Register(Register register)
        {
            //if(!ModelState.IsValid)
            //    return View(register);

            //context.Registers.Add(register);
            //context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Disaster(DisasterModel dw)
        {

           // if (ModelState.Count > 1)
           //    return View(dw);


            //context.Disaster.Add(dw);
            //context.SaveChanges();

            disasterModels.Add(dw);

            return ToIndex();
        }
        [HttpPost]
        public ActionResult Money(MoneyModel mw)
        {
            //if (ModelState.Count > 1)
            //    return View(mw);


            //context.Money.Add(mw);
            //context.SaveChanges();

            moneyModels.Add(mw);

            return ToIndex();
        }
        [HttpPost]
        public ActionResult Donation(DonationModel dt)
        {

            //if (ModelState.Count > 1)
            //    return View(dt);


            //context.Donation.Add(dt);
            //context.SaveChanges();

            donationModels.Add(dt);

            return ToIndex();
        }
      
        private ActionResult ToIndex()
        {
            return RedirectToAction("Index", "Home");

        }

    }
} 

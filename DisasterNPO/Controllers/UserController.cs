using DisasterNPO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;

namespace DisasterNPO.Controllers
{
    
    public class UserController:Controller

    {
        SqlConnection con = new SqlConnection("Server=tcp:disasternpodbserver.database.windows.net,1433;Initial Catalog=DisasterNPO_db;Persist Security Info=False;User ID=JasonN42;Password=Khanajj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;

        private readonly DisasterNPOContext context;
        public static List<MoneyModel> moneyModels = new List<MoneyModel>();
        
        
        public static int Balance;
        internal static string? disasterModels;

        //Disaster Model
        public int Id { get; set; }
        public string Aidtypes { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public int Money_allocated { get; set; }

        public DisasterModel DisasterModel { get; private set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public UserController()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            context = new DisasterNPOContext();
        }



        








        [HttpPost]
        public ActionResult Login(LoginModel vw) 
        {
            
            String User = vw.Username.ToString();
            String Password = vw.Password.ToString();
            if (User != null && Password != null)
            {
                con.Open();
                cmd = new SqlCommand($"SELECT UserName FROM Users WHERE UserName='{User}' AND Password = '{Password}';", con);
                int Testing = cmd.ExecuteNonQuery();
                //int Testing = cmd.ExecuteReader();
                con.Close();
                return RedirectToAction("Index", "Home");
                //if (Testing == 1) { return RedirectToAction("Index", "Home");}
    
                
            }

            return View(vw);
        }

        [HttpPost]
        public ActionResult Register(Register register)
        {
           String newUserName = register.Username.ToString();
           String newPassword = register.RegPassword.ToString();
            if (newUserName != null && newPassword != null) {
                con.Open();
                cmd = new SqlCommand($"INSERT INTO Users (UserName, Password) VALUES ('{newUserName}', '{newPassword}');", con);
                cmd.ExecuteNonQuery();
                con.Close();
                return RedirectToAction("Index", "Home");
            }
            return View(register);
        }

        [HttpPost]
        public ActionResult Disaster(DisasterModel dw)
        {
            String AidTypes = dw.Aidtypes.ToString();
            String StartDate = dw.StartDate.ToString();
            String EndDate = dw.EndDate.ToString();
            String Location = dw.Location.ToString();
            String Description = dw.Description.ToString();
            String MoneyAllocated = dw.MoneyAccocated.ToString();
            if (true)
            {
                con.Open();
                cmd = new SqlCommand($"INSERT INTO Disaster (Aidtypes,StartDate,EndDate,Location,Description,MoneyAccocated) VALUES ('{AidTypes}', '{StartDate}','{EndDate}','{Location}','{Description}',{MoneyAllocated});", con);
                int Testing = cmd.ExecuteNonQuery();
                //int Testing = cmd.ExecuteReader();
                con.Close();
                
                //if (Testing == 1) { return RedirectToAction("Index", "Home");}
            }            
            return RedirectToAction("Index", "Home");


        }
        [HttpPost]
        public ActionResult Money(MoneyModel mw)
        {
            String Money = mw.Money;
            String Date = mw.Date.ToString();
            String Name = mw.Name.ToString();
            if (true)
            {
                con.Open();
                cmd = new SqlCommand($"INSERT INTO MoneyDonations (Money, Date, Name) VALUES ('{Money}', '{Date}','{Name}');", con);
                int Testing = cmd.ExecuteNonQuery();
                //int Testing = cmd.ExecuteReader();
                con.Close();
                return RedirectToAction("Index", "Home");
                //if (Testing == 1) { return RedirectToAction("Index", "Home");}
            }
        }
        [HttpPost]
        public ActionResult Donation(DonationModel dt)
        {
            String Item = dt.Item.ToString();
            String Units = dt.Units.ToString();
            String Category = dt.category.ToString();
            if (true)
            {
                con.Open();
                cmd = new SqlCommand($"INSERT INTO donations (Item, category, units) VALUES ('{Item}', '{Category}','{Units}');", con);
                int Testing = cmd.ExecuteNonQuery();
                //int Testing = cmd.ExecuteReader();
                con.Close();
                return RedirectToAction("Index", "Home");
                //if (Testing == 1) { return RedirectToAction("Index", "Home");}
            }

            
        }
      
        private ActionResult ToIndex()
        {
            return RedirectToAction("Index", "Home");

        }

    }
} 

using DisasterNPO.Controllers;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace DisasterNPO.Models
{



	public class Balance
	{

        UserController user = new UserController();

        public int Id { get; set; }
        // public int balance { get; set; }
        public int balance = UserController.Balance;
        //public string RegPassword { get; set; } = null!;
    }
}

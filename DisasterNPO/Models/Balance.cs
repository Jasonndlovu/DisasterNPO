using DisasterNPO.Controllers;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Data.SqlClient;

namespace DisasterNPO.Models
{



	public class Balance
	{

        UserController user = new UserController();
        SqlConnection con = new SqlConnection("");
        public int Id { get; set; }
        // public int balance { get; set; }
        public int balance = UserController.Balance;
        //public string RegPassword { get; set; } = null!;





    }
}

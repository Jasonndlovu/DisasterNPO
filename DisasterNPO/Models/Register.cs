using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Data.SqlClient;

namespace DisasterNPO.Models
{
	public class Register
	{
        SqlConnection con = new SqlConnection("Server=tcp:disasternpodbserver.database.windows.net,1433;Initial Catalog=DisasterNPO_db;Persist Security Info=False;User ID=JasonN42;Password=Khanajj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd;
        public string Username { get; set; } = null!;
		public string RegPassword { get; set; } = null!;


		public Register() {

            con.Open();
            cmd = new SqlCommand($"INSERT INTO Users (UserName, Password) VALUES ('{Username}', '{RegPassword}');", con);

            //cmd.ExecuteNonQuery();
            con.Close();


        }
    }


}

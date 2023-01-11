using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Data.SqlClient;

namespace DisasterNPO.Models
{
    
    public class Chart
    {

        public static SqlConnection con = new SqlConnection("Server=tcp:disasternpodbserver.database.windows.net,1433;Initial Catalog=DisasterNPO_db;Persist Security Info=False;User ID=JasonN42;Password=Khanajj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //SqlCommand cmd;




        
        public int Money { get; set; }
        public int Donations { get; set; }
        public int Disasters { get; set; }

        public void Information()
        {
                //Select count(Item) as id_count FROM [dbo].[donations]
                string sql_line = $"Select count(Item) as id_count FROM [dbo].[donations]";
                SqlCommand cmd = new SqlCommand(sql_line, con);
                con.Open();
                //var dataId = Convert.ToInt32(cmd.ExecuteScalar());
                Donations = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();   
        }

        public void Information2()
        {
            //Select count(Item) as id_count FROM [dbo].[donations]
            string sql_line = $"Select count(money) as id_count FROM [dbo].[MoneyDonations]";
            SqlCommand cmd = new SqlCommand(sql_line, con);
            con.Open();
            //var dataId = Convert.ToInt32(cmd.ExecuteScalar());
            Money = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
        }

        public void Information3()
        {
            //Select count(Item) as id_count FROM [dbo].[donations]
            string sql_line = $"Select count(Aidtypes) as id_count FROM [dbo].[Disaster]";
            SqlCommand cmd = new SqlCommand(sql_line, con);
            con.Open();
            //var dataId = Convert.ToInt32(cmd.ExecuteScalar());
            Disasters = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
        }



    }

    
}

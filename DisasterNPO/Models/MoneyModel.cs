using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Data.SqlClient;

namespace DisasterNPO.Models
{
    
    public class MoneyModel
    {

        public static SqlConnection con = new SqlConnection("Server=tcp:disasternpodbserver.database.windows.net,1433;Initial Catalog=DisasterNPO_db;Persist Security Info=False;User ID=JasonN42;Password=Khanajj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //SqlCommand cmd;




        public int Id { get; set; } 
        public string Money { get; set; } = null!;
        public string Date { get; set; } = null!;
        public string Name { get; set; } = null!;

        public List<MoneyModel> Information()
        {
            List<MoneyModel> data_list;

            try
            {
                string sql_line = $"select Money, Date,Name from MoneyDonations";
                SqlDataAdapter cmd = new SqlDataAdapter(sql_line, con);
                DataSet dataset = new DataSet();
                con.Open();
                cmd.Fill(dataset);
                data_list = new List<MoneyModel>();
                foreach (DataRow dr in dataset.Tables[0].Rows)
                {
                    data_list.Add(new MoneyModel
                    {
                        Money = dr["Money"].ToString(),
                        Date = dr["Date"].ToString(),
                        Name = dr["Name"].ToString(),

                    });
                }
                con.Close();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
            return data_list;

        }

    }

    
}

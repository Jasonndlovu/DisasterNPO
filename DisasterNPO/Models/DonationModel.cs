using DisasterNPO.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DisasterNPO.Models
{
    
    public class DonationModel
    {
        
        public static SqlConnection con = new SqlConnection("Server=tcp:disasternpodbserver.database.windows.net,1433;Initial Catalog=DisasterNPO_db;Persist Security Info=False;User ID=JasonN42;Password=Khanajj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        //DisasterModel disasterM = new DisasterModel();




        public string Units { get; set; } = null!;

        public string category { get; set; } = null!;

        public string Item { get; set; } = null!;



        [TestMethod]
        public List<DonationModel> Information1()
        {
            List<DonationModel> data_list;

            try
            {
                string sql_line = $"select Item, category,Units from donations";
                SqlDataAdapter cmd = new SqlDataAdapter(sql_line, con);
                DataSet dataset = new DataSet();
                con.Open();
                cmd.Fill(dataset);
                data_list = new List<DonationModel>();
                foreach (DataRow dr in dataset.Tables[0].Rows)
                {
                    data_list.Add(new DonationModel
                    {
                        Item = dr["Item"].ToString(),
                        category = dr["category"].ToString(),
                        Units = dr["Units"].ToString(),
                        
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

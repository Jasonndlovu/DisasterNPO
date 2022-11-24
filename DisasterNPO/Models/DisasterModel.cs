using DisasterNPO.Controllers;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.CodeAnalysis;
using System.Data;
using System.Data.SqlClient;

namespace DisasterNPO.Models
{
    public class DisasterModel
    {
        public static SqlConnection con = new SqlConnection("Server=tcp:disasternpodbserver.database.windows.net,1433;Initial Catalog=DisasterNPO_db;Persist Security Info=False;User ID=JasonN42;Password=Khanajj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        MoneyModel model =  new MoneyModel();
        //DisasterModel = List<DisasterModel>;
        //public static List<DisasterModel> ls = new List<DisasterModel>();

        //public S list;

        //public var list = con.Query<DisasterModel>("").ToList();

        //Disaster Model
        public int Id { get; set; }
        public string  Aidtypes { get; set; } = null!;
        public string StartDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;

        public string Location { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string MoneyAccocated { get; set; } = null!;


        public int Money_used { get; set; }
        //public string Money_used { get; set; } = null!;
        // public string MoneyAllocated { get; internal set; }
        /*public void MoneyAccocatedd() {
            con.Open();
            SqlCommand cmds = new SqlCommand($"select SUM(MoneyAccocated) from Disaster", con);

            // int holding =cmds.ExecuteNonQuery();

            this.Money_used = cmds.ExecuteScalar().ToString();
            con.Close();
        
        }*/


        public List<DisasterModel> Information2()
        {

           // MoneyAccocatedd();
            List<DisasterModel> data_list;

            try
            {




                string sql_line = $"select Aidtypes, StartDate,EndDate,Location,Description,MoneyAccocated from Disaster";
                SqlDataAdapter cmd = new SqlDataAdapter(sql_line, con);
                DataSet dataset = new DataSet();
                con.Open();

                



                cmd.Fill(dataset);
                data_list = new List<DisasterModel>();
                foreach (DataRow dr in dataset.Tables[0].Rows)
                {
                    data_list.Add(new DisasterModel
                    {
                        Aidtypes = dr["Aidtypes"].ToString(),
                        StartDate = dr["StartDate"].ToString(),
                        EndDate = dr["EndDate"].ToString(),
                        Location = dr["Location"].ToString(),
                        Description = dr["Description"].ToString(),
                        MoneyAccocated = dr["MoneyAccocated"].ToString(),
                        //Money_used += Int16.Parse(MoneyAccocated),
                    // Money_used +=Int16.Parse(dr["MoneyAccocated"].ToString()),
                });
                    //Money_used += Int16.Parse(MoneyAccocated);
                }


                




                con.Close();
               // Money_used = holding;

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

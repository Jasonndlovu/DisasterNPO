using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace DisasterNPO.Models
{
    public class MoneyModel
    {
        public int Id { get; set; }
        public int Money { get; set; }
        public DateTime Date { get; set; }
        public string? Name { get; set; }    


    }
}

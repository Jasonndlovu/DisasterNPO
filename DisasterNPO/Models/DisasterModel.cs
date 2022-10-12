using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.CodeAnalysis;

namespace DisasterNPO.Models
{
    public class DisasterModel
    {
        MoneyModel model =  new MoneyModel();

        public int Id { get; set; }
        public string  Aidtypes { get; set; } = null!;
        public DateTime  StartDate{ get; set; }
        public DateTime EndDate{ get; set; }

        public string Location { get; set; } = null!;

        public string Description { get; set; } = null!;

        public int Money_allocated { get; set; }


        public int MoneyAllocation() { 
            int allocation;
            int value = Money_allocated;
            int balance = model.Money;

            allocation = balance - value;
        
            return allocation;
        }

    }
}

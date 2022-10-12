using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace DisasterNPO.Models
{
    public class DisasterModel
    {
        public int Id { get; set; }
        public string  Aidtypes { get; set; } = null!;
        public DateTime  StartDate{ get; set; }
        public DateTime EndDate{ get; set; }

        public string Location { get; set; } = null!;

        public string Description { get; set; } = null!;



    }
}

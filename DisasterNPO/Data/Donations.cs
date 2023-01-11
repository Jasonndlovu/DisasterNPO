using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;

namespace DisasterNPO.Data
{
   
    public class Donations
    {
        [Key]
        public Guid DonationId {get; set;}
        public string Item { get; set; }
    }
}

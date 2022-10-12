namespace DisasterNPO.Models
{
    public class DonationModel
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        
        public DateTime date{ get; set; }
        public int quantity { get; set; }

        public string catergories { get; set; }

        public string Other { get; set; }
        public string Description { get; set; }

    }
}

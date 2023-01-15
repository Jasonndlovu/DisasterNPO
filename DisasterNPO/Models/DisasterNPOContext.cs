using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DisasterNPO.Models
{
    
    public class DisasterNPOContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:jayservers.database.windows.net,1433;Initial Catalog=Disaster;Persist Security Info=False;User ID=adminlogin;Password=Jacky4510#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public DbSet<Register> Registers { get; set; } = null!;
        public DbSet<DisasterModel> Disaster{ get; set; } = null!;
        public DbSet<DonationModel> Donation{ get; set; } = null!;
        public DbSet<MoneyModel> Money { get; set; } = null!;
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Entity;

namespace DisasterNPO.Data
{
    
    public class Class: DbContext
    {
        public Class (string connectionString): base(connectionString)
            {
                
            }
        public IDbSet<Donations> Donations { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Donations>().ToTable("Items");
        }

    }
}

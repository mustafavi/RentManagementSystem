using System.Data.Entity;
using RentManagementSystem.Data;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RentManagementSystem.Infrastructure
{
    public class RentMangementSystemContext : DbContext
    {
        public RentMangementSystemContext() : base("name = RentManagement")
        {
           // Database.SetInitializer(new MigrateDatabaseToLatestVersion<RentMangementSystemContext, //Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Property> Property { get; set; }
        public DbSet<Flat> Flats { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Rent> Rent { get; set; }
        public DbSet<Bill> Bill { get; set; }

    }
}

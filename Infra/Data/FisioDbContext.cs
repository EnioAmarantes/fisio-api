using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data
{
    public class FisioDbContext : DbContext
    {
        public FisioDbContext(DbContextOptions<FisioDbContext> options) : base(options) { }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<ContactInfo> ContactInfos { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<MaritalStatusInfo> MaritalStatusInfos { get; set; }
    public DbSet<GenderInfo> GenderInfos { get; set; }
    public DbSet<Ensurance> Ensurances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Builders.CustomerBuilder());
            modelBuilder.ApplyConfiguration(new Builders.ContactInfoBuilder());
            modelBuilder.ApplyConfiguration(new Builders.AddressBuilder());
            modelBuilder.ApplyConfiguration(new Builders.MaritalStatusInfoBuilder());
            modelBuilder.ApplyConfiguration(new Builders.GenderInfoBuilder());
            modelBuilder.ApplyConfiguration(new Builders.EnsuranceBuilder());
        }
    }
}

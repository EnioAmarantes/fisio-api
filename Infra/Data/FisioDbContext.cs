using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data
{
    public class FisioDbContext : DbContext
    {
        public FisioDbContext(DbContextOptions<FisioDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customers");
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .UseMySqlIdentityColumn();

                entity.HasIndex(e => e.Id).IsUnique();
                
                entity.HasKey(e => e.Code);
                entity.Property(e => e.Code).IsRequired();
                entity.Property(e => e.Name).IsRequired().HasMaxLength(200);
                entity.OwnsOne(e => e.ContactInfo);
                entity.OwnsOne(e => e.Address);
                entity.Property(e => e.DateOfBirth);
                entity.Property(e => e.MaritalStatus);
                entity.Property(e => e.Sex);
                entity.OwnsOne(e => e.Ensurance);
            });
        }
    }
}

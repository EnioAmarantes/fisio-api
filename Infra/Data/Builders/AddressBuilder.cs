using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Builders
{
    public class AddressBuilder : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> entity)
        {
            entity.ToTable("Addresses");
            entity.HasKey(e => e.Code);
            entity.Property(e => e.Code).IsRequired();
            entity.Property(e => e.Street).IsRequired().HasMaxLength(200);
            entity.Property(e => e.Number).HasMaxLength(20);
            entity.Property(e => e.Complement).HasMaxLength(100);
            entity.Property(e => e.Neighborhood).HasMaxLength(100);
            entity.Property(e => e.City).IsRequired().HasMaxLength(100);
            entity.Property(e => e.State).IsRequired().HasMaxLength(50);
            entity.Property(e => e.ZipCode).IsRequired().HasMaxLength(20);
            entity.Property(e => e.Country).IsRequired().HasMaxLength(100);
        }
    }
}

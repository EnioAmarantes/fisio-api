using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Builders
{
    public class CustomerBuilder : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> entity)
        {
            entity.ToTable("Customers");
            entity.HasKey(e => e.Code);
            entity.Property(e => e.Code).IsRequired();
            entity.Property(e => e.Name).IsRequired().HasMaxLength(200);
            entity.Property(e => e.CPF).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.WhatsAppNumber).HasMaxLength(20);
            entity.Property(e => e.BirthDate);
            entity.Property(e => e.MaritalStatus);
            entity.Property(e => e.Gender);
            entity.HasOne(e => e.Ensurance)
                .WithMany()
                .HasForeignKey(e => e.EnsuranceCode);
            entity.HasOne(e => e.ContactInfo)
                .WithMany()
                .HasForeignKey(e => e.ContactInfoCode);
            entity.Property(e => e.Education)
                .HasConversion<int>();
            entity.HasOne(e => e.Address)
                .WithMany()
                .HasForeignKey(e => e.AddressCode);
        }
    }
}

using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Builders
{
    public class ContactInfoBuilder : IEntityTypeConfiguration<ContactInfo>
    {
        public void Configure(EntityTypeBuilder<ContactInfo> entity)
        {
            entity.ToTable("ContactInfos");
            entity.HasKey(e => e.Code);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(200);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
        }
    }
}

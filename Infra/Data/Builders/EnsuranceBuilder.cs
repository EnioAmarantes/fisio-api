using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Builders;

public class EnsuranceBuilder: IEntityTypeConfiguration<Ensurance>
{
    public void Configure(EntityTypeBuilder<Ensurance> builder)
    {
        builder.ToTable("Ensurances");
        builder.HasKey(e => e.Code);
        builder.Property(e => e.Code).IsRequired();
        builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
    }
}
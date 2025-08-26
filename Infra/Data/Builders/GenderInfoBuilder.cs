using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Builders
{
    public class GenderInfoBuilder : IEntityTypeConfiguration<GenderInfo>
    {
        public void Configure(EntityTypeBuilder<GenderInfo> entity)
        {
            entity.ToTable("GenderInfos");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Code).IsRequired().HasMaxLength(20);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);

            entity.HasData(
                new GenderInfo { Id = 1, Code = "1", Name = "Masculino" },
                new GenderInfo { Id = 2, Code = "2", Name = "Feminino" },
                new GenderInfo { Id = 3, Code = "3", Name = "Outro" }
            );
        }
    }
}

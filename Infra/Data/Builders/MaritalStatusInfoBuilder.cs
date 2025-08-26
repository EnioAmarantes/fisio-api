using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Builders
{
    public class MaritalStatusInfoBuilder : IEntityTypeConfiguration<MaritalStatusInfo>
    {
        public void Configure(EntityTypeBuilder<MaritalStatusInfo> entity)
        {
            entity.ToTable("MaritalStatusInfos");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Code).IsRequired().HasMaxLength(20);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);

            entity.HasData(
                new MaritalStatusInfo { Id = 1, Code = "1", Name = "Solteiro(a)" },
                new MaritalStatusInfo { Id = 2, Code = "2", Name = "Casado(a)" },
                new MaritalStatusInfo { Id = 3, Code = "3", Name = "Divorciado(a)" },
                new MaritalStatusInfo { Id = 4, Code = "4", Name = "Viúvo(a)" }
            );
        }
    }
}

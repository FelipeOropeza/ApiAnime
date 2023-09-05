using ApiAnime.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ApiAnime.Data.Map
{
    public class PersoMap : IEntityTypeConfiguration<PersoModel>
    {
        public void Configure(EntityTypeBuilder<PersoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Origem).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Apelido).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Metas).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PoderId);
            builder.Property(x => x.FuncId);

            builder.HasOne(x => x.Poder);
            builder.HasOne(x => x.Func);
        }
    }
}

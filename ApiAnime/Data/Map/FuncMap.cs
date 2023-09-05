using ApiAnime.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ApiAnime.Data.Map
{
    public class FuncMap : IEntityTypeConfiguration<FuncModel>
    {
        public void Configure(EntityTypeBuilder<FuncModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TipoFunc).IsRequired().HasMaxLength(255);
        }
    }
}

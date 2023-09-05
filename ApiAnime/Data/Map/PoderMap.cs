using ApiAnime.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiAnime.Data.Map
{
    public class PoderMap : IEntityTypeConfiguration<PoderModel>
    {
        public void Configure(EntityTypeBuilder<PoderModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Resp).IsRequired().HasMaxLength(255);
        }
    }
}

using ApiAnime.Data.Map;
using ApiAnime.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAnime.Data
{
    public class ApiPersoDBContex : DbContext
    {
        public ApiPersoDBContex(DbContextOptions<ApiPersoDBContex> options)
        : base(options)
        {
        }

        public DbSet<PoderModel> Poders { get; set; }
        public DbSet<FuncModel> Funcs { get; set; }
        public DbSet<PersoModel> Persos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PoderMap());
            modelBuilder.ApplyConfiguration(new FuncMap());
            modelBuilder.ApplyConfiguration(new PersoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}

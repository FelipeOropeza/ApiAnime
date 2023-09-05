using ApiAnime.Repositorios.Interfaces;
using ApiAnime.Repositorios;
using Microsoft.EntityFrameworkCore;
using ApiAnime.Data;

namespace ApiAnime
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddEntityFrameworkSqlServer()
            .AddDbContext<ApiPersoDBContex>(
            options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
            );

            builder.Services.AddScoped<IPoderRepositorio, PoderRepositorio>();
            builder.Services.AddScoped<IFuncRepositorio, FuncRepositorio>();
            builder.Services.AddScoped<IPersoRepositorio, PersoRepositorio>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
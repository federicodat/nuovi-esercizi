
using EF_ESERCIZIO_FERRAMENTA_REFACTORY.Models;
using Microsoft.EntityFrameworkCore;
using EF_ESERCIZIO_FERRAMENTA_REFACTORY.Repository;
using EF_ESERCIZIO_FERRAMENTA_REFACTORY.Services;
namespace EF_ESERCIZIO_FERRAMENTA_REFACTORY
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
            builder.Services.AddDbContext<BrugoliamoContex>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseTest"))
       );
            builder.Services.AddScoped<RepartoRepo>();
            builder.Services.AddScoped<ProdottoRepo>();

            builder.Services.AddScoped<RepartoService>();
            builder.Services.AddScoped<ProdottoService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.UseCors(builder =>
                 builder
                 .WithOrigins("*")
                 .AllowAnyMethod()
                 .AllowAnyHeader());

            app.Run();
        }
    }
}

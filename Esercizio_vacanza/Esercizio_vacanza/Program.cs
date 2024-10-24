
using Esercizio_vacanza.Models;
using Esercizio_vacanza.Repository;
using Esercizio_vacanza.Services;
using Microsoft.EntityFrameworkCore;

namespace Esercizio_vacanza
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
            builder.Services.AddDbContext<VacanzeContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseTest"))
      );
            builder.Services.AddScoped<PacchettoRepo>();
            builder.Services.AddScoped<DestinazioneRepo>();
            builder.Services.AddScoped<RecensioneRepo>();

            builder.Services.AddScoped<PacchettoService>();
            builder.Services.AddScoped<DestinazioneService>();
            builder.Services.AddScoped<RecensioneService>();

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
            app.UseCors(builder =>
                builder
                .WithOrigins("*")
                .AllowAnyMethod()
                .AllowAnyHeader());
            app.Run();
        }
    }
}

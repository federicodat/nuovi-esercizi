
using eserciziocorsi.Models;
using eserciziocorsi.Repository;
using eserciziocorsi.Services;
using Microsoft.EntityFrameworkCore;

namespace eserciziocorsi
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

            builder.Services.AddDbContext<corsoContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseTest"))
      );
            builder.Services.AddScoped<CorsoRepo>();
            builder.Services.AddScoped<CorsistaRepo>();
            builder.Services.AddScoped<IscrizioneRepo>();
            builder.Services.AddScoped<UtenteRepo>();

            builder.Services.AddScoped<CorsoService>();
            builder.Services.AddScoped<CorsistaService>();
            builder.Services.AddScoped<IscrizioneService>();
           builder.Services.AddScoped<UtenteService>();

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

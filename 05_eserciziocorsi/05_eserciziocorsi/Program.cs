using _05_eserciziocorsi.Contex;
using _05_eserciziocorsi.Controllers;
using _05_eserciziocorsi.Repos;
using _05_eserciziocorsi.Services;
using Microsoft.EntityFrameworkCore;

namespace _05_eserciziocorsi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
     
 
                builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<PoloFormativoContext>(options => options.UseSqlServer(
            builder.Configuration.GetConnectionString("DatabaseTest"))   
            );

            builder.Services.AddScoped<AdminRepo>();
            builder.Services.AddScoped<CorsoRepo>();
            builder.Services.AddScoped<IscrizioneRepo>();
            builder.Services.AddScoped<AdminService>();
            builder.Services.AddScoped<CorsoService>();
            builder.Services.AddScoped<IscrizioneApiService>();
            builder.Services.AddScoped<CorsoApiService>();
            builder.Services.AddScoped<IscrizioneApiController>();


            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Auth}/{action=Login}/{id?}");

            #region Configurazione di dev per CORS
 
            app.UseCors(builder =>
            builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()
            );
 
            #endregion
           
            app.Run();
        }
    }
}

using A_CHAT.Context;
using A_CHAT.Repos;
using A_CHAT.Services;
using A_CHAT.Models;
using Microsoft.EntityFrameworkCore;
 

namespace A_CHAT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ChatContext>(options => options.UseSqlServer(
            builder.Configuration.GetConnectionString("DatabaseTest"))
            );

            builder.Services.AddScoped<AmministratoreService>();
            builder.Services.AddScoped<UtenteService>();
            builder.Services.AddScoped<ChatService>();
            builder.Services.AddScoped<AmministratoreRepo>();
            builder.Services.AddScoped<UtenteRepo>();
            builder.Services.AddScoped<ChatRepo>();

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

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            #region Configurazione di dev per CORS
#if DEBUG
            app.UseCors(builder =>
            builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()
            );
#endif
            #endregion

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Auth}/{action=Login}/{id?}");

            app.MapControllerRoute(
                name: "userList",
                pattern: "{controller=Utente}/{action=Lista}/{varUsername?}");

            app.MapControllerRoute(
               name: "chatList",
               pattern: "{controller=Chat}/{action=Listames}");

            app.Run();
        }
    }
}
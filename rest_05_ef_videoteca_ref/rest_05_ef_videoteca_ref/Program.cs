
using Microsoft.EntityFrameworkCore;
using rest_05_ef_videoteca_ref.Models;
using rest_05_ef_videoteca_ref.Repository;
using rest_05_ef_videoteca_ref.services;

namespace rest_05_ef_videoteca_ref
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
            #region importante per confgurazione del context
#if DEBUG
            builder.Services.AddDbContext<BlockbusterContex>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseTest"))
            );

#else
            builder.Services.AddDbContext<BlockbusterContex>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseProduzione"))
            );
#endif

#endregion  importante per confgurazione

            //builder.Services.AddScoped<IRepo<Videoteca>,VideotecaRepo>();
            //builder.Services.AddScoped<IRepo<Supporto>, SupportoRepo>();
            //builder.Services.AddScoped<VideotecaService>();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

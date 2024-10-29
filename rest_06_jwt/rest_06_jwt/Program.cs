
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace rest_06_jwt
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
            // per jwt 
            builder.Services.AddAuthentication().AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "Archety.dev", // un nome a caso messo
                    ValidAudience = "Popolo", //local host o ip particolari
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("parola_ segreta_parola_ segreta_parola_ segreta_parola_ segreta_parola_ segreta"))    //per chiave privata segreta  deve essere almeno 64 caratteri per cui replica es: parola_segreta
                };
            }
            );


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

using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using rest_06_jwt.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace rest_06_jwt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  // cosi utilizza il nome del controller
    public class AuthController : Controller
    {
        [HttpPost("login")]             //localhost:1234/api/auth/login
        public IActionResult Login(UserLogin objLogin)
        {
            if (string.IsNullOrWhiteSpace(objLogin.Username) || string.IsNullOrWhiteSpace(objLogin.Password))
                return BadRequest();

            string tipologiaUtente = "";

            if (objLogin.Username == "giovanni" && objLogin.Password == "1234")

            {
                objLogin.UserType = "ADMIN";
            }
            if (objLogin.Username == "valeria" && objLogin.Password == "4321")

            {
                objLogin.UserType = "USER";
            }

            if (objLogin.UserType is not null)
            {
                List<Claim> claimsList = new List<Claim>()
                {
                    new Claim(JwtRegisteredClaimNames.Sub, objLogin.Username),
                    new Claim("userType", objLogin.UserType),
                    //new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

                                      };
                var key= new  SymmetricSecurityKey(Encoding.UTF8.GetBytes("parola_ segreta_parola_ segreta_parola_ segreta_parola_ segreta_parola_ segreta"));
                var creds= new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    issuer: "Archety.dev",
                    audience:"Popolo",
                    claims:claimsList, 
                    expires:DateTime.Now.AddHours(1),
                    signingCredentials:creds

                    );
                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });

            }
            return NotFound();
        }
    }
}
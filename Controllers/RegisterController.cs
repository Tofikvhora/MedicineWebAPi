using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Medicine.Models;
using Medicine.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Medicine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 
    public class RegisterController : ControllerBase
    {
        private readonly AppDbContext dbContext;
        private IConfiguration configuration;

        public RegisterController(AppDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
        }

        [HttpPost]
        public IActionResult Register(RegisterDTO registerDTO)
        {
            
            var user = new Users()
            {
                UserId = Guid.NewGuid().ToString(),
                Email = registerDTO.Email,
                FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName,
                password = registerDTO.password,
            };
            var dbUsers = dbContext.users.FirstOrDefault(e => e.Email == registerDTO.Email);
            var claims = new[]
               {
                    new Claim(JwtRegisteredClaimNames.Sub,configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                    new Claim("UserId",user.UserId.ToString()),
                    new Claim("Email",user.Email.ToString()),

                };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken
                (
                configuration["Jwt:Issuer"],
                configuration["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(60),
                signingCredentials: signIn
                );
             string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);



            if (dbUsers == null)
            {
                dbContext.users.Add(user);
                dbContext.SaveChanges();
                return Ok(new { Token=tokenValue,User=user });
            }
             return BadRequest("User already exist with same email");

            
           


        }
    }
}

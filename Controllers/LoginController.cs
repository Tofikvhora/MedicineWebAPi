using Medicine.Models;
using Medicine.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Medicine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly AppDbContext context;

        public LoginController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public IActionResult Login(LoginDTO login)
        {
            var user = context.users.FirstOrDefault(e=> e.Email == login.Email && e.password == login.password);
            if (user == null)
            {
                return NotFound("user Not Found");
            }
            return Ok("Login Successfully");
        }
    }
}

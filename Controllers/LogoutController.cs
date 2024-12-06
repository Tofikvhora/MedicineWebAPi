using Medicine.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medicine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogoutController : ControllerBase
    {
        private readonly AppDbContext context;

        public LogoutController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public IActionResult Logout(Guid id)
        {
            var user = context.users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            context.users.Remove(user);
            context.SaveChanges();
            return Ok("Logout user");

        }

    }
}

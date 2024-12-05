using Medicine.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medicine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderAdminController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public OrderAdminController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            return Ok(dbContext.orders.ToList());

        }

    }
}

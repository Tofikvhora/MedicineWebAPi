using Medicine.Models;
using Medicine.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medicine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderUserController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public OrderUserController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            return Ok(dbContext.ordersItems.ToList());  

        }

        [HttpPost]
        public IActionResult AddOrder(OrderDTO orderDto)
        {
            var OrderData = new OrderItems()
            {
                UserId = orderDto.UserId,
                OrderId = Guid.NewGuid().ToString(),
                Discount = orderDto.Discount,
                Medicine = orderDto.Medicine,   
                Quantity = orderDto.Quantity,   
                TotalPrice = orderDto.TotalPrice,   
                UnitPrice = orderDto.UnitPrice,
            };

            var OrderAdminData = new Order()
            {
                UserId = orderDto.UserId,
                OrderNo = Guid.NewGuid().ToString(),
                OrderTotal = orderDto.TotalPrice,
                OrderStatus = "Pending"
            };

            if(OrderData != null && OrderAdminData != null)
            {
                dbContext.ordersItems.Add(OrderData);
                dbContext.orders.Add(OrderAdminData);
                dbContext.SaveChanges();
                return Ok(OrderData);
            }

            return BadRequest();
        }



        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult OrderById(Guid id)
        {
            var order = dbContext.ordersItems.Find(id);

            if(order != null)
            {
                return Ok(order);
            }
            return BadRequest();

        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public IActionResult DeleteOrder(Guid id)
        {
            var OrderId = dbContext.ordersItems.Find(id);
            if(OrderId is null)
            {
                return BadRequest();
            }
            dbContext.ordersItems.Remove(OrderId);
            dbContext.SaveChanges();
            return Ok(); 
        }


    }
}

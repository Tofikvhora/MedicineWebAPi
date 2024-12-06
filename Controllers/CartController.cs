using Medicine.Models;
using Medicine.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medicine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly AppDbContext dbContext;
         private Users userData;
        private Medicines medicine;

        public CartController(AppDbContext dbContext,Medicines medicines,Users users)
        {
            this.dbContext = dbContext;
            this.medicine = medicines;
            this.userData = users;
        }

        [HttpGet]
        public IActionResult GetAllCart()
        {
            return Ok(dbContext.carts.ToList());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetCartById(Guid id)
        {
            var cartId = dbContext.carts.Find(id);
            if(cartId is null)
            {
                return BadRequest();
            }
            return Ok(cartId);  
        }


        [HttpPost]
        public IActionResult AddToCart(CartDTO cartDTO)
        {
           
            var cartData = new Cart()
            {
                Discount = cartDTO.Discount,
                Quantity = cartDTO.Quantity,
                TotalPrice = cartDTO.TotalPrice,
                UnitPrice = cartDTO.UnitPrice,
                MedicineID = medicine.Id.ToString(),
                UserId = userData.UserId,
            };
            if(cartData != null)
            {
                dbContext.carts.Add(cartData);
                dbContext.SaveChanges();
                return Ok(cartData);
            }
            return BadRequest();
        }


        [HttpDelete]
        [Route("{id:Guid}")]
        public IActionResult RemoveFromCart(Guid id)
        {
            var cartId = dbContext.carts.Find(id);
            if(cartId is null)
            {
                return NotFound();
            }
            dbContext.carts.Remove(cartId);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}

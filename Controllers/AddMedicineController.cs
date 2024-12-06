
using Medicine.Models;
using Medicine.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medicine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddAndGetMedicineController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public AddAndGetMedicineController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult AddMedicine(MedicineDTO medicineDTO)
        {
            var medicineData = new Medicines()
            {
                Name = medicineDTO.Name,
               
                Manufacturer = medicineDTO.Manufacturer,
                UnitPrice = medicineDTO.UnitPrice,
                Quantity = medicineDTO.Quantity,
                Discount = medicineDTO.Discount,
                ImageUrl = medicineDTO.ImageUrl,
                Status = 1,
                Type = "Ok"
               
            };

            if(medicineData != null)
            {
                dbContext.medicines.Add(medicineData);
                dbContext.SaveChanges();
                return Ok(medicineData);
            }

            return BadRequest("Please Add All Values");

         
         
        }


        [HttpGet]
        public IActionResult GetAllMedicine()
        {
            return Ok(dbContext.medicines.ToList());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetMedicineById(Guid id)
        {
            var md = dbContext.medicines.Find(id);
            if(md is null)
            {
                return BadRequest();
            }
            return Ok(md);
        }


        [HttpDelete]
        [Route("{id:Guid}")]
        public IActionResult RemoveMedicine(Guid id)
        {
            var cartId = dbContext.medicines.Find(id);
            if (cartId is null)
            {
                return NotFound();
            }
            dbContext.medicines.Remove(cartId);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Medicine.Models
{
    public class Cart
    {

        [Key]
        public Guid Id { get; set; }

        public string UserId { get; set; }

        public string MedicineID { get; set; } 
        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }

  
    }
}

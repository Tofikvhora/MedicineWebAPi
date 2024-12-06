using System.ComponentModel.DataAnnotations;

namespace Medicine.Models
{
    public class OrderItems
    {
        [Key]
        public Guid Id { get; set; }
        public string UserId { get; set; }

        public string OrderId { get; set; }
        public string Medicine { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

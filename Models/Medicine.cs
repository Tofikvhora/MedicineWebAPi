using System.ComponentModel.DataAnnotations;

namespace Medicine.Models
{
    public class Medicines
    {

        [Key]
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Manufacturer { get; set; }

        public required decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }
        public required int  Quantity { get; set; }

        public DateTime ExpDate { get; set; } = DateTime.Now;

        public required string ImageUrl { get; set; }

        public int Status { get; set; }
        public string Type { get; set; }
    }
}

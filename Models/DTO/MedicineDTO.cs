namespace Medicine.Models.DTO
{
    public class MedicineDTO
    {
        public required string Name { get; set; }
        public required string Manufacturer { get; set; }

        public required decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }
        public required int Quantity { get; set; }

        public DateTime ExpDate { get; set; } = DateTime.Now;

        public required string ImageUrl { get; set; }
    }
}

namespace Medicine.Models.DTO
{
    public class CartDTO
    {
        public int UserId { get; set; } = 1520055;

        public int MedicineID { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
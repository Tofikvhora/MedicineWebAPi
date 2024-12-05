namespace Medicine.Models.DTO
{
    public class OrderDTO
    {

        public int? UserId { get; set; } = 0;
        public int Medicine { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
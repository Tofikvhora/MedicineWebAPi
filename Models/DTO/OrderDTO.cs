namespace Medicine.Models.DTO
{
    public class OrderDTO
    {
        public string UserId { get; set; }

        public string Medicine { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
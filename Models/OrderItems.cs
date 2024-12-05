namespace Medicine.Models
{
    public class OrderItems
    {
        public Guid Id { get; set; }
        public int? OrderId { get; set; } = 0;
        public int Medicine { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

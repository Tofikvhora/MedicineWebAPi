namespace Medicine.Models
{
    public class Order
    {

        public Guid Id { get; set; }
        public int? UserId { get; set; } = 15000;

        public string OrderNo { get; set; }
        public decimal OrderTotal { get; set; }
        public string OrderStatus { get; set; }

    }
}

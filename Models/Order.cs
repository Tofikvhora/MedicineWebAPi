namespace Medicine.Models
{
    public class Order
    {

        public Guid Id { get; set; }
        public string UserId { get; set; }

        public string OrderNo { get; set; }
        public decimal OrderTotal { get; set; }
        public string OrderStatus { get; set; }

    }
}

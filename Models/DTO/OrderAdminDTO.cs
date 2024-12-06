namespace Medicine.Models.DTO
{
    public class OrderAdminDTO
    {
        public decimal OrderTotal { get; set; }
        public string OrderStatus { get; set; } = "pending";
    }
}

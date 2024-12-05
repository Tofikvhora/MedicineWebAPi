namespace Medicine.Models.DTO
{
    public class OrderAdminDTO
    {

        public int? UserId { get; set; } = 0;

        public string OrderNo { get; set; }
        public decimal OrderTotal { get; set; }
        public string OrderStatus { get; set; } = "pending";
    }
}

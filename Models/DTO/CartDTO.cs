namespace Medicine.Models.DTO
{
    public class CartDTO
    {
        public string UserId { get; set; }

        public string MedicineID { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
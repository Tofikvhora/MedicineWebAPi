namespace Medicine.Models.DTO
{

    public class RegisterDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string password { get; set; }

        public string Email { get; set; }
        public decimal Fund { get; set; } = 100;
        public int Type { get; set; } = 1;

        public string Status { get; set; } = "Pending";
    }
}

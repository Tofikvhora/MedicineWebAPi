namespace Medicine.Models
{
    public class Users
    {
        public Guid Id { get; set; }


        public string UserId { get; set; } 
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string password { get; set; }

        public string Email { get; set; }
        public decimal Fund { get; set; }
        public string Type { get; set; }

        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}

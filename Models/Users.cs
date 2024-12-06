using System.ComponentModel.DataAnnotations;

namespace Medicine.Models
{
    public class Users
    {
        [Key]
        public Guid Id { get; set; }

       
        public string UserId { get; set; } 
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string password { get; set; }

        public string Email { get; set; }
        public decimal Fund { get; set; } = 5;
        public string Type { get; set; } = "1";

        public string Status { get; set; } = "Pending";
        public DateTime CreatedOn { get; set; } = DateTime.Now;

    }
}

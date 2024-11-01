using System.ComponentModel.DataAnnotations;

namespace ecommerce_Project.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        [EmailAddress]
        public required string Email { get; set; }

        public DateTime? Nascimento { get; set; }
    }

}

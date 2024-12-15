using System.ComponentModel.DataAnnotations;

namespace Job_System.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        [MaxLength(8)]
        public string Password { get; set; } = string.Empty;

    }
}

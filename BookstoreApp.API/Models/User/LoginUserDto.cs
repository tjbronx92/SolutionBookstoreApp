using System.ComponentModel.DataAnnotations;

namespace BookstoreApp.API.Models.User
{
    public class LoginUserDto
    {
        [Required]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Login
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "The Password field is required.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}

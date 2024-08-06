using System.ComponentModel.DataAnnotations;

namespace AuthAPI.Dtos
{
    public class ForgotPasswordDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}

using System.ComponentModel.DataAnnotations;

namespace identity_test_api.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

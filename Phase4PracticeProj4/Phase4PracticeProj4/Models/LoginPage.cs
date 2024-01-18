using System.ComponentModel.DataAnnotations;

namespace Phase4PracticeProj4.Models
{
    public class LoginPage
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}

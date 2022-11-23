using System.ComponentModel.DataAnnotations;

namespace RazorPagesLogin.Models
{
    public class Login
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Password { get; set; }
    }

    
}
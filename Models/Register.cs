using System.ComponentModel.DataAnnotations;

namespace RazorPagesRegister.Models
{
    public class Register
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Password { get; set; }
    }
}

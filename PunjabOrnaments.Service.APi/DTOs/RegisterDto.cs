using System.ComponentModel.DataAnnotations;

namespace PunjabOrnaments.Service.APi.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

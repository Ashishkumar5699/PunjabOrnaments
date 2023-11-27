using System.ComponentModel.DataAnnotations;

namespace PunjabOrnaments.Common.Models.Auth
{
    public class AuthUser
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string? Token { get; set; }
        public string Device { get; set; } = "Mobile";

    }
}

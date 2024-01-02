namespace PunjabOrnaments.Common.Models.Auth
{
    public class AuthUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string Device { get; set; } = "Mobile";

    }
}

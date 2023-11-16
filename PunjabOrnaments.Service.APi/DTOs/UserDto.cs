namespace APIServices.DTOs
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string Token { get; set; }
        public DateTime LoginTime { get; set; }
        public string Device { get; set; } = "Mobile";
    }
}

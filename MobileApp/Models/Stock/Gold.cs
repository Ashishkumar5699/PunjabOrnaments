using Punjab_Ornaments.Models.Enum;
using SQLite;

namespace Punjab_Ornaments.Models
{
    public class Gold
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Code { get; set; }
        public decimal Weight { get; set; }
        public Brand Brand { get; set; }
        public CarrotEnum Carrot { get; set; }
    }
}

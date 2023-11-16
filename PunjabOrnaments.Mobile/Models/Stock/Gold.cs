using Punjab_Ornaments.Models.Enum;
using SQLite;

namespace Punjab_Ornaments.Models
{
    public class Gold : PunjabOrnaments.Models.Stock.Gold
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
    }
}

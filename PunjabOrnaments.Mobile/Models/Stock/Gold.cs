using SQLite;

namespace Punjab_Ornaments.Models
{
    public class Gold : PunjabOrnaments.Model.Stock.Metal.Gold
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
    }
}

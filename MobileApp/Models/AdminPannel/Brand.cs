using SQLite;

namespace Punjab_Ornaments.Models.AdminPannel
{
    public class Brand
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string MetalType { get; set; }
    }
}

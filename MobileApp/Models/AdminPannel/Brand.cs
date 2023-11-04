using SQLite;

namespace Punjab_Ornaments.Models.AdminPannel
{
    public class Brand : PunjabOrnaments.Models.AdminPannel.Brand
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

    }
}

using SQLite;

namespace Punjab_Ornaments.Models.AdminPannel
{
    public class MetelType : PunjabOrnaments.Models.AdminPannel.MetelType
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
    }
}

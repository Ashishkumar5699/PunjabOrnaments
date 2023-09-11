using SQLite;

namespace Punjab_Ornaments.Models.AdminPannel
{
    public class MetelType
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string MetelName { get; set; }
    }
}

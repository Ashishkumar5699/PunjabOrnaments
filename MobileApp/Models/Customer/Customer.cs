using SQLite;

namespace Punjab_Ornaments.Models
{
    public class Customer : PunjabOrnaments.Models.Consumer.Consumer
    {
        [PrimaryKey]
        [AutoIncrement]
        public int CustmorId { get; set; }

    }
}


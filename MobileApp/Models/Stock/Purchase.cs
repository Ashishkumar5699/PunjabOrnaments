using SQLite;

namespace Punjab_Ornaments.Models.Stock
{
    public class Purchase : PunjabOrnaments.Models.Stock.Requests.PurchaseRequest
    {
        [PrimaryKey]
        [AutoIncrement]
        public int PurchaseRequestId { get; set; }
    }
}

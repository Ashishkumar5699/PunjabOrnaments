namespace PunjabOrnaments.Common.Approvals
{
    public class PurchaseRequest
    {
        public string MatelType { get; set; }
        public string ItemType { get; set; }
        public string Brand { get; set; }
        public string ManufactureId { get; set; }
        public string ManufactureName { get; set; }
        public double GrossWeight { get; set; }
        public double LessWeight { get; set; }
        public double NetWeight { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }
        public double Wastage { get; set; }
        public double Labour { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int? IsApproved { get; set; }
        public string CreatedBy { get; set; } = "test";
    }
}

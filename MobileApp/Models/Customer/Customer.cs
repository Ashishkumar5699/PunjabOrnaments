using SQLite;

namespace Punjab_Ornaments.Models
{
    public class Customer
    {
        [PrimaryKey]
        [AutoIncrement]
        public int CustmorId { get; set; }
        public string CustmorPrifix { get; set; }
        public string CustmorFirstName { get; set; }
        public string CustmorLastName { get; set; }
        public string CustmorPhoneNumber { get; set; }
        public string CustmorAddress1 { get; set; }
        public string CustmorAddress2 { get; set; }
        public string CustmorLandMark { get; set; }
        public string CustmorCity { get; set; }
        public string CustmorState { get; set; }
        public string CustmorPinCode { get; set; }

    }
}


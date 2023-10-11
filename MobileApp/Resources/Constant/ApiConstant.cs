namespace Punjab_Ornaments.Resources.Constant
{
    public static class ApiConstant
    {
        //public const string baseurl = "http://localhost:5000/api/";
        public const string baseurl = "https://192.168.29.142:45455/api/";

        #region Account
        public const string Login = baseurl + "account/login";
        public const string Register = baseurl + "account/register";
        #endregion
        #region Stock
        public const string GetAllStock = baseurl + "Stock";
        #endregion
        #region Request
        public const string AddPurchaseRequest = baseurl + "Request/AddGoldPurchaseRequst";
        public const string GetGoldRequestDetail = baseurl + "Request/GetGoldRequestDetail/";
        public const string DeleteGoldPurchaseRequst = baseurl + "Request/DeleteGoldPurchaseRequst/";
        #endregion
        #region Approval
        public const string GetAllGoldPurchaseRequests = baseurl + "Approval/Getallgoldpurchaserequests";
        public const string GoldApprove = baseurl + "Approval/GoldApprove/";
        public const string GoldReject = baseurl + "Approval/GoldReject/";
        #endregion
    }
}

namespace Punjab_Ornaments.Resources.Constant
{
    public static class ApiConstant
    {
        public const string url = "http://192.168.1.7:45455/";
        public const string baseurl = url + "api/";

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

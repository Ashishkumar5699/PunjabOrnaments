
import { baseurl } from "../assets/Configurations";
//#region Account
const Login = baseurl + "account/login";
const Register = baseurl + "account/register";
//#endregion

//#region Stock
const GetAllStock = baseurl + "Stock";
//#endregion

//#region Request
const AddPurchaseRequest = baseurl + "Request/AddGoldPurchaseRequst";
const GetGoldRequestDetail = baseurl + "Request/GetGoldRequestDetail/";
const DeleteGoldPurchaseRequst = baseurl + "Request/DeleteGoldPurchaseRequst/";
//#endregion

//#region Approval
const GetAllGoldPurchaseRequests = baseurl + "Approval/Getallgoldpurchaserequests";
const GoldApprove = baseurl + "Approval/GoldApprove/";
const GoldReject = baseurl + "Approval/GoldReject/";
//#endregion


export{
    Login,
    Register,
    GetAllStock,
    AddPurchaseRequest,
    GetGoldRequestDetail,
    DeleteGoldPurchaseRequst,
    GetAllGoldPurchaseRequests,
    GoldApprove,
    GoldReject
}
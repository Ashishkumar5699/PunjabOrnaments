using Punjab_Ornaments.Infrastructure.RestService;
using Punjab_Ornaments.Models.Auth;
using Punjab_Ornaments.Resources.Constant;
using PunjabOrnaments.Common.Models.Response;

namespace Punjab_Ornaments.Infrastructure.APIService
{
    public class APIService : IAPIService
    {
        public IRestService _restService;
        public APIService(IRestService restService)
        {
            _restService = restService;
        }

        public async Task<ResponseResult<LoginUser>> LoginUser(LoginUser loginUser)
        {
            if (string.IsNullOrEmpty(loginUser.UserName)) return new ResponseResult<LoginUser>
            {
                HasErrors = true,
                IsSystemError = true,
                Message = PunjabOrnaments.Common.Constants.GlobalMessages.InvalidUsername,
            };

            if (string.IsNullOrEmpty(loginUser.Password)) return new ResponseResult<LoginUser>
            {
                HasErrors = true,
                IsSystemError = true,
                Message = PunjabOrnaments.Common.Constants.GlobalMessages.InvalidPassword,
            };

            var responce = await _restService.PostAsync<LoginUser, ResponseResult<LoginUser>>(ApiConstant.Login, loginUser);
            return responce;
        }

        public async Task AddGoldPurchaseRequst(Models.Approvals.PurchaseRequest request)
        {
           var responce =  await _restService.PutAsync(ApiConstant.AddPurchaseRequest, request);
        }

        public async Task<List<Models.Approvals.PurchaseRequest>> GetAllPurchaseRequest()
        {
            //var response = await _restService.GetAsync<List<Domain.Purchase.PurchaseResponse>>(ApiConstant.GetAllGoldPurchaseRequests, "", null);
            var response = await _restService.GetAsync<List<Models.Approvals.PurchaseRequest>>(ApiConstant.GetAllGoldPurchaseRequests, "", null);
            return new List<Models.Approvals.PurchaseRequest>(response);
        }

        public async Task<bool> GoldApprove(int id)
        {
            var response = await _restService.PutAsync<Models.Approvals.PurchaseRequest>(ApiConstant.GoldApprove + id.ToString(), null);
            return response != null;
        }
        public async Task<bool> GoldReject(int id)
        {
            var response = await _restService.PutAsync<Models.Approvals.PurchaseRequest>(ApiConstant.GoldReject + id.ToString(), null);
            return response != null;
        }

        public async Task<Models.Approvals.PurchaseRequest> GetPurchaseById(int id)
        {
            var response = await _restService.GetAsync<Models.Approvals.PurchaseRequest>(ApiConstant.GetGoldRequestDetail + id.ToString(), "", null);
            return response;
        }
    }
}

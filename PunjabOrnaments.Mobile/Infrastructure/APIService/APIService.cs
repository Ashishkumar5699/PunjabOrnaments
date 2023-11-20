using Punjab_Ornaments.Infrastructure.RestService;
using Punjab_Ornaments.Models.Auth;
using Punjab_Ornaments.Models.Stock;
using Punjab_Ornaments.Resources.Constant;

namespace Punjab_Ornaments.Infrastructure.APIService
{
    public class APIService : IAPIService
    {
        public IRestService _restService;
        public APIService(IRestService restService)
        {
            _restService = restService;
        }

        public async Task<LoginUser> LoginUser(LoginUser loginUser)
        {
            var responce = await _restService.PostAsync(ApiConstant.Login, loginUser);
            return responce;
        }

        public async Task AddGoldPurchaseRequst(Purchase request)
        {
           var responce =  await _restService.PutAsync(ApiConstant.AddPurchaseRequest, request);
        }

        public async Task<List<Purchase>> GetAllPurchaseRequest()
        {
            //var response = await _restService.GetAsync<List<Domain.Purchase.PurchaseResponse>>(ApiConstant.GetAllGoldPurchaseRequests, "", null);
            var response = await _restService.GetAsync<List<Models.Stock.Purchase>>(ApiConstant.GetAllGoldPurchaseRequests, "", null);
            return new List<Purchase>(response);
        }

        public async Task<bool> GoldApprove(int id)
        {
            var response = await _restService.PutAsync<Purchase>(ApiConstant.GoldApprove + id.ToString(), null);
            return response != null;
        }
        public async Task<bool> GoldReject(int id)
        {
            var response = await _restService.PutAsync<Purchase>(ApiConstant.GoldReject + id.ToString(), null);
            return response != null;
        }

        public async Task<Purchase> GetPurchaseById(int id)
        {
            var response = await _restService.GetAsync<Purchase>(ApiConstant.GetGoldRequestDetail + id.ToString(), "", null);
            return response;
        }
    }
}

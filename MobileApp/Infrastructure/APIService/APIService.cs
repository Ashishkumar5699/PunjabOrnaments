using Punjab_Ornaments.Domain.Purchase;
using Punjab_Ornaments.Infrastructure.RestService;
using Punjab_Ornaments.Models.Stock;
using Punjab_Ornaments.Resources.Constant;
using System.Text.Json;

namespace Punjab_Ornaments.Infrastructure.APIService
{
    public class APIService : IAPIService
    {
        public IRestService _restService;
        public APIService(IRestService restService)
        {
            _restService = restService;
        }
        public async Task AddGoldPurchaseRequst(Purchase request)
        {
           var responce =  await _restService.PostAsync(ApiConstant.AddPurchaseRequest, request);
        }
    }
}

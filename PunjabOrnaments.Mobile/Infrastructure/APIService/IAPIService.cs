using Punjab_Ornaments.Models.Auth;
using Punjab_Ornaments.Models.Stock;

namespace Punjab_Ornaments.Infrastructure.APIService
{
    public interface IAPIService
    {
        #region Auth
        Task<LoginUser> LoginUser(LoginUser loginUser);
        #endregion
        Task AddGoldPurchaseRequst(Purchase request);
        Task<List<Purchase>> GetAllPurchaseRequest();
        Task<bool> GoldApprove(int id);
        Task<bool> GoldReject(int id);
        Task<Purchase> GetPurchaseById(int id);
    }
}

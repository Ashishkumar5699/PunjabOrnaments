using Punjab_Ornaments.Domain.Purchase;
using Punjab_Ornaments.Models.Stock;

namespace Punjab_Ornaments.Infrastructure.APIService
{
    public interface IAPIService
    {
        Task AddGoldPurchaseRequst(Purchase request);
    }
}

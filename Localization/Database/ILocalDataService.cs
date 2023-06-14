using Punjab_Ornaments.Models;
using Punjab_Ornaments.Models.Stock;

namespace Punjab_Ornaments.Localization.Database
{
    public interface ILocalDataService
    {
        void Initialize();

        #region GoldSection
        Task<int> AddGoldinStock(Gold gold);
        Task<int> UpdateGoldinStock(Gold gold);
        Task<int> DeleteGoldFromStock(Gold gold);
        Task<List<Gold>> GetAllGoldStock();
        Task<List<Gold>> GetGoldStockById(int id);
        #endregion

        #region CustomerSection
        Task<int> AddCustomer(Customer customer);
        Task<int> UpdateCustpmer(Customer customer);
        Task<int> DeleteCustomer(Customer customer);
        Task<List<Customer>> GetAllCustomers();
        Task<List<Customer>> GetCustomerByPhone(int phone);
        #endregion

        #region PurchaseSection
        Task<int> AddPurchase(Purchase Purchaseitem);
        Task<int> UpdatePurchase(Purchase Purchaseitem);
        Task<int> DeletePurchase(Purchase Purchaseitem);
        Task<List<Purchase>> GetAllPendingPurchases();
        Task<List<Purchase>> GetAllCompletePurchases();
        Task<List<Purchase>> GetTodaysPurchase();
        #endregion
    }
}

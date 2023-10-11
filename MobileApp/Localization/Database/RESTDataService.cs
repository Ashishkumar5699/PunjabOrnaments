using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Models;
using Punjab_Ornaments.Models.AdminPannel;
using Punjab_Ornaments.Models.Auth;
using Punjab_Ornaments.Models.Stock;

namespace Punjab_Ornaments.Localization.Database
{
    public class RESTDataService : IDataService
    {
        #region initialization
        public readonly IAPIService _iAPIService;

        public RESTDataService(IAPIService apiService)
        {
            _iAPIService = apiService;
        }
        public void Initialize()
        {

        }
        #endregion

        #region Methods
        //private static void CreateTables(SQLiteConnection database)
        //{
        //    database.CreateTable<Customer>();
        //    database.CreateTable<Gold>();
        //    database.CreateTable<Purchase>();
        //    database.CreateTable<MetelType>();
        //    database.CreateTable<Brand>();
        //}
        #endregion

        #region Auth
        public async Task<LoginUser> LoginUser(LoginUser loginUser)
        {
            var result = await _iAPIService.LoginUser(loginUser);
            return new LoginUser
            {
                UserName = "null",
                Password = "null",
            };
        }
        #endregion

        #region Gold
        public async Task<int> AddGoldinStock(Gold gold) => throw new NotImplementedException();
        public async Task<int> UpdateGoldinStock(Gold gold) => throw new NotImplementedException();
        public async Task<int> DeleteGoldFromStock(Gold gold) => throw new NotImplementedException();
        public async Task<List<Gold>> GetAllGoldStock() => throw new NotImplementedException();
        public async Task<List<Gold>> GetGoldStockById(int id) => throw new NotImplementedException();
        #endregion

        #region Customer
        public async Task<int> AddCustomer(Customer custmor) => throw new NotImplementedException();
        public async Task<int> UpdateCustpmer(Customer custmor) => throw new NotImplementedException();
        public async Task<int> DeleteCustomer(Customer custmor) => throw new NotImplementedException();
        public async Task<List<Customer>> GetAllCustomers() => throw new NotImplementedException();
        public async Task<List<Customer>> GetCustomerByPhone(int phoneNumber) => throw new NotImplementedException();
        #endregion

        #region Purchase
        public async Task<int> AddPurchase(Purchase Purchaseitem) => throw new NotImplementedException();
        public async Task<int> UpdatePurchase(Purchase Purchaseitem) => throw new NotImplementedException();
        public async Task<int> DeletePurchase(Purchase Purchaseitem) => throw new NotImplementedException();
        public async Task<List<Purchase>> GetAllPendingPurchases() => throw new NotImplementedException();
        public async Task<List<Purchase>> GetAllCompletePurchases() => throw new NotImplementedException();
        public async Task<List<Purchase>> GetTodaysPurchase() => throw new NotImplementedException();
        public async Task<List<Purchase>> GetPurchaseById(int purchaseid) => throw new NotImplementedException();
        public async Task<int> ApprovedPurchase(int purchaseid) => throw new NotImplementedException();
        #endregion

        #region MetalTypes
        public async Task<int> AddMetalType(MetelType metelType) => throw new NotImplementedException();

        public async Task<int> DeleteMetalType(MetelType metelType) => throw new NotImplementedException();

        public async Task<List<MetelType>> GetAllMetalType() => throw new NotImplementedException();
        #endregion

        #region Brands
        public async Task<int> AddBrand(Brand brand) => throw new NotImplementedException();

        public async Task<int> DeleteBrand(Brand brand) => throw new NotImplementedException();

        public async Task<List<Brand>> GetAllBrand() => throw new NotImplementedException();

        public async Task<List<Brand>> GetBrandByMetalType(string metalType) => throw new NotImplementedException();

        #endregion
    }
}

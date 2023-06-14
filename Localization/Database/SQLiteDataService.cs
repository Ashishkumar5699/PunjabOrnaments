using Punjab_Ornaments.Localization.GlobalContants;
using Punjab_Ornaments.Models;
using Punjab_Ornaments.Models.Stock;
using SQLite;

namespace Punjab_Ornaments.Localization.Database
{
    public partial class SQLiteDataService : ILocalDataService
    {
        #region initialization
        private static readonly Lazy<SQLiteAsyncConnection> LazyInitializer = new(() =>
        {
            return new SQLiteAsyncConnection(DatabaseConstant.DatabasePath, DatabaseConstant.Flags);
        });

        private static SQLiteAsyncConnection Database => LazyInitializer.Value;

        public void Initialize()
        {
            var database = new SQLiteConnection(DatabaseConstant.DatabasePath);
            CreateTables(database);
        }

        private void CreateTables(SQLiteConnection database)
        {
                database.CreateTable<Customer>();
                database.CreateTable<Gold>();
                database.CreateTable<Purchase>();
        }
        #endregion

        #region Gold
        public async Task<int> AddGoldinStock(Gold gold) => await Database.InsertAsync(gold);
        public async Task<int> UpdateGoldinStock(Gold gold) => await Database.UpdateAsync(gold);
        public async Task<int> DeleteGoldFromStock(Gold gold) => await Database.DeleteAsync(gold);
        public async Task<List<Gold>> GetAllGoldStock() => await Database.QueryAsync<Gold>("SELECT * FROM Gold");
        public async Task<List<Gold>> GetGoldStockById(int id) => await Database.QueryAsync<Gold>($"SELECT * FROM Gold WHERE Id = '{id}'");
        #endregion

        #region Customer
        public async Task<int> AddCustomer(Customer custmor) => await Database.InsertAsync(custmor);

        public async Task<int> UpdateCustpmer(Customer custmor) => await Database.UpdateAsync(custmor);

        public async Task<int> DeleteCustomer(Customer custmor) => await Database.DeleteAsync(custmor);

        public async Task<List<Customer>> GetAllCustomers() => await Database.QueryAsync<Customer>("SELECT * FROM Customer");
        public async Task<List<Customer>> GetCustomerByPhone(int phoneNumber) => await Database.QueryAsync<Customer>($"SELECT * FROM Customer WHERE CustmorPhoneNumber = '{phoneNumber}'");
        #endregion

        #region Purchase

        public async Task<int> AddPurchase(Purchase Purchaseitem) => await Database.InsertAsync(Purchaseitem);

        public async Task<int> UpdatePurchase(Purchase Purchaseitem) => await Database.UpdateAsync(Purchaseitem);

        public async Task<int> DeletePurchase(Purchase Purchaseitem) => await Database.DeleteAsync(Purchaseitem);

        public async Task<List<Purchase>> GetAllPendingPurchases() => await Database.QueryAsync<Purchase>("SELECT * FROM Purchase WHERE IsCompleted = 0");
        public async Task<List<Purchase>> GetAllCompletePurchases() => await Database.QueryAsync<Purchase>("SELECT * FROM Purchase WHERE IsCompleted = 1");

        public async Task<List<Purchase>> GetTodaysPurchase() => await Database.QueryAsync<Purchase>($"SELECT * FROM Customer WHERE PurchaseDate = '{DateTime.Today.Date}'");
        #endregion
    }
}

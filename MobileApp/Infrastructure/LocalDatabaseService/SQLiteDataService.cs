﻿using Punjab_Ornaments.Models;
using Punjab_Ornaments.Models.AdminPannel;
using Punjab_Ornaments.Models.Auth;
using Punjab_Ornaments.Models.Stock;
using Punjab_Ornaments.Resources.Constant;
using SQLite;

namespace Punjab_Ornaments.Infrastructure.Database
{
    public partial class SQLiteDataService : IDataService
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
        private static void CreateTables(SQLiteConnection database)
        {
            database.CreateTable<Customer>();
            database.CreateTable<Gold>();
            database.CreateTable<Purchase>();
            database.CreateTable<MetelType>();
            database.CreateTable<Brand>();
        }
        #endregion

        #region Auth
        public Task<LoginUser> LoginUser(LoginUser loginUser)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Gold
        public async Task<int> AddGoldinStock(Gold gold) => await Database.InsertAsync(gold);
        public async Task<int> UpdateGoldinStock(Gold gold) => await Database.UpdateAsync(gold);
        public async Task<int> DeleteGoldFromStock(Gold gold) => await Database.DeleteAsync(gold);
        public async Task<List<Gold>> GetAllGoldStock() => await Database.QueryAsync<Gold>("SELECT * FROM Gold");
        public async Task<List<Gold>> GetGoldStockById(int id) => await Database.QueryAsync<Gold>($"SELECT * FROM Gold WHERE Id = '{id}'");
        #endregion

        #region Approval Section
        public async Task<List<Purchase>> GetAllPendingPurchaseRequests() => await Database.QueryAsync<Purchase>($"SELECT * FROM Purchase WHERE IsApproved={null}");

        public async Task<List<Purchase>> GetAllCompletePurchaseRequests() => await Database.QueryAsync<Purchase>($"SELECT * FROM Purchase WHERE IsApproved!={null}");
        #endregion

        #region Customer
        public async Task<int> AddCustomer(Customer custmor) => await Database.InsertAsync(custmor);
        public async Task<int> UpdateCustpmer(Customer custmor) => await Database.UpdateAsync(custmor);
        public async Task<int> DeleteCustomer(Customer custmor) => await Database.DeleteAsync(custmor);
        public async Task<List<Customer>> GetAllCustomers() => await Database.QueryAsync<Customer>("SELECT * FROM Customer");
        public async Task<List<Customer>> GetCustomerByPhone(int phoneNumber) => await Database.QueryAsync<Customer>($"SELECT * FROM Customer WHERE CustmorPhoneNumber = '{phoneNumber}'");
        #endregion

        #region Approve Purchase
        public async Task<int> AddPurchase(Purchase Purchaseitem) => await Database.InsertAsync(Purchaseitem);
        public async Task<int> UpdatePurchase(Purchase Purchaseitem) => await Database.UpdateAsync(Purchaseitem);
        public async Task<int> DeletePurchase(Purchase Purchaseitem) => await Database.DeleteAsync(Purchaseitem);
        public async Task<List<Purchase>> GetAllPendingPurchases() => await Database.QueryAsync<Purchase>("SELECT * FROM Purchase");
        public async Task<List<Purchase>> GetAllCompletePurchases() => await Database.QueryAsync<Purchase>("SELECT * FROM Purchase WHERE IsApproved = 1");
        public async Task<List<Purchase>> GetTodaysPurchase() => await Database.QueryAsync<Purchase>($"SELECT * FROM Customer WHERE PurchaseDate = '{DateTime.Today.Date}'");
        public async Task<List<Purchase>> GetPurchaseById(int purchaseRequestId) => await Database.QueryAsync<Purchase>($"SELECT * FROM Purchase WHERE PurchaseRequestId = '{purchaseRequestId}' ");
        public async Task<int> ApprovedPurchase(int purchaseRequestId, int isapproved) => await Database.ExecuteAsync($"UPDATE Purchase SET IsApproved = {isapproved} WHERE PurchaseRequestId = '{purchaseRequestId}'");
        #endregion

        #region MetalTypes
        public async Task<int> AddMetalType(MetelType metelType) => await Database.InsertAsync(metelType);

        public async Task<int> DeleteMetalType(MetelType metelType) => await Database.DeleteAsync(metelType);

        public async Task<List<MetelType>> GetAllMetalType() => await Database.QueryAsync<MetelType>("SELECT * FROM MetelType");
        #endregion

        #region Brands
        public async Task<int> AddBrand(Brand brand) => await Database.InsertAsync(brand);

        public async Task<int> DeleteBrand(Brand brand) => await Database.DeleteAsync(brand);

        public async Task<List<Brand>> GetAllBrand() => await Database.QueryAsync<Brand>("SELECT * FROM Brand");

        public async Task<List<Brand>> GetBrandByMetalType(string metalType) => await Database.QueryAsync<Brand>($"SELECT * FROM Brand WHERE MetalType = '{metalType}'");
        #endregion
    }
}
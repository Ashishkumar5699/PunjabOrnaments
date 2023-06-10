﻿using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;
using System.Windows.Input;

namespace Punjab_Ornaments.Presentation.Viewmodels.Purchase
{
    public partial class AddPurchaseViewModel : BaseViewModel
    {
        #region Private Members
        private Models.Stock.Purchase _purchaseItem;
        #endregion

        #region Commands
        public ICommand AddPurchaseCommnad => new Command(async () => await AddPurchaseAsync(PurchaseItem));
        #endregion
        
        #region constructor and initial methods
        public AddPurchaseViewModel(ILocalDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
        {
        
        }

        public async Task OnAppearing()
        {
            UpdateDefaultValues();
        }
        #endregion

        #region BindableProperties
        public Models.Stock.Purchase PurchaseItem
        {
            get => _purchaseItem;
            set
            {
                _purchaseItem = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #region Methods
        async Task AddPurchaseAsync(Models.Stock.Purchase purchaseItem)
        {
            if (AddPurchaseViewModel.PurchaseItemValidation(purchaseItem))
            {
                await _localDataService.AddPurchase(purchaseItem);
            }
            else
                await Application.Current.MainPage.DisplayAlert("Error", "please fill all fields", "Okay");
        }
        private void UpdateDefaultValues()
        {
            PurchaseItem = new Models.Stock.Purchase
                            {
                                //PurchaseId
                                MatelType = null,//string.Empty,
                                ItemType = string.Empty,
                                Brand = string.Empty,
                                ManufactureId = string.Empty,
                                ManufactureName = string.Empty,
                                GrossWeight = 0,
                                LessWeight = 0,
                                NetWeight = 0,
                                Quantity = 0,
                                Rate = 0,
                                Wastage = 0,
                                Labour = 0,
                                PurchaseDate = DateTime.Today,
                            };
        }

        private static bool PurchaseItemValidation(Models.Stock.Purchase purchaseItem)
        {
            if (purchaseItem.MatelType == string.Empty) return false;
            else if (purchaseItem.ItemType == string.Empty) return false;
            else if (purchaseItem.Brand == string.Empty) return false;
            else if (purchaseItem.ManufactureId  == string.Empty) return false;
            else if (purchaseItem.ManufactureName == string.Empty) return false;
            else if (purchaseItem.GrossWeight == 0) return false;
            else if (purchaseItem.LessWeight == 0) return false;
            else if (purchaseItem.NetWeight <= 0) return false;
            else if (purchaseItem.Quantity == 0) return false;
            else if (purchaseItem.Rate == 0) return false;
            else if (purchaseItem.Wastage == 0) return false;
            else if (purchaseItem.NetWeight == 0) return false;
            else if (purchaseItem.NetWeight == 0) return false;

            return true;
        }

        internal void UpdateWeight()
        {
            PurchaseItem.NetWeight = PurchaseItem.GrossWeight - PurchaseItem.LessWeight;
        }
        #endregion
    }
}

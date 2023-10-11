﻿using CommunityToolkit.Mvvm.ComponentModel;
using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Models;

namespace Punjab_Ornaments.Presentation.Viewmodels
{
    [QueryProperty(nameof(Id), "id")]
    public partial class GoldStockDetailPageViewModel : BaseViewModel
    {
        #region private Members
        private int _id;
        #endregion
        #region Constructor and override methods
<<<<<<< HEAD
        public GoldStockDetailPageViewModel(ILocalDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
=======
        public GoldStockDetailPageViewModel(IDataService localDataService, INavigationService navigationservice, IAPIService apiservice) : base(localDataService, navigationservice, apiservice)
>>>>>>> ebe3029 (Mobile Application API integration Structure added)
        {
        }
        #endregion
        public async Task OnAppearing()
        {
            var GoldStockDetailList = await _dataService.GetGoldStockById(Id);
            GoldStock = GoldStockDetailList.FirstOrDefault();
        }

        #region Bindable Properties

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        [ObservableProperty]
        public Gold goldStock;
        #endregion
    }
}

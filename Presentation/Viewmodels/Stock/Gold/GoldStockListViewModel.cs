﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;
using Punjab_Ornaments.Models;
using Punjab_Ornaments.Models.Enum;
using System.Collections.ObjectModel;

namespace Punjab_Ornaments.Presentation.Viewmodels
{
    public partial class GoldStockListViewModel : BaseViewModel
    {
        #region private Members
        private ObservableCollection<Gold> _goldStockList;
        #endregion

        #region Constructor and override methods
        public GoldStockListViewModel(ILocalDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
        {
        }
        public async Task OnAppearing()
        {
            var listofStock = await _localDataService.GetAllGoldStock();
            GoldStockList = new ObservableCollection<Gold>(listofStock);
        }

        #endregion

        #region Bindable Properties
        public ObservableCollection<Gold> GoldStockList
        {
            get => _goldStockList;
            set
            {
                _goldStockList = value;
                OnPropertyChanged();
            }
        }

        #region propertygeneratebypackage
        [ObservableProperty]
        string code;

        [ObservableProperty]
        decimal weight;

        [ObservableProperty]
        string image;

        [ObservableProperty]
        Brand brand;

        [ObservableProperty]
        CarrotEnum carrot;
        #endregion

        #endregion

        #region Command
        [RelayCommand]
        public static async Task NavigateToAddnewPage() => await Shell.Current.GoToAsync("/AddGoldStock");

        [RelayCommand]
        public void AddNewItem()
        {
            Gold gold = new() { Code = Code, Weight = Weight, Image = Image, Brand = Brand, Carrot = Carrot};
            _localDataService.AddGoldinStock(gold);
            _navigationservice.PopAsync();
        }

        [RelayCommand]
        public static void DeleteItem(Gold gold)
        {
            //Gold gold = new() { Code = Code, Weight = Weight, Image = Image, Brand = Brand, Carrot = Carrat };
            //_localDataService.AddGoldinStock(gold);
            //navigationservice.PopAsync();
        }

        [RelayCommand]
        public static async Task NavigatetoDetailPage(int id)
        {
            await Shell.Current.GoToAsync("/GoldStockDetailPage", new Dictionary<string, object> { { "id", id } });
        }
        //await navigationservice.NavigateToAsync("/GoldStockDetailPage", gold.Id.ToString());
        #endregion
    }
}

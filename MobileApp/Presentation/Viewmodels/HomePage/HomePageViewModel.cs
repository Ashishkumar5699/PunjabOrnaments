using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Infrastructure.Navigation;
using System.Windows.Input;

namespace Punjab_Ornaments.Presentation.Viewmodels
{
    public partial class HomePageViewModel : BaseViewModel
    {
        #region Commands
        public ICommand NavigateToAddNewCustmorPageCommnad => new Command(async () => await NavigateToAddNewCustmerPageAsync());
        public ICommand NavigateToViewAllCustmorPageCommnad => new Command(async () => await NavigateToViewAllCustmorPageAsync());
        public ICommand NavigateToAddPurchasePageCommnad => new Command(async () => await NavigateToAddPurchasePageAsync());
        #endregion
        #region Constructor and init functions
        public HomePageViewModel(ILocalDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
        {
        }
        #endregion
        #region Properties

        [ObservableProperty]
        string custmorName;

        [ObservableProperty]
        public DateTime billDate;

        [ObservableProperty]
        public int mobileNumber;

        [ObservableProperty]
        public string state;

        [ObservableProperty]
        public string address;
        #endregion

        #region Methods
        [RelayCommand]
        async Task Stock() => await _navigationservice.NavigateToAsync("StockView");
        async Task NavigateToAddNewCustmerPageAsync() => await _navigationservice.NavigateToAsync("AddNewCustomerPage");
        async Task NavigateToViewAllCustmorPageAsync() => await _navigationservice.NavigateToAsync("CustomerListPage");
        async Task NavigateToAddPurchasePageAsync() => await _navigationservice.NavigateToAsync("AddPurchase");
        #endregion

    }
}

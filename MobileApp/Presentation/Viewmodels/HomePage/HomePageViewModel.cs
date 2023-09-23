using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Punjab_Ornaments.Infrastructure.BillGeneration;
using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Infrastructure.Navigation;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System.Reflection;
using System.Windows.Input;
using Color = Syncfusion.Drawing.Color;
using SizeF = Syncfusion.Drawing.SizeF;

namespace Punjab_Ornaments.Presentation.Viewmodels
{
    public partial class HomePageViewModel : BaseViewModel
    {
        #region Commands
        public ICommand NavigateToAddNewCustmorPageCommnad => new Command(async () => await NavigateToAddNewCustmerPageAsync());
        public ICommand NavigateToViewAllCustmorPageCommnad => new Command(async () => await NavigateToViewAllCustmorPageAsync());
        public ICommand NavigateToAddPurchasePageCommnad => new Command(async () => await NavigateToAddPurchasePageAsync());
        public ICommand NavigateToSaleQuatationPageCommnad => new Command(async () => await NavigateToSaleQuatationPageAsync());
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
        //#endregion

        //#region Methods
        [RelayCommand]
        async Task Stock() => await _navigationservice.NavigateToAsync("StockView");
        async Task NavigateToAddNewCustmerPageAsync() => await _navigationservice.NavigateToAsync("AddNewCustomerPage");
        async Task NavigateToViewAllCustmorPageAsync() => await _navigationservice.NavigateToAsync("CustomerListPage");
        async Task NavigateToAddPurchasePageAsync() => await _navigationservice.NavigateToAsync("AddPurchase");
        async Task NavigateToSaleQuatationPageAsync()
        {
            try
            {
                await _navigationservice.NavigateToAsync("SaleQuatationPage");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion
    }
}
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;
using System.Collections.ObjectModel;

namespace Punjab_Ornaments.Presentation.Viewmodels.Purchase
{
    public partial class AddPurchaseViewModel : BaseViewModel
    {
        #region Private Members
        private ObservableCollection<Models.Stock.Purchase> _purchaseList;
        #endregion

        #region Commands
        //public ICommand NavigateToAddNewCustmorPageCommnad => new Command(async () => await NavigateToAddNewCustmerPageAsync());
        #endregion
        
        #region constructor and initial methods
        public AddPurchaseViewModel(ILocalDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
        {
        
        }

        public async Task OnAppearing()
        {
            var _allpurchaselist = await _localDataService.GetAllPurchases();
            PurchaseList = new ObservableCollection<Models.Stock.Purchase>(_allpurchaselist);
        }
        #endregion

        #region BindableProperties
        public ObservableCollection<Models.Stock.Purchase> PurchaseList
        {
            get => _purchaseList;
            set
            {
                _purchaseList = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}

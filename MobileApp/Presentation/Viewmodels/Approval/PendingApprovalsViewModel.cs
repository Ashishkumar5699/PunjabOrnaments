using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;
using Punjab_Ornaments.Models.Stock;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Punjab_Ornaments.Presentation.Viewmodels.Approval
{
    public partial class PendingApprovalsViewModel : BaseViewModel
    {
        #region Private Members
        private ObservableCollection<Models.Stock.Purchase> _pendingPuchaseList;
        #endregion

        #region Commands
        public ICommand NavigateToPurchaseDetailPageCommnad => new Command<int>(async (purchaseid) => await NavigateToPurchaseDetailPageAsync(purchaseid));
        #endregion

        #region construction and init methods
        public PendingApprovalsViewModel(ILocalDataService localDataService, INavigationService navigationservice, IAPIService apiservice) : base(localDataService, navigationservice, apiservice)
        {
        }

        internal async Task OnAppearing()
        {
            var _pendingpurchaselist = await _localDataService.GetAllPendingPurchases();
            PendingPuchaseList = new ObservableCollection<Purchase>(_pendingpurchaselist);
        }
        #endregion

        #region Bindable Properties
        public ObservableCollection<Models.Stock.Purchase> PendingPuchaseList
        {
            get => _pendingPuchaseList;
            set
            {
                _pendingPuchaseList = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #region Methods
        private async Task NavigateToPurchaseDetailPageAsync(int purchaseid)
        {
            await _navigationservice.NavigateToAsync("PurchaseDetailPage", "PurchaseId", purchaseid);
        }
        #endregion
    }
}

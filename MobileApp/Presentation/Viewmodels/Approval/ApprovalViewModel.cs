using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Infrastructure.Navigation;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Punjab_Ornaments.Presentation.Viewmodels.Approval
{
    public partial class ApprovalViewModel : BaseViewModel
    {
        #region Private Members
        private ObservableCollection<Models.Stock.Purchase> _puchaseList;

        #endregion

        #region Commands
        public ICommand NavigateToPurchaseDetailPageCommnad => new Command<int>(async (purchaseid) => await NavigateToPurchaseDetailPageAsync(purchaseid));
        #endregion


        public ApprovalViewModel(ILocalDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
        {
        }
        #region Bindable Properties
        public ObservableCollection<Models.Stock.Purchase> PuchaseList
        {
            get => _puchaseList;
            set
            {
                _puchaseList = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Methods
        public async Task<List<Models.Stock.Purchase>> GetAllPendingPurchaseRequests() => await _localDataService.GetAllPendingPurchases();

        private async Task NavigateToPurchaseDetailPageAsync(int purchaseid) => await _navigationservice.NavigateToAsync("PurchaseDetailPage", "PurchaseId", purchaseid);
        #endregion
    }
}

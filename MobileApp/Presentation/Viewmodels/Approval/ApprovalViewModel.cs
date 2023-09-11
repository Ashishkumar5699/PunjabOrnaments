using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;
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


        public ApprovalViewModel(ILocalDataService localDataService, INavigationService navigationservice, IAPIService apiservice) : base(localDataService, navigationservice, apiservice)
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
        public async Task<List<Models.Stock.Purchase>> GetAllPurchaseRequests()
        {
            return await _apiservice.GetAllPurchaseRequest();
        }
        private async Task NavigateToPurchaseDetailPageAsync(int purchaseid)
        {
            if (purchaseid != 0)
                await _navigationservice.NavigateToAsync("PurchaseDetailPage", "PurchaseId", purchaseid);
        }
        #endregion
    }
}

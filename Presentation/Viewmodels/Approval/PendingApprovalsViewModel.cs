using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;
using Punjab_Ornaments.Models.Stock;
using System.Collections.ObjectModel;

namespace Punjab_Ornaments.Presentation.Viewmodels.Approval
{
    public partial class PendingApprovalsViewModel : BaseViewModel
    {
        #region Private
        private ObservableCollection<Models.Stock.Purchase> _pendingPuchaseList;
        #endregion

        #region construction and init method
        public PendingApprovalsViewModel(ILocalDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
        {
        }

        internal async Task OnAppearing()
        {
            var _pendingpurchaselist = await _localDataService.GetAllPendingPurchases();
            PendingPuchaseList = new ObservableCollection<Purchase>(_pendingpurchaselist);
        }
        #endregion

        #region Bindable Property
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
    }
}

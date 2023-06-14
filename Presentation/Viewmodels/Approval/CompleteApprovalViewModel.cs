using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;
using Punjab_Ornaments.Models.Stock;
using System.Collections.ObjectModel;

namespace Punjab_Ornaments.Presentation.Viewmodels.Approval
{
    public partial class CompleteApprovalViewModel : BaseViewModel
    {
        #region Private
        private ObservableCollection<Models.Stock.Purchase> _completePuchaseList;
        #endregion

        #region construction and init method
        public CompleteApprovalViewModel(ILocalDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
        {
        }

        internal async Task OnAppearing()
        {
            var _pendingpurchaselist = await _localDataService.GetAllCompletePurchases();
            CompletePuchaseList = new ObservableCollection<Purchase>(_pendingpurchaselist);
        }
        #endregion
        #region Bindable Property
        public ObservableCollection<Purchase> CompletePuchaseList
        {
            get => _completePuchaseList;
            set
            {
                _completePuchaseList = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}

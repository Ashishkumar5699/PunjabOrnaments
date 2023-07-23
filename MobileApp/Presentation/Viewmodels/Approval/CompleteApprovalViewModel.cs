using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;
using Punjab_Ornaments.Models.Stock;
using System.Collections.ObjectModel;

namespace Punjab_Ornaments.Presentation.Viewmodels.Approval
{
    public partial class CompleteApprovalViewModel : BaseViewModel
    {
        #region Private Members
        private ObservableCollection<Purchase> _completePuchaseList;
        #endregion

        #region construction and init methods
        public CompleteApprovalViewModel(ILocalDataService localDataService, INavigationService navigationservice, IAPIService apiservice) : base(localDataService, navigationservice, apiservice)
        {
        }
        internal async Task OnAppearing()
        {
            //var _pendingpurchaselist = await _localDataService.GetAllCompletePurchases();
            var _Completepurchaselist = await _apiservice.GetAllPurchaseRequest();
            CompletePuchaseList = new ObservableCollection<Purchase>(_Completepurchaselist.Where(x => x.IsApproved == 1));
        }
        #endregion
        #region Bindable Properties
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

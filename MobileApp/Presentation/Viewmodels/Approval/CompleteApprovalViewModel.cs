using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;
using System.Collections.ObjectModel;

namespace Punjab_Ornaments.Presentation.Viewmodels.Approval
{
    public partial class CompleteApprovalViewModel : ApprovalViewModel
    {

        #region construction and init methods
        public CompleteApprovalViewModel(IDataService localDataService, INavigationService navigationservice, IAPIService apiservice) : base(localDataService, navigationservice, apiservice)
        {
        }
        internal async Task OnAppearing()
        {
            //var _pendingpurchaselist = await _localDataService.GetAllCompletePurchases();
            var _purchaselist = await GetAllPurchaseRequests();
            PuchaseList = new ObservableCollection<Models.Stock.Purchase>(_purchaselist.Where(x => x.IsApproved != null));
        }
        #endregion
    }
}

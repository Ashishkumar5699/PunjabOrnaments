using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;
using System.Collections.ObjectModel;

namespace Punjab_Ornaments.Presentation.Viewmodels.Approval
{
    public partial class PendingApprovalsViewModel : ApprovalViewModel
    {
        #region Private Members
        public PendingApprovalsViewModel(ILocalDataService localDataService, INavigationService navigationservice, IAPIService apiservice) : base(localDataService, navigationservice, apiservice)
        {
        }

        internal async Task OnAppearing()
        {
            //var _pendingpurchaselist = await _localDataService.GetAllPendingPurchases();
            var _purchaselist = await GetAllPurchaseRequests();
            PuchaseList = new ObservableCollection<Models.Stock.Purchase>(_purchaselist.Where(x => x.IsApproved == null));
        }
        #endregion
    }
}

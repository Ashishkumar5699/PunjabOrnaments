using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Infrastructure.Navigation;
using System.Collections.ObjectModel;

namespace Punjab_Ornaments.Presentation.Viewmodels.Approval
{
    public partial class PendingApprovalsViewModel : ApprovalViewModel
    {
        #region Private Members
        public PendingApprovalsViewModel(IDataService localDataService, INavigationService navigationservice, IAPIService apiservice) : base(localDataService, navigationservice, apiservice)
        {
        }

        internal async Task OnAppearing()
        {
            var _purchaselist = await GetAllPendingPurchaseRequests();
            PuchaseList = new ObservableCollection<Models.Stock.Purchase>(_purchaselist.Where(x => x.IsApproved == null));
        }
        #endregion
    }
}

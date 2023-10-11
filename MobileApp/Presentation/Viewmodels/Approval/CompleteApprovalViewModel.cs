﻿using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Infrastructure.Navigation;
using System.Collections.ObjectModel;

namespace Punjab_Ornaments.Presentation.Viewmodels.Approval
{
    public partial class CompleteApprovalViewModel : ApprovalViewModel
    {

        #region construction and init methods
<<<<<<< HEAD
        public CompleteApprovalViewModel(ILocalDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
=======
        public CompleteApprovalViewModel(IDataService localDataService, INavigationService navigationservice, IAPIService apiservice) : base(localDataService, navigationservice, apiservice)
>>>>>>> ebe3029 (Mobile Application API integration Structure added)
        {
        }
        internal async Task OnAppearing()
        {
            //var _pendingpurchaselist = await _localDataService.GetAllCompletePurchases();
            var _purchaselist = await GetAllPendingPurchaseRequests();
            PuchaseList = new ObservableCollection<Models.Stock.Purchase>(_purchaselist.Where(x => x.IsApproved != null));
        }
        #endregion
    }
}

using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;
using Punjab_Ornaments.Models.Stock;
using System.Windows.Input;

namespace Punjab_Ornaments.Presentation.Viewmodels.Approval
{
    [QueryProperty(nameof(PurchaseRequestId), "PurchaseId")]
    public partial class PurchaseDetailViewModel : BaseViewModel
    {
        #region Private Members
        public int _purchaserequestId;
        private Purchase _purchaseitem;
        #endregion

        #region Commands
        public ICommand ApprovedCommnad => new Command<int>(async (purchaseid) => await ApprovedAsync(purchaseid));
        #endregion

        #region Constructor and init methods
        public PurchaseDetailViewModel(ILocalDataService localDataService, INavigationService navigationservice, IAPIService apiservice) : base(localDataService, navigationservice, apiservice)
        {
        }
        internal async Task OnAppearing()
        {
            //var purchaseitem = await _localDataService.GetPurchaseById(PurchaseRequestId);
            var purchaseitem = await _apiservice.GetPurchaseById(PurchaseRequestId);
            Purchaseitem = purchaseitem;
        }
        #endregion

        #region Bindable Properties
        public int PurchaseRequestId
        {
            get => _purchaserequestId;
            set
            {
                _purchaserequestId = value;
                OnPropertyChanged(nameof(PurchaseRequestId));
            }
        }
        public Purchase Purchaseitem
        {
            get => _purchaseitem;
            set
            {
                _purchaseitem = value;
                OnPropertyChanged(nameof(Purchaseitem));
            }
        }
        #endregion

        #region Methods
        private async Task ApprovedAsync(int purchaseid)
        {
            //var approved = await _localDataService.ApprovedPurchase(purchaseid);
            var approved = await _apiservice.GoldApprove(purchaseid);
            //if (approved > 0)
            //{
                await _navigationservice.PopAsync();
            //}
        }
        #endregion
    }
}

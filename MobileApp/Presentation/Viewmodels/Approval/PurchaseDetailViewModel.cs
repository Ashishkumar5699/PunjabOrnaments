using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;
using Punjab_Ornaments.Models.Stock;
using System.Windows.Input;

namespace Punjab_Ornaments.Presentation.Viewmodels.Approval
{
    [QueryProperty(nameof(PurchaseId), "PurchaseId")]
    public partial class PurchaseDetailViewModel : BaseViewModel
    {
        #region Private Members
        public int _purchaseId;
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
            var purchaseitem = await _localDataService.GetPurchaseById(PurchaseId);
            Purchaseitem = purchaseitem.FirstOrDefault();
        }
        #endregion

        #region Bindable Properties
        public int PurchaseId
        {
            get => _purchaseId;
            set
            {
                _purchaseId = value;
                OnPropertyChanged(nameof(PurchaseId));
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
            var approved = await _localDataService.ApprovedPurchase(purchaseid);
            if (approved > 0)
            {
                await _navigationservice.PopAsync();
            }
        }
        #endregion
    }
}

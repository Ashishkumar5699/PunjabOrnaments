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
        private bool _approverejectbtnvisible;
        private bool _deletebtnvisible;
        private bool _addtostockbtnvisible;
        #endregion

        #region Commands
        public ICommand ApprovedCommnad => new Command<int>(async (purchaseid) => await ApprovedAsync(purchaseid));
        public ICommand RejectCommnad => new Command<int>(async (purchaseid) => await RejectAsync(purchaseid));
        public ICommand DeleteCommnad => new Command<int>(async (purchaseid) => await DeleteAsync(purchaseid));

        public ICommand AddToStockCommnad => new Command<int>(async (purchaseid) => await AddToStockAsync(purchaseid));

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
            init();
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
        public bool ApproveRejectbtnvisible
        {
            get => _approverejectbtnvisible;
            set
            {
                _approverejectbtnvisible = value;
                OnPropertyChanged(nameof(ApproveRejectbtnvisible));
            }
        }
        public bool Deletebtnvisible
        {
            get => _deletebtnvisible;
            set
            {
                _deletebtnvisible = value;
                OnPropertyChanged(nameof(Deletebtnvisible));
            }
        }
        public bool AddtoStockbtnvisible
        {
            get => _addtostockbtnvisible;
            set
            {
                _addtostockbtnvisible = value;
                OnPropertyChanged(nameof(AddtoStockbtnvisible));
            }
        }
        #endregion

        #region Methods
        private void init()
        {
            ShowButtons();
        }
        private void ShowButtons()
        {
            if (Purchaseitem != null)
                return;

            ApproveRejectbtnvisible = Purchaseitem.IsApproved == null;

            if (ApproveRejectbtnvisible)
                return;
            
            Deletebtnvisible = Purchaseitem.IsApproved == 0;
            AddtoStockbtnvisible = !Deletebtnvisible;
        }
        private async Task ApprovedAsync(int purchaseid)
        {
            await _apiservice.GoldApprove(purchaseid);
            ApproveRejectbtnvisible = false;
            AddtoStockbtnvisible = true;
        }
        private async Task RejectAsync(int purchaseid)
        {
            await _apiservice.GoldReject(purchaseid);
            ApproveRejectbtnvisible = false;
            Deletebtnvisible = true;
        }

        private Task DeleteAsync(int purchaseid)
        {
            throw new NotImplementedException();
        }
        private Task AddToStockAsync(int purchaseid)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

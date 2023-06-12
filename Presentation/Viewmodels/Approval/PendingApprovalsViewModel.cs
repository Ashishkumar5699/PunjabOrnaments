using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;

namespace Punjab_Ornaments.Presentation.Viewmodels.Approval
{
    public partial class PendingApprovalsViewModel : BaseViewModel
    {
        public PendingApprovalsViewModel(ILocalDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
        {
        }
    }
}

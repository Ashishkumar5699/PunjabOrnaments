using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;

namespace Punjab_Ornaments.Presentation.Viewmodels.Settings
{
    public partial class MetalTypeDetailPageViewModel : BaseViewModel
    {
        public MetalTypeDetailPageViewModel(ILocalDataService localDataService, INavigationService navigationservice, IAPIService apiservice) : base(localDataService, navigationservice, apiservice)
        {
        }

        internal Task OnAppearing()
        {
            throw new NotImplementedException();
        }
    }
}

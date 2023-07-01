
using CommunityToolkit.Mvvm.ComponentModel;
using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;

namespace Punjab_Ornaments.Presentation.Viewmodels
{
    public class BaseViewModel : ObservableObject
    {
        public readonly ILocalDataService _localDataService;
        public readonly INavigationService _navigationservice;
        public readonly IAPIService _apiservice;

        public BaseViewModel(ILocalDataService localDataService, INavigationService navigationservice, IAPIService apiservice)
        {
            _localDataService = localDataService;
            _navigationservice = navigationservice;
            _apiservice = apiservice;
        }
    }
}

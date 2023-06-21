
using CommunityToolkit.Mvvm.ComponentModel;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;

namespace Punjab_Ornaments.Presentation.Viewmodels
{
    public class BaseViewModel : ObservableObject
    {
        public readonly ILocalDataService _localDataService;
        public readonly INavigationService _navigationservice;

        public BaseViewModel(ILocalDataService localDataService, INavigationService navigationservice)
        {
            _localDataService = localDataService;
            _navigationservice = navigationservice;
        }
    }
}

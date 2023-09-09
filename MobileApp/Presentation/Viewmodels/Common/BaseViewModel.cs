
using CommunityToolkit.Mvvm.ComponentModel;
using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Infrastructure.Navigation;

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

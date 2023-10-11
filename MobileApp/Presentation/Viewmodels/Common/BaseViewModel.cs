
using CommunityToolkit.Mvvm.ComponentModel;
using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Infrastructure.Navigation;

namespace Punjab_Ornaments.Presentation.Viewmodels
{
    public class BaseViewModel : ObservableObject
    {
        public readonly IDataService _dataService;
        public readonly INavigationService _navigationservice;

        public BaseViewModel(IDataService localDataService, INavigationService navigationservice, IAPIService apiservice)
        {
            _dataService = localDataService;
            _navigationservice = navigationservice;
        }
    }
}

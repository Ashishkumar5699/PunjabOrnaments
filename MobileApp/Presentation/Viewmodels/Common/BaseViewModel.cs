
using CommunityToolkit.Mvvm.ComponentModel;
using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;

namespace Punjab_Ornaments.Presentation.Viewmodels
{
    public class BaseViewModel : ObservableObject
    {
        public readonly IDataService _dataService;
        public readonly INavigationService _navigationservice;
        public readonly IAPIService _apiservice;

        public BaseViewModel(IDataService localDataService, INavigationService navigationservice, IAPIService apiservice)
        {
            _dataService = localDataService;
            _navigationservice = navigationservice;
            _apiservice = apiservice;
        }
    }
}

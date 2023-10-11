
using CommunityToolkit.Mvvm.ComponentModel;
using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Infrastructure.Navigation;

namespace Punjab_Ornaments.Presentation.Viewmodels
{
    public class BaseViewModel : ObservableObject
    {
        public readonly IDataService _dataService;
        public readonly INavigationService _navigationservice;

<<<<<<< HEAD
        public BaseViewModel(ILocalDataService localDataService, INavigationService navigationservice)
=======
        public BaseViewModel(IDataService localDataService, INavigationService navigationservice, IAPIService apiservice)
>>>>>>> ebe3029 (Mobile Application API integration Structure added)
        {
            _dataService = localDataService;
            _navigationservice = navigationservice;
        }
    }
}

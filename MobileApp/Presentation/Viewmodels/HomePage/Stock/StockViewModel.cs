using CommunityToolkit.Mvvm.Input;
using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Infrastructure.Navigation;

namespace Punjab_Ornaments.Presentation.Viewmodels
{
    public partial class StockViewModel : BaseViewModel
    {
<<<<<<< HEAD
        public StockViewModel(ILocalDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
=======
        public StockViewModel(IDataService localDataService, INavigationService navigationservice, IAPIService apiservice) : base(localDataService, navigationservice, apiservice)
>>>>>>> ebe3029 (Mobile Application API integration Structure added)
        {
        }

        [RelayCommand]
        public static async Task AddNewGold() => await Shell.Current.GoToAsync("/GoldStockList");
    }
}

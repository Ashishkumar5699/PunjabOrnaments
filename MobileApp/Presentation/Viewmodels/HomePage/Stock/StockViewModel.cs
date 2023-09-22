using CommunityToolkit.Mvvm.Input;
using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Infrastructure.Navigation;

namespace Punjab_Ornaments.Presentation.Viewmodels
{
    public partial class StockViewModel : BaseViewModel
    {
        public StockViewModel(ILocalDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
        {
        }

        [RelayCommand]
        public static async Task AddNewGold() => await Shell.Current.GoToAsync("/GoldStockList");
    }
}

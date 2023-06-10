using CommunityToolkit.Mvvm.Input;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;

namespace Punjab_Ornaments.Presentation.Viewmodels
{
    public partial class StockViewModel : BaseViewModel
    {
        public StockViewModel(ILocalDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
        {
        }

        [RelayCommand]
        public async Task AddNewGold() => await Shell.Current.GoToAsync("/GoldStockList");
    }
}

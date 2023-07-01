using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;
using System.Windows.Input;

namespace Punjab_Ornaments.Presentation.Viewmodels.Settings
{
    public partial class SettingPageViewModel : BaseViewModel
    {
        #region Commands
        public ICommand NavigateToMetalTypePageCommnad => new Command(async () => await NavigateToMetalTypePageAsync());

        #endregion

        #region Constructor and init Functions
        public SettingPageViewModel(ILocalDataService localDataService, INavigationService navigationservice, IAPIService apiservice) : base(localDataService, navigationservice, apiservice)
        {
        }
        public async Task OnAppearing()
        {
            await Task.CompletedTask;
        }
        #endregion

        #region Methods
        public async Task NavigateToMetalTypePageAsync()
        {
            await _navigationservice.NavigateToAsync("MetalTypePage");
        }
        #endregion
    }
}

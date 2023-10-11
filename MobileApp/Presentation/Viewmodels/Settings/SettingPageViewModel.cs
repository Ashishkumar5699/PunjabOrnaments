﻿using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Infrastructure.Navigation;
using System.Windows.Input;

namespace Punjab_Ornaments.Presentation.Viewmodels.Settings
{
    public partial class SettingPageViewModel : BaseViewModel
    {
        #region Commands
        public ICommand NavigateToMetalTypePageCommnad => new Command(async () => await NavigateToMetalTypePageAsync());

        #endregion

        #region Constructor and init Functions
<<<<<<< HEAD
        public SettingPageViewModel(ILocalDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
=======
        public SettingPageViewModel(IDataService localDataService, INavigationService navigationservice, IAPIService apiservice) : base(localDataService, navigationservice, apiservice)
>>>>>>> ebe3029 (Mobile Application API integration Structure added)
        {
        }
        public static async Task OnAppearing()
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

using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Infrastructure.Navigation;
using System.Windows.Input;

namespace Punjab_Ornaments.Presentation.Viewmodels.Auth
{
    public class LoginPageViewModel(IDataService localDataService, INavigationService navigationservice) : BaseViewModel(localDataService, navigationservice)
    {
        public ICommand LoginCommand => new Command(async () => await LoginAction());

        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        private async Task LoginAction()
        {
            try
            {
                IsBusy = true;
                var isAuthorized = await _dataService.LoginUser(UserName, Password);

                if (isAuthorized.Data != null && isAuthorized.Data.IsUserloggedin)
                {
                    Application.Current.MainPage = new AppShell();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}

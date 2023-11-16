using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Models.Auth;
using System.Windows.Input;

namespace Punjab_Ornaments.Presentation.Viewmodels.Auth
{
    public class LoginPageViewModel : BaseViewModel
    {
        public ICommand LoginCommand => new Command(async () => await LoginAction());
        public LoginPageViewModel(IDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
        {
        }

        private string _username;
        public string UserName
        {
            get => _username;
            set => _username = value;
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => _password = value;
        }

        private async Task LoginAction()
        {
            var isauth = await _dataService.LoginUser(UserName, Password);
            if (isauth)
            {
                Application.Current.MainPage = new AppShell();
            }
        }
    }
}

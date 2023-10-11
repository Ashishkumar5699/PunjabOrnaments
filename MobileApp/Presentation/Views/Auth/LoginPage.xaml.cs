using Punjab_Ornaments.Presentation.Viewmodels.Auth;

namespace Punjab_Ornaments.Presentation.Views.Auth;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        if (false)
        {
            await Shell.Current.GoToAsync("///login");
            //await Shell.Current.GoToAsync("HomePageView");
        }
        else
        {
        }
        base.OnNavigatedTo(args);
    }
}
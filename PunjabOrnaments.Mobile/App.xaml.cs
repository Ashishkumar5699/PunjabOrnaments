using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Presentation.Views.Auth;

namespace Punjab_Ornaments;

public partial class App : Application
{
	IDataService _dataService;
    private bool isUserAuth;
    public App(IDataService dataService)
	{
        InitializeComponent();
        InitializeRequired(dataService);
        InitApp();
    }

    private void InitApp()
    {

        isUserAuth = false;

        if (isUserAuth)
    		MainPage = new AppShell();
        else
    		MainPage = new LoginPage();
    }

    private void InitializeRequired(IDataService dataService)
    {
        //_dataService = ServiceHelper.GetService<SQLiteDataService>();
        _dataService = dataService;
        _dataService.Initialize();
    }
}

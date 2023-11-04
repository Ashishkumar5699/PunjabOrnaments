using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Presentation.Viewmodels.Auth;
using Punjab_Ornaments.Presentation.Viewmodels.Common;
using Punjab_Ornaments.Presentation.Views.Auth;

namespace Punjab_Ornaments;

public partial class App : Application
{
	IDataService _dataService;
    private bool isUserAuth;
    public App(IDataService dataService)
	{
        InitializeComponent();
        _dataService = dataService;
        Initapp();
    }

    private void Initapp()
    {
        //_dataService = ServiceHelper.GetService<SQLiteDataService>();
        InitializeRequired(_dataService);

        isUserAuth = true;

        if (isUserAuth)
    		MainPage = new AppShell();
        else
    		MainPage = new LoginPage();
    }

    private void InitializeRequired(IDataService localDataService)
    {
        _dataService = localDataService;
        _dataService.Initialize();
    }
}

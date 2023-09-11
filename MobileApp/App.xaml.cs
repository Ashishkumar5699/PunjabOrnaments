using Punjab_Ornaments.Localization.Database;

namespace Punjab_Ornaments;

public partial class App : Application
{
	ILocalDataService _localDataService;
    public App(ILocalDataService localDataService)
	{
		InitializeComponent();

		MainPage = new AppShell();
        InitializeRequired(localDataService);

    }

    private void InitializeRequired(ILocalDataService localDataService)
    {
        _localDataService = localDataService;
        _localDataService.Initialize();
    }
}

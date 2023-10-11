using Punjab_Ornaments.Infrastructure.Database;

namespace Punjab_Ornaments;

public partial class App : Application
{
	IDataService _localDataService;
    public App(IDataService localDataService)
	{
		InitializeComponent();

		MainPage = new AppShell();
        InitializeRequired(localDataService);

    }

    private void InitializeRequired(IDataService localDataService)
    {
        _localDataService = localDataService;
        _localDataService.Initialize();
    }
}

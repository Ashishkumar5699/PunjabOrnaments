using Punjab_Ornaments.Infrastructure.Database;

namespace Punjab_Ornaments;

public partial class App : Application
{
	IDataService _dataService;
    public App(IDataService localDataService)
	{
		InitializeComponent();

		MainPage = new AppShell();
        InitializeRequired(localDataService);

    }

    private void InitializeRequired(IDataService localDataService)
    {
        _dataService = localDataService;
        _dataService.Initialize();
    }
}

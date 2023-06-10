using Microsoft.Extensions.Logging;
using Punjab_Ornaments.Presentation.Viewmodels;
using Punjab_Ornaments.Presentation.Viewmodels.Purchase;
using Punjab_Ornaments.Presentation.Views;
using Punjab_Ornaments.Presentation.Views.Customer;

namespace Punjab_Ornaments;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.RegisterAppServices();
		builder.RegisterViewModels();
		builder.RegisterViews();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
	public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
	{
        mauiAppBuilder.Services.AddSingleton<HomePageViewModel>();
        mauiAppBuilder.Services.AddSingleton<StockViewModel>();
        mauiAppBuilder.Services.AddSingleton<GoldStockListViewModel>();
        mauiAppBuilder.Services.AddSingleton<GoldStockDetailPageViewModel>();
        mauiAppBuilder.Services.AddSingleton<AddNewCustomerPageViewModel>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Viewmodels.Customer.CustomerListViewModel>();
        mauiAppBuilder.Services.AddSingleton<AddPurchaseViewModel>();
        return mauiAppBuilder;
	}

	public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
	{
		mauiAppBuilder.Services.AddSingleton<Infrastructure.Navigation.INavigationService, Infrastructure.Navigation.NavigationService>();
		mauiAppBuilder.Services.AddSingleton<Localization.Database.ILocalDataService, Localization.Database.SQLiteDataService>();
		return mauiAppBuilder;
	}
	public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
	{
        mauiAppBuilder.Services.AddSingleton<HomePageView>();
        mauiAppBuilder.Services.AddSingleton<StockView>();
        mauiAppBuilder.Services.AddSingleton<GoldStockList>();
        mauiAppBuilder.Services.AddSingleton<AddGoldStock>();
        mauiAppBuilder.Services.AddSingleton<GoldStockDetailPage>();
        mauiAppBuilder.Services.AddSingleton<AddNewCustomerPage>();
        mauiAppBuilder.Services.AddSingleton<CustomerListPage>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Views.Purchase.AddPurchase>();
        return mauiAppBuilder;
	}
}


﻿using Microsoft.Extensions.Logging;

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
        mauiAppBuilder.Services.AddSingleton<Presentation.Viewmodels.HomePageViewModel>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Viewmodels.StockViewModel>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Viewmodels.GoldStockListViewModel>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Viewmodels.GoldStockDetailPageViewModel>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Viewmodels.HomePage.Customer.AddNewCustomerPageViewModel>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Viewmodels.Approval.PendingApprovalsViewModel>();

/* Unmerged change from project 'Punjab Ornaments (net7.0-maccatalyst)'
Before:
        mauiAppBuilder.Services.AddSingleton<Presentation.Viewmodels.Customer.CustomerListViewModel>();
After:
        mauiAppBuilder.Services.AddSingleton<CustomerListViewModel>();
*/
        mauiAppBuilder.Services.AddSingleton<Presentation.Viewmodels.HomePage.Customer.CustomerListViewModel>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Viewmodels.HomePage.Purchase.AddPurchaseViewModel>();
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
        mauiAppBuilder.Services.AddSingleton<Presentation.Views.HomePageView>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Views.StockView>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Views.GoldStockList>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Views.AddGoldStock>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Views.GoldStockDetailPage>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Views.AddNewCustomerPage>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Views.Customer.CustomerListPage>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Views.Purchase.AddPurchase>();
        mauiAppBuilder.Services.AddSingleton<Presentation.Views.Approval.PendingApprovalsView>();
        return mauiAppBuilder;
	}
}


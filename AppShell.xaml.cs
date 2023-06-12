using Punjab_Ornaments.Localization.Database;
using Punjab_Ornaments.Presentation.Views;
using Punjab_Ornaments.Presentation.Views.Approval;
using Punjab_Ornaments.Presentation.Views.Customer;
using Punjab_Ornaments.Presentation.Views.Purchase;

namespace Punjab_Ornaments;

public partial class AppShell : Shell
{
    private ILocalDataService _localDataService;
	public AppShell()
	{
		InitializeComponent();
		RegisterRoutes();
    }

    private void RegisterRoutes()
	{
        Routing.RegisterRoute(nameof(StockView), typeof(StockView));
        Routing.RegisterRoute(nameof(GoldStockList), typeof(GoldStockList));
        Routing.RegisterRoute(nameof(AddGoldStock), typeof(AddGoldStock));
        Routing.RegisterRoute(nameof(GoldStockDetailPage), typeof(GoldStockDetailPage));
        Routing.RegisterRoute(nameof(AddNewCustomerPage), typeof(AddNewCustomerPage));
        Routing.RegisterRoute(nameof(CustomerListPage), typeof(CustomerListPage));
        Routing.RegisterRoute(nameof(AddPurchase), typeof(AddPurchase));
        Routing.RegisterRoute(nameof(PendingApprovalsView), typeof(PendingApprovalsView));
    }
}

using Punjab_Ornaments.Presentation.Viewmodels.HomePage.Sale;
using Punjab_Ornaments.Presentation.Views;
using Punjab_Ornaments.Presentation.Views.Approval;
using Punjab_Ornaments.Presentation.Views.Customer;
using Punjab_Ornaments.Presentation.Views.HomePage.Sale;
using Punjab_Ornaments.Presentation.Views.Purchase;
using Punjab_Ornaments.Presentation.Views.Settings;

namespace Punjab_Ornaments;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		RegisterRoutes();
    }

    private void RegisterRoutes()
	{
        //Home
        Routing.RegisterRoute(nameof(StockView), typeof(StockView));
        Routing.RegisterRoute(nameof(GoldStockList), typeof(GoldStockList));
        Routing.RegisterRoute(nameof(AddGoldStock), typeof(AddGoldStock));
        Routing.RegisterRoute(nameof(GoldStockDetailPage), typeof(GoldStockDetailPage));
        Routing.RegisterRoute(nameof(AddNewCustomerPage), typeof(AddNewCustomerPage));
        Routing.RegisterRoute(nameof(CustomerListPage), typeof(CustomerListPage));
        Routing.RegisterRoute(nameof(AddPurchase), typeof(AddPurchase));

        Routing.RegisterRoute(nameof(SaleQuatationPage), typeof(SaleQuatationPage));

        //Approval
        Routing.RegisterRoute(nameof(PendingApprovalsView), typeof(PendingApprovalsView));
        Routing.RegisterRoute(nameof(CompleteApprovalsView), typeof(CompleteApprovalsView));
        Routing.RegisterRoute(nameof(PurchaseDetailPage), typeof(PurchaseDetailPage));

        //Setting (Admin Panel)
        Routing.RegisterRoute(nameof(SettingPage), typeof(SettingPage));
        Routing.RegisterRoute(nameof(MetalTypePage), typeof(MetalTypePage));
        Routing.RegisterRoute(nameof(MetalTypeDetailPage), typeof(MetalTypeDetailPage));
    }
}

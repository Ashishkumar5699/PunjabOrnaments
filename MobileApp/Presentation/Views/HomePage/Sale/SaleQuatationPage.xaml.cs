using Punjab_Ornaments.Presentation.Viewmodels.HomePage.Sale;

namespace Punjab_Ornaments.Presentation.Views.HomePage.Sale;

public partial class SaleQuatationPage : ContentPage
{
	public SaleQuatationPage(SaleQuatationPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;

    }
}
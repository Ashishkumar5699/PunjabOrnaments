using Punjab_Ornaments.Presentation.Viewmodels.Purchase;

namespace Punjab_Ornaments.Presentation.Views.Purchase;

public partial class AddPurchase : ContentPage
{
	public AddPurchase(AddPurchaseViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var vm = BindingContext as AddPurchaseViewModel;
        await vm.OnAppearing();
    }
}
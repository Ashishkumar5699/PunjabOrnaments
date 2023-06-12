using Punjab_Ornaments.Presentation.Viewmodels.Approval;

namespace Punjab_Ornaments.Presentation.Views.Approval;

public partial class PendingApprovalsView : ContentPage
{
	public PendingApprovalsView(PendingApprovalsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}
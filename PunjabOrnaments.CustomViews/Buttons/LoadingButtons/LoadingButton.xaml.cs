namespace PunjabOrnaments.CustomViews.Buttons.LoadingButtons;

public partial class LoadingButton : ContentView
{
    public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(string), string.Empty, BindingMode.TwoWay, null);
    public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(Command), typeof(Command), null, BindingMode.TwoWay, null);
    public static readonly BindableProperty IsLoadingProperty = BindableProperty.Create("IsLoading", typeof(bool), typeof(bool), string.Empty, BindingMode.TwoWay, null);

    public LoadingButton()
	{
		InitializeComponent();
	}

    public string Text
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public Command Command
    {
        get => (Command)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    public bool IsLoading
    {
        get => (bool)GetValue(IsLoadingProperty);
        set => SetValue(IsLoadingProperty, value);
    }
}
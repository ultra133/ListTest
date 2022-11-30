namespace ListTest;

public partial class AppShell : Shell
{
	public AppShell()
	{
        Scale = 0.7;

		InitializeComponent();

        Scale = 0.7;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        Scale = 0.7;
    }
}


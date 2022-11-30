namespace ListTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var shell = new AppShell();

        MainPage = shell;
	}
}


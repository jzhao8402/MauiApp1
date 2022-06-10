namespace MauiApp1;

public partial class App : Application
{
	public static bool IsLoggedIn = false;
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}

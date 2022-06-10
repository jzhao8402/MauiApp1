using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		BindingContext = new LoginViewModel();
		InitializeComponent();
	}
}
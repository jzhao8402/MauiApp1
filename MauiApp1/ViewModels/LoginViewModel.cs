using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using MauiApp1.Views;

namespace MauiApp1.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        string userName;

        [ObservableProperty]
        string password;
        [ObservableProperty]
        bool isBusy;

        public ICommand LoginCommand { private set; get; }
        public ICommand AboutCommand { private set; get; }
        public LoginViewModel()
        {
            LoginCommand = new Command(
                execute: async () =>
                {
                    await Login();
                },
                canExecute: () =>
                {
                    return !isBusy;
                });
            AboutCommand = new Command(
                 execute: () =>
                 {
                     Application.Current.Dispatcher.Dispatch(async () =>
                     {
                         await Shell.Current.GoToAsync($"///{nameof(AboutPage)}");
                     });
                 },
                canExecute: () =>
                {
                    return true;
                });
        }

        public async Task Login()
        {
            if (IsBusy)
                return;

            if (!string.IsNullOrWhiteSpace(Password) && !string.IsNullOrWhiteSpace(UserName))
            {
                App.IsLoggedIn = true;
                await Task.Delay(1000);
            }
            else { 
            
            }
        }
    }
}

using SocialTemplate.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SocialTemplate.ViewModels
{
    public class LogInViewModel : BaseViewModel
    {
        private string username;
        public string Username
        {
            get => username;
            set => SetProperty(ref username, value);
        }

        private string password;
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        private bool rememberMe;
        public bool RememberMe
        {
            get => rememberMe;
            set => SetProperty(ref rememberMe, value);
        }

        public Command RememberCommand { get; }
        public Command ForgotCommand { get; }
        public Command LogInCommand { get; }
        public Command SignUpCommand { get; }

        public LogInViewModel()
        {
            RememberCommand = new Command(() => { RememberMe = !RememberMe; });

            ForgotCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(ResetPasswordPage)}"));

            LogInCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"//{nameof(HomePage)}"));

            SignUpCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"//{nameof(SignUpPage)}"));
        }

    }
}

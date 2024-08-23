using SocialTemplate.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SocialTemplate.ViewModels
{
    public class ChangePasswordViewModel : BaseViewModel
    {
        private string currentPassword;
        public string CurrentPassword
        {
            get => currentPassword;
            set => SetProperty(ref currentPassword, value);
        }

        private string newPassword;
        public string NewPassword
        {
            get => newPassword;
            set => SetProperty(ref newPassword, value);
        }

        private string confirmNewPassword;
        public string ConfirmNewPassword
        {
            get => confirmNewPassword;
            set => SetProperty(ref confirmNewPassword, value);
        }

        public Command SaveCommand { get; }

        public ChangePasswordViewModel()
        {
            Title = AppResources.ChangePassword;

            SaveCommand = new Command(async () => await Shell.Current.GoToAsync(".."));
        }

    }
}

using SocialTemplate.Resources;
using Xamarin.Forms;

namespace SocialTemplate.ViewModels
{
    public class ResetPasswordViewModel : BaseViewModel 
    {
        public Command SubmitCommand { get; }

        private string email;
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        public ResetPasswordViewModel()
        {
            Title = AppResources.ResetMyPassword;

            SubmitCommand = new Command(async () => await Shell.Current.GoToAsync(".."));
        }
    }
}

using SocialTemplate.Resources;
using SocialTemplate.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace SocialTemplate.ViewModels
{
    [QueryProperty(nameof(PersonId), nameof(PersonId))]
    public class AccountDetailsViewModel : BaseViewModel
    {
        private string personId;
        public string PersonId
        {
            get => personId;
            set
            {
                SetProperty(ref personId, value);
                Load();
            }
        }

        private string cover;
        public string Cover
        {
            get => cover;
            set => SetProperty(ref cover, value);
        }

        private string photo;
        public string Photo
        {
            get => photo;
            set => SetProperty(ref photo, value);
        }

        private string fullName;
        public string FullName
        {
            get => fullName;
            set => SetProperty(ref fullName, value);
        }

        private string username;
        public string Username
        {
            get => username;
            set => SetProperty(ref username, value);
        }

        private string email;
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        private string phone;
        public string Phone
        {
            get => phone;
            set => SetProperty(ref phone, value);
        }

        public Command SaveCommand { get; }
        public Command EditCoverCommand { get; }
        public Command EditPhotoCommand { get; }

        IService service => DependencyService.Get<IService>();

        public AccountDetailsViewModel()
        {
            Title = AppResources.AccountDetails;

            SaveCommand = new Command(SaveCallback);

            EditCoverCommand = new Command(async () => 
                await Shell.Current.DisplayToastAsync(AppResources.EditCoverTapped));

            EditPhotoCommand = new Command(async () =>
                await Shell.Current.DisplayToastAsync(AppResources.EditPhotoTapped));
        }

        async void Load()
        {
            var person = await service.GetPerson(personId);

            Cover = person.Cover;
            Photo = person.Photo;
            FullName = person.FullName;
            Username = person.Username;
            Email = person.Email;
            Phone = person.Phone;
        }

        async void SaveCallback()
        {
            await service.UpdateLoggedPerson(cover, photo, fullName, username, email, phone);
            await Shell.Current.GoToAsync("..");
        }
    }
}

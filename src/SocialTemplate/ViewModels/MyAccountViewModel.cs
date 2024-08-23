using SocialTemplate.Models;
using SocialTemplate.Resources;
using SocialTemplate.Services;
using SocialTemplate.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SocialTemplate.ViewModels
{
    public class MyAccountViewModel : BaseViewModel
    {
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

        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private bool ticked;
        public bool Ticked
        {
            get => ticked;
            set => SetProperty(ref ticked, value);
        }

        private string username;
        public string Username
        {
            get => username;
            set => SetProperty(ref username, value);
        }

        private DateTime memberDate;
        public DateTime MemberDate
        {
            get => memberDate;
            set => SetProperty(ref memberDate, value);
        }

        private int followersCount;
        public int FollowersCount
        {
            get => followersCount;
            set => SetProperty(ref followersCount, value);
        }

        private int followingCount;
        public int FollowingCount
        {
            get => followingCount;
            set => SetProperty(ref followingCount, value);
        }

        private int postCount;
        public int PostCount
        {
            get => postCount;
            set => SetProperty(ref postCount, value);
        }

        public Command FavoritesCommand { get; }
        public Command FollowersCommand { get; }
        public Command FollowingCommand { get; }
        public Command AccountDetailsCommand { get; }
        public Command ChangePasswordCommand { get; }
        public Command LogOutCommand { get; }

        IService service => DependencyService.Get<IService>();

        public MyAccountViewModel()
        {   
            Title = AppResources.AppName;

            FavoritesCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(PostsPage)}" +
                                              $"?{nameof(PostsViewModel.OnlyFavorite)}=True"));

            FollowersCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(PersonsPage)}" +
                                              $"?{nameof(PersonsViewModel.OnlyFollower)}=True" +
                                              $"&{nameof(PersonsViewModel.SortOption)}={SortBy.RecentContact}" +
                                              $"&{nameof(PersonsViewModel.Title)}={AppResources.Followers}"));

            FollowingCommand = new Command(async () => 
                await Shell.Current.GoToAsync($"{nameof(PersonsPage)}" +
                                              $"?{nameof(PersonsViewModel.OnlyFollowing)}=True" +
                                              $"&{nameof(PersonsViewModel.SortOption)}={SortBy.RecentContact}" +
                                              $"&{nameof(PersonsViewModel.Title)}={AppResources.Following}"));

            AccountDetailsCommand = new Command(async () => 
                await Shell.Current.GoToAsync($"{nameof(AccountDetailsPage)}" +
                                              $"?{nameof(AccountDetailsViewModel.PersonId)}={Globals.LoggedPersonId}"));

            ChangePasswordCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(ChangePasswordPage)}"));

            LogOutCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"//{nameof(LogInPage)}"));

        }


        public async void OnAppearing()
        {
            var user = await service.GetPerson(Globals.LoggedPersonId);

            Cover = user.Cover;
            Photo = user.Photo;
            Name = user.FullName;
            Ticked = user.Ticked;
            Username = user.Username;
            MemberDate = user.MemberDate;
            FollowersCount = user.FollowerCount;
            FollowingCount = user.FollowingCount;
            PostCount = user.PostCount;
        }
    }
}

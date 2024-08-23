using SocialTemplate.Models;
using SocialTemplate.Resources;
using SocialTemplate.Services;
using SocialTemplate.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SocialTemplate.ViewModels
{
    [QueryProperty(nameof(PersonId), nameof(PersonId))]
    public class PersonDetailViewModel : BaseViewModel
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
        private bool following;
        public bool Following
        {
            get => following;
            set
            {
                SetProperty(ref following, value);
                OnPropertyChanged(nameof(FollowButtonCaption));
            }
        }

        public string FollowButtonCaption
        {
            get => Following ? AppResources.Unfollow : AppResources.Follow;
        }

        public ObservableCollection<PostTileViewModel> Posts { get; }

        public Command MessageCommand { get; }
        public Command FollowCommand { get; }

        IService service => DependencyService.Get<IService>();

        Person person;

        public PersonDetailViewModel()
        {
            Title = AppResources.AppName;

            Posts = new ObservableCollection<PostTileViewModel>();

            MessageCommand = new Command(async () => 
                await Shell.Current.GoToAsync($"{nameof(MessagingPage)}" +
                                              $"?{nameof(MessagingViewModel.PersonId)}={PersonId}"));

            FollowCommand = new Command(FollowCallback);
        }

        async void Load()
        {
            person = await service.GetPerson(PersonId);

            Cover = person.Cover;
            Photo = person.Photo;
            Name = person.FullName;
            Ticked = person.Ticked;
            Username = person.Username;
            MemberDate = person.MemberDate;
            FollowersCount = person.FollowerCount;
            FollowingCount = person.FollowingCount;
            PostCount = person.PostCount;
            Following = person.Following;

            var posts = await service.GetPosts(authorId: PersonId);

            foreach (var post in posts)
                Posts.Add(new PostTileViewModel(post));
        }

        async void FollowCallback()
        {
            if (Following == true)
            {
                person.Following = Following = false;
                FollowingCount--;
                await service.UpdatePerson(person);
            }
            else
            {
                person.Following = Following = true;
                FollowingCount++;
                await service.UpdatePerson(person);
            }
        }
    }
}

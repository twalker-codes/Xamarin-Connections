using SocialTemplate.Models;
using SocialTemplate.Resources;
using SocialTemplate.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SocialTemplate.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<PostTileViewModel> Posts { get; }

        public Command LoadCommand { get; }

        IService service = DependencyService.Get<IService>();

        public HomeViewModel()
        {
            Title = AppResources.AppName;

            Posts = new ObservableCollection<PostTileViewModel>();

            LoadCommand = new Command(async () => await LoadCallback());
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        async Task LoadCallback()
        {
            IsBusy = true;

            Posts.Clear();

            var posts = await service.GetPosts();

            foreach (var post in posts)
                Posts.Add(new PostTileViewModel(post));

            IsBusy = false;
        }
    }
}

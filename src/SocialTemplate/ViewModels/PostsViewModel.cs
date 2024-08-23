using SocialTemplate.Models;
using SocialTemplate.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SocialTemplate.ViewModels
{
    [QueryProperty(nameof(Keyword), nameof(Keyword))]
    [QueryProperty(nameof(OnlyFavorite), nameof(OnlyFavorite))]
    public class PostsViewModel : BaseViewModel
    {
        private string keyword;
        public string Keyword
        {
            get => keyword;
            set => SetProperty(ref keyword, value);
        }

        private bool onlyFavorite;
        public bool OnlyFavorite
        {
            get => onlyFavorite;
            set => SetProperty(ref onlyFavorite, value);
        }

        public ObservableCollection<PostTileViewModel> Posts { get; }

        public Command LoadCommand { get; }

        IService service => DependencyService.Get<IService>();

        public PostsViewModel()
        {
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

            var posts = await service.GetPosts(keyword: Keyword, onlyFavorite: OnlyFavorite);

            foreach (var post in posts)
                Posts.Add(new PostTileViewModel(post));

            IsBusy = false;
        }
    }
}

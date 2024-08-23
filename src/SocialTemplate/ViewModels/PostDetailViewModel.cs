using SocialTemplate.Models;
using SocialTemplate.Resources;
using SocialTemplate.Services;
using SocialTemplate.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SocialTemplate.ViewModels
{
    [QueryProperty(nameof(PostId), nameof(PostId))]
    public class PostDetailViewModel : BaseViewModel
    {
        private string postId;
        public string PostId
        {
            get => postId;
            set
            {
                SetProperty(ref postId, value);
                Load();
            }
        }

        private string authorPhoto;
        public string AuthorPhoto
        {
            get => authorPhoto;
            set => SetProperty(ref authorPhoto, value);
        }

        private string authorName;
        public string AuthorName
        {
            get => authorName;
            set => SetProperty(ref authorName, value);
        }

        private string authorUsername;
        public string AuthorUsername
        {
            get => authorUsername;
            set => SetProperty(ref authorUsername, value);
        }

        private bool authorTicked;
        public bool AuthorTicked
        {
            get => authorTicked;
            set => SetProperty(ref authorTicked, value);
        }

        private DateTime dateUtc;
        public DateTime DateUtc
        {
            get => dateUtc;
            set => SetProperty(ref dateUtc, value);
        }

        private string text;
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        private bool isFavorite;
        public bool IsFavorite
        {
            get => isFavorite;
            set => SetProperty(ref isFavorite, value);
        }

        private int favoriteCount;
        public int FavoriteCount
        {
            get => favoriteCount;
            set => SetProperty(ref favoriteCount, value);
        }

        private int commentCount;
        public int CommentCount
        {
            get => commentCount;
            set => SetProperty(ref commentCount, value);
        }

        private int viewCount;
        public int ViewCount
        {
            get => viewCount;
            set => SetProperty(ref viewCount, value);
        }

        private string[] images = { };
        public string[] Images
        {
            get => images;
            set
            {
                SetProperty(ref images, value);
                OnPropertyChanged(nameof(ShowIndicator));
            }
        }

        public bool ShowIndicator
        {
            get => Images.Count() > 1;
        }

        private string yourComment;
        public string YourComment
        {
            get => yourComment;
            set => SetProperty(ref yourComment, value);
        }

        public ObservableCollection<Comment> Comments { get; }

        public Command ImageChangedCommand { get; }
        public Command PhotoCommand { get; }
        public Command FavoriteCommand { get; }
        public Command ShareCommand { get; }
        public Command SubmitCommand { get; }

        IService service => DependencyService.Get<IService>();
        string currentImage;

        public PostDetailViewModel()
        {
            Title = AppResources.PostDetail;

            Comments = new ObservableCollection<Comment>();

            ImageChangedCommand = new Command<string>((i) => currentImage = i);

            PhotoCommand = new Command(PhotoCallback);

            FavoriteCommand = new Command(FavoriteCallback);

            ShareCommand = new Command(async () => {
                var summary = Text.Length > 32 ? Text.Substring(0, 32) + "..." : Text;
                await Shell.Current.DisplayToastAsync($"{AppResources.ShareThe} '{summary}'");
            });

            SubmitCommand = new Command(SubmitCallback);
        }

        async void Load()
        {
            var post = await service.GetPost(PostId);

            AuthorPhoto = post.AuthorPhoto;
            AuthorName = post.AuthorName;
            AuthorUsername = post.AuthorUsername;
            AuthorTicked = post.AuthorTicked;
            DateUtc = post.DateUtc;
            Text = post.Text;
            IsFavorite = post.IsFavorite;
            FavoriteCount = post.FavoriteCount;
            CommentCount = post.CommentCount;
            ViewCount = post.ViewCount;
            Images = post.Images;

            var comments = await service.GetComments(PostId);

            foreach (var comment in comments)
                Comments.Add(comment);
        }

        async void PhotoCallback()
        {
            await Shell.Current.GoToAsync($"{nameof(PhotoBrowserPage)}" +
                                          $"?{nameof(PhotoBrowserViewModel.ParamImages)}={string.Join(",", Images)}" +
                                          $"&{nameof(PhotoBrowserViewModel.Image)}={currentImage}");
        }

        async void FavoriteCallback()
        {
            if (IsFavorite)
            {
                await service.RemoveFavorite(PostId);
                FavoriteCount--;
                IsFavorite = false;
            }
            else
            {
                await service.AddFavorite(PostId);
                FavoriteCount++;
                IsFavorite = true;
            }
        }

        async void SubmitCallback()
        {
            var comment = await service.AddComment(YourComment, PostId);
            CommentCount++;
            Comments.Add(comment);
            YourComment = string.Empty;
        }

    }
}

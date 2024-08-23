using SocialTemplate.Models;
using SocialTemplate.Resources;
using SocialTemplate.Services;
using SocialTemplate.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace SocialTemplate.ViewModels
{
    public class PostTileViewModel : BaseViewModel
    {
        public string AuthorPhoto { get; }

        public string AuthorName { get; }

        public string AuthorUsername { get; }

        public bool AuthorTicked { get; }

        public DateTime DateUtc { get; }

        public string Text { get; }

        public string Image { get; }

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

        private bool isFavorite;
        public bool IsFavorite 
        {
            get => isFavorite;
            set => SetProperty(ref isFavorite, value);
        }

        public Command FavoriteCommand { get; }
        public Command ShareCommand { get; }
        public Command TapCommand { get; }

        readonly IService service = DependencyService.Get<IService>();

        private string postId;

        public PostTileViewModel(Post post)
        {
            postId = post.Id;
            AuthorPhoto = post.AuthorPhoto;
            AuthorName = post.AuthorName;
            AuthorUsername = post.AuthorUsername;
            AuthorTicked = post.AuthorTicked;
            DateUtc = post.DateUtc;
            Text = post.Text;
            Image = post.FirstImage;
            IsFavorite = post.IsFavorite;
            FavoriteCount = post.FavoriteCount;
            CommentCount = post.CommentCount;

            FavoriteCommand = new Command(FavoriteCallback);

            ShareCommand = new Command(async () => {
                var summary = Text.Length > 32 ? Text.Substring(0, 32) + "..." : Text;
                await Shell.Current.DisplayToastAsync($"{AppResources.ShareThe} '{summary}'"); 
            });

            TapCommand = new Command(TapCallback);
        }

        async void FavoriteCallback()
        {
            if (IsFavorite)
            {
                await service.RemoveFavorite(postId);
                FavoriteCount--;
                IsFavorite = false;
            }
            else
            {
                await service.AddFavorite(postId);
                FavoriteCount++;
                IsFavorite = true;
            }
        }

        async void TapCallback()
        {
            await Shell.Current.GoToAsync($"{nameof(PostDetailPage)}" +
                                          $"?{nameof(PostDetailViewModel.PostId)}={postId}");
        }
    }
}

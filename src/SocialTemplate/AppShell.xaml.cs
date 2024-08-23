using SocialTemplate.ViewModels;
using SocialTemplate.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SocialTemplate
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AccountDetailsPage), typeof(AccountDetailsPage));
            Routing.RegisterRoute(nameof(ChangePasswordPage), typeof(ChangePasswordPage));
            Routing.RegisterRoute(nameof(MessagingPage), typeof(MessagingPage));
            Routing.RegisterRoute(nameof(PersonDetailPage), typeof(PersonDetailPage));
            Routing.RegisterRoute(nameof(PersonsPage), typeof(PersonsPage));
            Routing.RegisterRoute(nameof(PostDetailPage), typeof(PostDetailPage));
            Routing.RegisterRoute(nameof(PostsPage), typeof(PostsPage));
            Routing.RegisterRoute(nameof(PhotoBrowserPage), typeof(PhotoBrowserPage));
            Routing.RegisterRoute(nameof(ResetPasswordPage), typeof(ResetPasswordPage));
        }

    }
}

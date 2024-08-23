using SocialTemplate.DataStores.MockDataStore;
using SocialTemplate.Services;
using SocialTemplate.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialTemplate
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.RegisterSingleton(new CommentDataStore());
            DependencyService.RegisterSingleton(new FavoriteDataStore());
            DependencyService.RegisterSingleton(new MessageDataStore());
            DependencyService.RegisterSingleton(new NotifyDataStore());
            DependencyService.RegisterSingleton(new PersonDataStore());
            DependencyService.RegisterSingleton(new PostDataStore());
            DependencyService.RegisterSingleton(new SearchItemDataStore());

            DependencyService.Register<IService, MockService>();
          
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

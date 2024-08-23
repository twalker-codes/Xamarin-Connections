using SocialTemplate.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialTemplate.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotifiesPage : ContentPage
    {
        NotifiesViewModel viewModel;

        public NotifiesPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new NotifiesViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            viewModel.OnAppearing();
        }
    }
}
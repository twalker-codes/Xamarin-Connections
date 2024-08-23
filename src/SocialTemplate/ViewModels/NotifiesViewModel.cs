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
    public class NotifiesViewModel : BaseViewModel
    {
        public ObservableCollection<Notify> Notifies { get; }

        public Command LoadCommand { get; }

        IService service = DependencyService.Get<IService>();

        public NotifiesViewModel()
        {
            Title = AppResources.AppName;

            Notifies = new ObservableCollection<Notify>();

            LoadCommand = new Command(async () => await LoadCallback());
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        async Task LoadCallback()
        {
            IsBusy = true;

            Notifies.Clear();

            var notifies = await service.GetNotifies();

            foreach (var notify in notifies)
                Notifies.Add(notify);

            IsBusy = false;
        }
    }
}

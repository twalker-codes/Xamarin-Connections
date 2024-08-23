using SocialTemplate.Models;
using SocialTemplate.Resources;
using SocialTemplate.Services;
using SocialTemplate.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SocialTemplate.ViewModels
{
    public class MessagesViewModel : BaseViewModel
    {
        public ObservableCollection<Person> Persons { get; }

        public Command LoadCommand { get; }
        public Command<Person> TapCommand { get; }

        IService service = DependencyService.Get<IService>();

        public MessagesViewModel()
        {
            Title = AppResources.AppName;

            Persons = new ObservableCollection<Person>();

            LoadCommand = new Command(async () => await LoadCallback());

            TapCommand = new Command<Person>(async (person) =>
                await Shell.Current.GoToAsync($"{nameof(MessagingPage)}" +
                                             $"?{nameof(MessagingViewModel.PersonId)}={person.Id}"));
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        async Task LoadCallback()
        {
            IsBusy = true;

            Persons.Clear();

            var persons = await service.GetPersons(sortBy: SortBy.RecentContact);

            foreach (var person in persons)
                Persons.Add(person);

            IsBusy = false;
        }
    }
}

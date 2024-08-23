using SocialTemplate.Models;
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
    [QueryProperty(nameof(Title), nameof(Title))]
    [QueryProperty(nameof(Name), nameof(Name))]
    [QueryProperty(nameof(OnlyFollower), nameof(OnlyFollower))]
    [QueryProperty(nameof(OnlyFollowing), nameof(OnlyFollowing))]
    [QueryProperty(nameof(SortOption), nameof(SortOption))]
    public class PersonsViewModel : BaseViewModel
    {
        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private bool onlyFollower;
        public bool OnlyFollower
        {
            get => onlyFollower;
            set => SetProperty(ref onlyFollower, value);
        }

        private bool onlyFollowing;
        public bool OnlyFollowing
        {
            get => onlyFollowing;
            set => SetProperty(ref onlyFollowing, value);
        }

        private string sortOption;
        public string SortOption
        {
            get => sortOption;
            set
            {
                sortOption = value;
                sortBy = (SortBy)Enum.Parse(typeof(SortBy), value);
            }
        }

        public ObservableCollection<Person> Persons { get; }

        public Command LoadCommand { get; }
        public Command<Person> TapCommand { get; }

        SortBy sortBy = SortBy.Unsorted;
        IService service => DependencyService.Get<IService>();

        public PersonsViewModel()
        {
            Persons = new ObservableCollection<Person>();

            LoadCommand = new Command(async () => await LoadCallback());

            TapCommand = new Command<Person>(async (person) =>
                await Shell.Current.GoToAsync($"{nameof(PersonDetailPage)}" +
                                              $"?{nameof(PersonDetailViewModel.PersonId)}={person.Id}"));
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        async Task LoadCallback()
        {
            IsBusy = true;

            Persons.Clear();

            var persons = await service.GetPersons(
                            name: string.IsNullOrEmpty(name) ? null : Name,
                            onlyFollower: OnlyFollower, 
                            onlyFollowing: OnlyFollowing, 
                            sortBy: sortBy);

            foreach (var person in persons)
                Persons.Add(person);

            IsBusy = false;

        }
    }
}

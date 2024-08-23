using SocialTemplate.Models;
using SocialTemplate.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SocialTemplate.ViewModels
{
    [QueryProperty(nameof(PersonId), nameof(PersonId))]
    public class MessagingViewModel : BaseViewModel
    {
        private string personId;
        public string PersonId
        {
            get => personId;
            set
            {
                SetProperty(ref personId, value);
                Load();
            }
        }

        private string photo;
        public string Photo
        {
            get => photo;
            set => SetProperty(ref photo, value);
        }

        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private string text;
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public ObservableCollection<MessageViewModel> Messages { get; }

        public Command SubmitCommand { get; }

        IService service => DependencyService.Get<IService>();

        public MessagingViewModel()
        {
            Messages = new ObservableCollection<MessageViewModel>();

            SubmitCommand = new Command(SubmitCallback);
        }

        async void Load()
        {
            var person = await service.GetPerson(personId);

            Photo = person.Photo;
            Name = person.FullName;

            var messages = await service.GetMessages(PersonId);

            foreach (var message in messages)
                Messages.Add(new MessageViewModel(message));
        }

        async void SubmitCallback()
        {
            Message message = await service.AddMessage(Globals.LoggedPersonId, Text);
            Messages.Add(new MessageViewModel(message));
            Text = string.Empty;
        }

    }
}

using SocialTemplate.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SocialTemplate.ViewModels
{
    public class MessageViewModel : BaseViewModel
    {
        private bool isSent;
        public bool IsSent
        {
            get => isSent;
        }

        private bool isReceived;
        public bool IsReceived
        {
            get => isReceived;
        }

        private string text;
        public string Text
        {
            get => text;
        }

        public Color BgColor
        {
            get
            {
                switch (AppInfo.RequestedTheme)
                {
                    case AppTheme.Light:
                        return IsSent ? (Color)App.Current.Resources["PrimaryColorLight"]
                            : (Color)App.Current.Resources["CardColorLight"];
                    default:
                        return IsSent ? (Color)App.Current.Resources["PrimaryColorDark"]
                            : (Color)App.Current.Resources["CardColorDark"];
                }
            }
        }

        public Color TextColor
        {
            get
            {
                switch (AppInfo.RequestedTheme)
                {
                    case AppTheme.Light:
                        return IsSent ? (Color)App.Current.Resources["TextColorOnPrimaryLight"]
                            : (Color)App.Current.Resources["SecondaryTextColorLight"];
                    default:
                        return IsSent ? (Color)App.Current.Resources["TextColorOnPrimaryDark"]
                            : (Color)App.Current.Resources["SecondaryTextColorDark"];
                }
            }
        }

        public MessageViewModel(Message message)
        {
            isSent = message.SenderId == Globals.LoggedPersonId;
            isReceived = message.ReceiverId == Globals.LoggedPersonId;
            text = message.Text;
        }

    }
}

using System;
using BeaverChat.Helpers;
using MvvmHelpers;

namespace BeaverChat.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public string UserName
        {
            get => Settings.UserName;
            set
            {
                if (value == UserName)
                    return;
                Settings.UserName = value;
                OnPropertyChanged();
            }
        }
    }
}

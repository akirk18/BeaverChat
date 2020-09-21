using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BeaverChat.Helpers;
using Xamarin.Forms;

namespace BeaverChat.ViewModels
{
    public class LobbyViewModel : ViewModelBase
    {
        public List<string> Rooms { get; }

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

        public LobbyViewModel()
        {
            Rooms = ChatService.GetRooms();
        }

        public async Task GoToGroupChat(INavigation navigation, string group)
        {
            if (string.IsNullOrWhiteSpace(group))
                return;

            if (string.IsNullOrWhiteSpace(UserName))
                return;

            Settings.Group = group;

            // TODO add new ChatNaviagtionPage(new GroupChatPage())
            await navigation.PushModalAsync();
        }


    }
}

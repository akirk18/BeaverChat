using System;
using System.Collections.Generic;
using BeaverChat.ViewModels;
using Xamarin.Forms;

namespace BeaverChat.Views
{
    public partial class MainPage : ContentPage
    {
        LobbyViewModel vm;
        LobbyViewModel VM => vm ?? (vm = (LobbyViewModel)BindingContext);

        public MainPage()
        {
            InitializeComponent();
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await VM.GoToGroupChat(Navigation, e.SelectedItem as string);
            ((ListView)sender).SelectedItem = null;
        }
    }
}

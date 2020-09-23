using System;
using System.Collections.Generic;
using BeaverChat.ViewModels;
using Xamarin.Forms;

namespace BeaverChat.Views
{
    public partial class GroupChatPage : ContentPage
    {
        ChatViewModel vm;
        ChatViewModel VM => vm ?? (vm = (ChatViewModel)BindingContext);

        public GroupChatPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (!DesignMode.IsDesignModeEnabled)
                VM.ConnectCommand.Execute(null);

            ToolbarDone.Clicked += ToolbarDone_Clicked;
        }

        private async void ToolbarDone_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            if (!DesignMode.IsDesignModeEnabled)
                VM.DisconnectCommand.Execute(null);

            ToolbarDone.Clicked -= ToolbarDone_Clicked;
        }
    }
}

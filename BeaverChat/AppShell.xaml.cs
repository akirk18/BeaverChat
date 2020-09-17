using System;
using System.Collections.Generic;
using BeaverChat.ViewModels;
using BeaverChat.Views;
using Xamarin.Forms;

namespace BeaverChat
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

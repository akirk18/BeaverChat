using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BeaverChat.Services;
using BeaverChat.Core;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Distribute;

namespace BeaverChat
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<ChatService>();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {

            AppCenter.Start("android={Your Android Secret here};" +
                "ios={Your iOS App Secret here}",
                typeof(Analytics), typeof(Crashes), typeof(Distribute));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

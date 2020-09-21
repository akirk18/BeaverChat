using System;
using System.Threading.Tasks;
using BeaverChat.Interfaces;
using Xamarin.Forms;

namespace BeaverChat.Services
{
    public class DialogServices : IDialogService
    {
        public Task<bool> DisplayAlert(string title, string message, string accept, string cancel)
        {
            var page = Application.Current.MainPage;
            if (page == null)
                return Task.FromResult(false);

            return page.DisplayAlert(title, message, accept, cancel);
        }

        public Task DisplayAlert(string title, string message, string cancel)
        {
            var page = Application.Current.MainPage;
            if (page == null)
                return Task.CompletedTask;

            return page.DisplayAlert(title, message, cancel);
        }
    }
}

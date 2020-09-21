using System;
using BeaverChat.Core;
using BeaverChat.Interfaces;
using MvvmHelpers;
using Xamarin.Forms;

namespace BeaverChat.ViewModels
{
    public class ViewModelBase : BaseViewModel
    {
        ChatService chatService;
        public ChatService ChatService => chatService ?? (chatService = DependencyService.Resolve<ChatService>());

        IDialogService dialogService;
        public IDialogService DialogService => dialogService ?? (dialogService = DependencyService.Resolve<IDialogService>());
    }
}

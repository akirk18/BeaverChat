using System.ComponentModel;
using Xamarin.Forms;
using BeaverChat.ViewModels;

namespace BeaverChat.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
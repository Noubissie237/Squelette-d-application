using Squelette.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Squelette.Views
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
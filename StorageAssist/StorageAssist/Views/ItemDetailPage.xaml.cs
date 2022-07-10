using StorageAssist.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StorageAssist.Views
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
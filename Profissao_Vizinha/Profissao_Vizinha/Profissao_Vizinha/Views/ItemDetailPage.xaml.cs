using Profissao_Vizinha.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Profissao_Vizinha.Views
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
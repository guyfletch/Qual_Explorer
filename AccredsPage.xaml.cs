using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Qual_Explorer
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccredsPage : ContentPage
    {
        public AccredsPage(List<Method> accreds)
        {
            InitializeComponent();
            BindingContext = accreds;
        }

        async void AccredsList_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return;
            await Navigation.PushAsync(new AccredItem((Method)e.Item));
            ((ListView)sender).SelectedItem = null;
        }
    }
}

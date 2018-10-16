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
    public partial class TechniquesPage : ContentPage
    {
        public TechniquesPage(List<Area> techniques)
        {
            InitializeComponent();
            BindingContext = techniques;
        }

        async void TechniquesList_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return;
            var item = (Area)e.Item;
            if (item.AreaName == "Search")
            {
                await Navigation.PushAsync(new SearchItem(false));
            }
            else
            {
                await Navigation.PushAsync(new AreaItem(item));
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}

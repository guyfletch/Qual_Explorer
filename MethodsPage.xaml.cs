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
    public partial class MethodsPage : ContentPage
    {
        public MethodsPage(List<Area> areas)
        {
            InitializeComponent();
            BindingContext = areas;
            Areas = areas;
            AreaList.ItemTemplate = new DataTemplate(typeof(AreaCell));
        }

        public List<Area> Areas { get; set; }

        async void AreaList_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return;
            var item = (Area)e.Item;
            if (item.AreaName == "Search")
            {
                await Navigation.PushAsync(new SearchItem());
            }
            else
            {
                await Navigation.PushAsync(new AreaItem(item));
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}

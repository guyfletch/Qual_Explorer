using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QualDeploy
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MethodsPage : ContentPage
	{
	    public MethodsPage(List<Area> areas)
	    {
	        InitializeComponent();
	        BindingContext = areas;
	        Areas = areas;
	        //AreaList.ItemTemplate = new DataTemplate(typeof(AreaCell));
	    }

	    public List<Area> Areas { get; set; }
	    async void Methods_OnClicked(object sender, EventArgs e)
	    {
	        
	    }

	    async void Techniques_OnClicked(object sender, EventArgs e)
	    {
	        
	    }

	    async void Accreds_OnClicked(object sender, EventArgs e)
	    {
	        
	    }
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
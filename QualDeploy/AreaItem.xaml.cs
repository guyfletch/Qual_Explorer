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
	public partial class AreaItem : ContentPage
	{
	    public AreaItem(Area area, bool technique = false)
	    {
	        InitializeComponent();
	        Title = area.AreaName;
	        BindingContext = area.Methods;
	        Technique = technique;
	        MethodsList.ItemTemplate = new DataTemplate(typeof(MethodCell));
	    }

	    public bool Technique { get; set; }

	    async void MethodsList_OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
	        if (e == null) return;
	        if (!Technique)
	        {
	            await Navigation.PushAsync(new MethodItem((Method)e.Item));
	        }
	        else
	        {
	            await Navigation.PushAsync(new TechniqueItem((Method)e.Item));
	        }
	        ((ListView)sender).SelectedItem = null;
	    }
    }
}
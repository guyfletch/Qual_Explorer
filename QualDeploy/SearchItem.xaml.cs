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
	public partial class SearchItem : ContentPage
	{
	    public SearchItem(bool isMethod = true)
	    {
	        InitializeComponent();
	        Methods = new List<Method>();
	        AreasContext = DataStore.Instance.Methods;
	        Title = isMethod ? "Show methods tagged:" : "Show techniques tagged:";
	        var filters = new List<string>();
	        foreach (var area in AreasContext)
	        {
	            foreach (var m in area.Methods)
	            {
	                filters.AddRange(m.Filters);
	                Methods.Add(m);
	            }
	        }

	        filters = filters.Distinct().ToList();
	        BindingContext = filters;
	    }

	    public List<Area> AreasContext { get; set; }
	    public List<Method> Methods { get; set; }

	    async void SearchList_OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
	        var methods = Methods.Where(x => x.Filters.Contains(e.Item)).ToList();
	        var area = new Area("") { AreaName = e.Item.ToString(), Methods = methods };
	        await Navigation.PushAsync(new AreaItem(area));
	        ((ListView)sender).SelectedItem = null;
	    }
    }
}
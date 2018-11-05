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
	public partial class QualPage : ContentPage
	{
		public QualPage (DataStore store)
		{
			InitializeComponent ();
		    Store = store;
		}
	    public DataStore Store { get; set; }
	    async void Methods_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new MethodsPage(Store.Methods));
	    }

	    async void Techniques_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new TechniquesPage(Store.Techniques));
	    }

	    async void Accreds_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new AccredsPage(Store.Accreds));
	    }
    }
}
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
	public partial class TechniqueItem : ContentPage
	{
		public TechniqueItem (Method m)
		{
		    InitializeComponent();
		    BindingContext = m;
		}
	}
}
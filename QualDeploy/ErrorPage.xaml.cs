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
	public partial class ErrorPage : ContentPage
	{
		public ErrorPage (Exception ex)
		{
			InitializeComponent ();
		    Exception = ex;
		}
        public Exception Exception { get; }
	}
}
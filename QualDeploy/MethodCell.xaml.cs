using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QualDeploy
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MethodCell : ViewCell
	{
	    public Image MethodImage { get; set; }
		public MethodCell (string imgpath)
		{
			InitializeComponent ();
		    var embeddedImage = new Image { Aspect = Aspect.AspectFit };

		    // resource identifiers start with assembly-name DOT filename
		    embeddedImage.Source = ImageSource.FromResource(imgpath, typeof(MethodCell).GetTypeInfo().Assembly);

		    MethodImage = embeddedImage;
		}
	}
}
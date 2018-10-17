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
    public partial class MethodItem : ContentPage
    {
        public MethodItem(Method m)
        {
            InitializeComponent();
            BindingContext = m;
        }
    }
}
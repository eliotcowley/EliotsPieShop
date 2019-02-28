using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EliotsPieShop
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ModalPageView : ContentPage
	{
		public ModalPageView ()
		{
			InitializeComponent ();
		}

        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new LargeImagePageView());
        }
    }
}
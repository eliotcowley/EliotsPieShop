using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EliotsPieShop
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DemoButton_Clicked(object sender, EventArgs e)
        {
            DemoButton.Text = "I was clicked";
        }
    }
}

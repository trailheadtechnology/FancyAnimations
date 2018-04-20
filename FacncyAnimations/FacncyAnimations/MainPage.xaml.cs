using System;
using Xamarin.Forms;

namespace FacncyAnimations
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OpenShakePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShakePage()); 
        }

        async void OpenRotatePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RotatePage());
        }

        async void OpenLayoutPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LayoutPage());
        }
    }
}

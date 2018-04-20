using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FacncyAnimations
{
    public partial class LayoutPage : ContentPage
    {
        bool _collapsed;
        public LayoutPage()
        {
            InitializeComponent();
        }

        async void Rotate_Clicked(object sender, EventArgs e)
        {
            if (_collapsed)
            {
                await Task.WhenAll(new List<Task> {MyContent.LayoutTo(new Rectangle(MyContent.Bounds.X, MyContent.Bounds.Y, MyContent.Bounds.Width, 300), 500, Easing.CubicOut), MyButton.RotateTo(180, 500, Easing.SpringOut)});
                _collapsed = false;
            }
            else
            {               
                await Task.WhenAll(new List<Task>{MyContent.LayoutTo(new Rectangle(MyContent.Bounds.X, MyContent.Bounds.Y, MyContent.Bounds.Width, 0), 500, Easing.CubicIn),MyButton.RotateTo(360, 500, Easing.SpringOut)});
                MyButton.Rotation = 0;
                 _collapsed = true;
            }
        }
    }
}

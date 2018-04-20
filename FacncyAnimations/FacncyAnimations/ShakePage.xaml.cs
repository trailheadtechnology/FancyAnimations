using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FacncyAnimations
{
    public partial class ShakePage : ContentPage
    {
        public ShakePage()
        {
            InitializeComponent();
        }

        async void ShakeClicked(object sender, EventArgs e)
        {
            uint timeout = 50;
            await MyEntry.TranslateTo(-15, 0, timeout);
            await MyEntry.TranslateTo(15, 0, timeout);
            await MyEntry.TranslateTo(-10, 0, timeout);
            await MyEntry.TranslateTo(10, 0, timeout);
            await MyEntry.TranslateTo(-5, 0, timeout);
            await MyEntry.TranslateTo(5, 0, timeout);
            MyEntry.TranslationX = 0;
        }
    }
}

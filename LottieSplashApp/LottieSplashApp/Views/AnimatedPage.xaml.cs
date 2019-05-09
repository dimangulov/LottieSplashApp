using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LottieSplashApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimatedPage : ContentPage
    {
        public AnimatedPage()
        {
            InitializeComponent();
        }

        private void Handle_OnFinish(object sender, EventArgs e)
        {
            
        }

        private void AnimationView_OnOnFinish(object sender, EventArgs e)
        {
            DisplayAlert("info","IsFinished", "ok");
        }
    }
}
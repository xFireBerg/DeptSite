using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfraPage : ContentPage
    {
        public InfraPage()
        {
            InitializeComponent();
        }

        async void OnB1Clicked(object sender, EventArgs e)
        {
            Image image = new Image();
            image.Source = "class_b1.jpg";
            await Navigation.PushAsync(new ContentPage {Content = image});
        }
        async void OnB2Clicked(object sender, EventArgs e)
        {
            Image image = new Image();
            image.Source = "class_b2.jpg";
            await Navigation.PushAsync(new ContentPage { Content = image });
        }
        async void OnB3Clicked(object sender, EventArgs e)
        {
            Image image = new Image();
            image.Source = "class_b3.jpg";
            await Navigation.PushAsync(new ContentPage { Content = image });
        }
        async void OnB4Clicked(object sender, EventArgs e)
        {
            Image image = new Image();
            image.Source = "class_b4.jpg";
            await Navigation.PushAsync(new ContentPage { Content = image });
        }
        async void OnB5Clicked(object sender, EventArgs e)
        {
            Image image = new Image();
            image.Source = "class_b5.jpg";
            await Navigation.PushAsync(new ContentPage { Content = image });
        }
        async void OnB6Clicked(object sender, EventArgs e)
        {
            Image image = new Image();
            image.Source = "class_b6.jpg";
            await Navigation.PushAsync(new ContentPage { Content = image });
        }
        async void OnB7Clicked(object sender, EventArgs e)
        {
            Image image = new Image();
            image.Source = "class_b7.jpg";
            await Navigation.PushAsync(new ContentPage { Content = image });
        }


    }
}
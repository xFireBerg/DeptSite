using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Assignment2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();

        }

        async private void OnSignUpClicked(object sender, EventArgs e)
        {
            if (email.Text != null && password.Text != null && name.Text != null)
            {
                Preferences.Set("email", email.Text);
                Preferences.Set("password", password.Text);
                Preferences.Set("name", name.Text);
                await DisplayAlert("Sign Up", "Sign Up Successful!", "Continue to Log In");
                await Navigation.PopAsync();
                await Navigation.PushAsync(new LoginPage());
            }
            else
                await DisplayAlert("Sign Up", "Please enter all fields", "OK");


        }
    }
}
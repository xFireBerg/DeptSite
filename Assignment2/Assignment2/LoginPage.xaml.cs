using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment2.SignUpPage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
namespace Assignment2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        async private void OnClickSignIn(object sender, EventArgs e)
        {
            //if signin successful go to main page...which could be about page
            try
            {
                if (Preferences.ContainsKey("email") && Preferences.Get("email", "") == emailEntered.Text && Preferences.ContainsKey("password") && Preferences.Get("password", "") == passwordEntered.Text) 
                //if (emailEntered.Text == Preferences.Get(emailEntered.Text, "") && passwordEntered.Text == Preferences.Get(passwordEntered.Text, ""))
                {

                    if (await DisplayAlert("Login Process", "Username and password match", "Continue", "Cancel"))
                        await Navigation.PushAsync(new MainPage());
                }
                else 
                    await DisplayAlert("Login Process", "Please make sure you have entered the right credentials.", "OK");
            }
            catch
            {
                await DisplayAlert("Login Process", "Please fill in E-mail and Password fields", "OK");
            }

                
        }
        async private void OnClickSignUp(object sender, EventArgs e)
        {
            //redirect to a new signup page
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}
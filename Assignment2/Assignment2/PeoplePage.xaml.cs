using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeoplePage : ContentPage
    {
        public PeoplePage()
        {
            InitializeComponent();
        }

        async private void OnClickedCall(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.StyleId == "1") { 
                try
                {
                    if (await this.DisplayAlert(
                        "Dial",
                        "Would you like to call Ahmet Arslan?",
                        "Yes",
                        "No")) {
                        PhoneDialer.Open(_1.Text);
                    }
                }
                catch
                {
                    await this.DisplayAlert(
                        "Error", "Call not supported on this device", "OK");
                }
            }

            if (button.StyleId == "2")
            {
                try
                {
                    if (await this.DisplayAlert(
                        "Dial",
                        "Would you like to call Yasar Hoscan?",
                        "Yes",
                        "No"))
                    {
                        PhoneDialer.Open(_2.Text);
                    }
                }
                catch
                {
                    await this.DisplayAlert(
                        "Error", "Call not supported on this device", "OK");
                }
            }

            if (button.StyleId == "3")
            {
                try
                {
                    if (await this.DisplayAlert(
                        "Dial",
                        "Would you like to call Serkan Gunal?",
                        "Yes",
                        "No"))
                    {
                        PhoneDialer.Open(_3.Text);
                    }
                }
                catch
                {
                    await this.DisplayAlert(
                        "Error", "Call not supported on this device", "OK");
                }
            }

            if (button.StyleId == "4")
            {
                try
                {
                    if (await this.DisplayAlert(
                        "Dial",
                        "Would you like to call Cihan Kaleli?",
                        "Yes",
                        "No"))
                    {
                        PhoneDialer.Open(_4.Text);
                    }
                }
                catch
                {
                    await this.DisplayAlert(
                        "Error", "Call not supported on this device", "OK");
                }
            }

            if (button.StyleId == "5")
            {
                try
                {
                    if (await this.DisplayAlert(
                        "Dial",
                        "Would you like to call Alper Kursat",
                        "Yes",
                        "No"))
                    {
                        PhoneDialer.Open(_5.Text);
                    }
                }
                catch
                {
                    await this.DisplayAlert(
                        "Error", "Call not supported on this device", "OK");
                }
            }

            if (button.StyleId == "6") {
                try
                {
                    if (await this.DisplayAlert(
                        "Dial",
                        "Would you like to call Alper Bilge?",
                        "Yes",
                        "No"))
                    {
                        PhoneDialer.Open(_6.Text);
                    }
                }
                catch
                {
                    await this.DisplayAlert(
                        "Error", "Call not supported on this device", "OK");
                }
            }

            if (button.StyleId == "7")
            {
                try
                {
                    if (await this.DisplayAlert(
                        "Dial",
                        "Would you like to call Sevcan Yilmaz?",
                        "Yes",
                        "No"))
                    {
                        PhoneDialer.Open(_7.Text);
                    }
                }
                catch
                {
                    await this.DisplayAlert(
                        "Error", "Call not supported on this device", "OK");
                }
            }

            if (button.StyleId == "8")
            {
                try
                {
                    if (await this.DisplayAlert(
                        "Dial",
                        "Would you like to call Burcu Yurekli?",
                        "Yes",
                        "No"))
                    {
                        PhoneDialer.Open(_8.Text);
                    }
                }
                catch
                {
                    await this.DisplayAlert(
                        "Error", "Call not supported on this device", "OK");
                }
            }

            if (button.StyleId == "9")
            {
                try
                {
                    if (await this.DisplayAlert(
                        "Dial",
                        "Would you like to call Cahit Perkgoz?",
                        "Yes",
                        "No"))
                    {
                        PhoneDialer.Open(_9.Text);
                    }
                }
                catch
                {
                    await this.DisplayAlert(
                        "Error", "Call not supported on this device", "OK");
                }
            }

            if (button.StyleId == "10")
            {
                try
                {
                    if (await this.DisplayAlert(
                        "Dial",
                        "Would you like to call Mehmet Kilicarslan?",
                        "Yes",
                        "No"))
                    {
                        PhoneDialer.Open(_10.Text);
                    }
                }
                catch
                {
                    await this.DisplayAlert(
                        "Error", "Call not supported on this device", "OK");
                }
            }

            if (button.StyleId == "11")
            {
                try
                {
                    if (await this.DisplayAlert(
                        "Dial",
                        "Would you like to call Ozgur Ozsen?",
                        "Yes",
                        "No"))
                    {
                        PhoneDialer.Open(_11.Text);
                    }
                }
                catch
                {
                    await this.DisplayAlert(
                        "Error", "Call not supported on this device", "OK");
                }
            }

            if (button.StyleId == "12")
            {
                try
                {
                    if (await this.DisplayAlert(
                        "Dial",
                        "Would you like to call Emre Kacmaz?",
                        "Yes",
                        "No"))
                    {
                        PhoneDialer.Open(_12.Text);
                    }
                }
                catch
                {
                    await this.DisplayAlert(
                        "Error", "Call not supported on this device", "OK");
                }
            }
        }
    }
}
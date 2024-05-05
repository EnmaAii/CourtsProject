//using CourtsProject.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace CourtsProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage() //Главная страница
        {
            InitializeComponent();
        }

        private void LogoutBtn_Clicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () => {
                var result = await DisplayAlert("Logout?", "You will be logged out of your account", "Confirm", "Cancel");

                if (result)
                    await Shell.Current.GoToAsync(state: "//login");
                else
                {
                    await Shell.Current.GoToAsync(state: "//main");
                }
            });
        }

    }
}

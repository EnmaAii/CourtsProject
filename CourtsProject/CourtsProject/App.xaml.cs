//using CourtsProject.Resources;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using CourtsProject.Views;




namespace CourtsProject
{
    public partial class App : Application
    {

        public App()
        {

            InitializeComponent();
            MainPage = new AppShell();
            /* MainPage = new AppShell();

             // MainPage = new NavigationPage(new tab());
             //NavigationPage.SetHasNavigationBar(this, false);

             MainPage = new NavigationPage(new tab());*/
            //MainPage = new NavigationPage(new tab());

        }





        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

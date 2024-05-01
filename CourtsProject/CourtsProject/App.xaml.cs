using CourtsProject.Resources;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace CourtsProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new tab());
            //NavigationPage.SetHasNavigationBar(this, false);
        }

        private static BD bd;
        public static BD Bd
        {
            get
            {
                if (bd == null)
                    bd = new BD(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "bd.sqlite3"));
                return bd;
            }
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

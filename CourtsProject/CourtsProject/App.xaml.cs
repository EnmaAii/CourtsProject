﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

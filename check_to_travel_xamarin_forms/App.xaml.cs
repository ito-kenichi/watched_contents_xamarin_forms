﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace check_to_travel_xamarin_forms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            this.MainPage = new NavigationPage(new MainPage());
        }
    }
}

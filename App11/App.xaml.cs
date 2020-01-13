using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Reflection.Emit;
using System.Linq;
using System.ComponentModel;
using Xamarin.Forms.Xaml;
using App11.Services;
using App11.Views;

namespace App11
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Reflection.Emit;
using System.Linq;
using System.ComponentModel;
using Xamarin.Forms.Xaml;
using App11.Views;
using App11.Models;

namespace App11
{
    [DesignTimeVisible(false)]
    class SplashPage : ContentPage
    {
        Image image;
        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            image = new Image()
            {
                Source = "test3.jpg",
                WidthRequest = 430,
                HeightRequest = 570
            };
            AbsoluteLayout.SetLayoutFlags(image, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(image, new Rectangle(0.5, 1.2, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(image);
            this.BackgroundColor = Color.FromHex("EEEED6");
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await image.ScaleTo(1, 1300);
            await image.ScaleTo(0.9, 1000, Easing.Linear);
            await image.ScaleTo(150, 900, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }


    }
}
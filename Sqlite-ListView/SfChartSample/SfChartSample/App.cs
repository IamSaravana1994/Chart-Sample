using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SfChartSample
{
    public class App : Application
    {
        public App()
        {
            new Database();
            MainPage = new NavigationPage(new SamplePage()) { StyleId = "NavigationPageID" };
            //MainPage = new AxisCustomization();
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

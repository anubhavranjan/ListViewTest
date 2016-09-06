using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ListViewTest
{
    public class App : Application
    {
        private static MainViewModel _viewModel;

        public static MainViewModel ViewModel
        {
            get
            {
                if(_viewModel == null)
                    _viewModel = new MainViewModel();
                return _viewModel;
            }            
        }
        public App()
        {
            // The root page of your application
            MainPage = new DataPage();
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

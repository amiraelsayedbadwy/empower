
using Empower.Page;
using Empower.ViewModel;
using FreshMvvm;
using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
using Application = Xamarin.Forms.Application;

namespace Empower
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = FreshPageModelResolver.ResolvePageModel<LoginPageModel>();
            // MainPage = new HomePage();
    
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

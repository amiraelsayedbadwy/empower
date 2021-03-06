﻿using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace Empower.ViewModel
{
   public class LoginPageModel:FreshMvvm.FreshBasePageModel
    {
        public ICommand LoginCommand { get; set; }
        public LoginPageModel()
        {
            LoginCommand = new Command(LoginCommandExcute);
        }

        private   void LoginCommandExcute(object obj)
        {
            loadTabbedPage();
        }
        public void loadTabbedPage()
        {
            var tabbedNavigation = new FreshTabbedNavigationContainer();
            tabbedNavigation.On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            tabbedNavigation.BackgroundColor = Color.White;
            tabbedNavigation.AddTab<HomePageModel>("Home", "home.png");
            tabbedNavigation.AddTab<ProjectPageModel>("Projects", "projects.png");
            tabbedNavigation.AddTab<NewsPageModel>("News", "news.png");
            tabbedNavigation.AddTab<ContactPageModel>("Contact", "contactimage.png");
          App.Current. MainPage = tabbedNavigation;
        }
    }
}

using Animal_1.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Animal_1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void MenuItem_Clicked(object sender, System.EventArgs e)
        {
            FlyoutIsPresented = false;
            DisplayAlert("Menu", "You clicked a menu item!", "OK");
        }

        Dictionary<string, Type> routes = new Dictionary<string, Type>();

        private void RegisterRoutes()
        {
            routes.Add("gorilladetails", typeof(GorillaDetails));
            routes.Add("gorillastats", typeof(GorillaStats));

            foreach (var route in routes)
            {
                Routing.RegisterRoute(route.Key, route.Value);
            }
        }

    }
}

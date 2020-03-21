using Flyouts.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Flyouts
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
		}

		private void MenuItem_Clicked(object sender, EventArgs e)
		{
			FlyoutIsPresented = false;
			DisplayAlert("Menu", "You clicked on a menu item", "OK");
		}

		Dictionary<string, Type> routes = new Dictionary<string, Type>();

		private void RegisterRoutes()
		{
			routes.Add("gorilladetails", typeof(GorillaDetails));

			foreach (var route in routes)
			{
				Routing.RegisterRoute(route.Key, route.Value);
			}
		}




	}
}

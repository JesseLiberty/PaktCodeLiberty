using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Animal_1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Gorilla : ContentPage
	{
		public Gorilla()
		{
			InitializeComponent();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("gorilladetails");
		}
	}
}
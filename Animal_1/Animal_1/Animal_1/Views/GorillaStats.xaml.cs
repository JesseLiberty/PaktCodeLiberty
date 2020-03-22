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
	[QueryProperty("GorillaName", "gorillaname")]
	public partial class GorillaStats : ContentPage
	{
		public GorillaStats()
		{
			InitializeComponent();
			BindingContext = this;
		}

		private string _gorillaName;
		public string GorillaName
		{
			set
			{
				_gorillaName = Uri.UnescapeDataString(value);
				OnPropertyChanged("GorillaName");
			}
			get { return _gorillaName; }
		}
	}
}
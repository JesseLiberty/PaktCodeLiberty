using Animal_1.Data;
using Animal_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Animal_1.Services
{
	public class MonkeySearchHandler : SearchHandler
	{
		protected override void OnQueryChanged(string oldValue, string newValue)
		{
			base.OnQueryChanged(oldValue, newValue);

			if (string.IsNullOrEmpty(newValue))
			{
				ItemsSource = null;
			}
			else
			{
				ItemsSource = MonkeyData.Monkeys
					.Where(m => m.Name.ToLower().Contains(newValue.ToLower()))
					.ToList<Animal>();
			}
		}

		protected override async void OnItemSelected(object item)
		{
			base.OnItemSelected(item);
		}
	}
}

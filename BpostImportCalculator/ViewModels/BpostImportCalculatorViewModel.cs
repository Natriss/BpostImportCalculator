using BpostImportCalculator.Core.Models;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Threading.Tasks;

namespace BpostImportCalculator.ViewModels
{
	public class BpostImportCalculatorViewModel : BaseViewModel
	{
		private Package _package { get; set; }

		private readonly string[] _typeItemSource = { "Commercial", "Gift" };
		public string[] TypeItemSource
		{
			get { return _typeItemSource; }
		}

		private string _selectedItem = "Commercial";
		public string SelectedItem
		{
			get { return _selectedItem; }
			set { _selectedItem = value; OnPropertyChanged(nameof(SelectedItem)); }
		}

		public double Price
		{
			get { return _package.Price; }
			set { _package.Price = value; OnPropertyChanged(nameof(Price)); }
		}

		public double Shipping
		{
			get { return _package.Shipping; }
			set
			{
				try
				{
					_package.Shipping = value;
				}
				catch (Exception e)
				{
					_ = ShowErrorAsync(e.Message);
				}
				finally
				{
					OnPropertyChanged(nameof(Shipping));
				}
			}
		}

		private static async Task ShowErrorAsync(string message)
		{
			ContentDialog contentDialog = new()
			{
				Title = "Error",
				Content = message,
				CloseButtonText = "Okay",
			};
			_ = await contentDialog.ShowAsync();
		}

		public BpostImportCalculatorViewModel()
		{
			_package = new()
			{
				Price = 0,
				Shipping = 0
			};
		}
	}
}

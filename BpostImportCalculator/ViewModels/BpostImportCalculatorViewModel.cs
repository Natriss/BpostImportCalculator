using BpostImportCalculator.Core.Models;
using BpostImportCalculator.Services;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Windows.Input;

namespace BpostImportCalculator.ViewModels
{
	public class BpostImportCalculatorViewModel : BaseViewModel
	{
		private Package _package { get; set; }

		public string[] TypeItemSource { get; } = { "Commercial", "Gift" };

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
					ShowErrorMessage(e);
				}
				OnPropertyChanged(nameof(Shipping));
			}
		}

		public BpostImportCalculatorViewModel()
		{
			_package = new()
			{
				Price = 0,
				Shipping = 0
			};
		}

		private static async void ShowErrorMessage(Exception e)
		{
			await App.MainRoot.ShowMessageDialogAsync("Error", e.Message, "Okay");
		}
	}
}

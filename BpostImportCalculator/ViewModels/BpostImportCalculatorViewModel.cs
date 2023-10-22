using BpostImportCalculator.Core.Models;
using BpostImportCalculator.Services;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Threading.Tasks;

namespace BpostImportCalculator.ViewModels
{
	public class BpostImportCalculatorViewModel : BaseViewModel
	{
		private Package _package { get; set; }
		private DialogService _dialogService;

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
					_ = _dialogService.ShowErrorAsync(e.Message);
				}
				finally
				{
					OnPropertyChanged(nameof(Shipping));
				}
			}
		}

		public BpostImportCalculatorViewModel()
		{
			_dialogService = new DialogService();
			_package = new()
			{
				Price = 0,
				Shipping = 0
			};
		}
	}
}

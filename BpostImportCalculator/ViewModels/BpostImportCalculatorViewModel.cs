using BpostImportCalculator.Core.Models;
using BpostImportCalculator.Helpers;

namespace BpostImportCalculator.ViewModels
{
	public class BpostImportCalculatorViewModel : BaseViewModel
	{
		private Package Package { get; set; }

		public string TypeHeader { get; } = "TypeHeader".GetLocalized();
		public string[] TypeItemSource { get; } = { "Commercial".GetLocalized(), "Gift".GetLocalized() };

		private string _selectedItem = "Commercial".GetLocalized();
		public string SelectedItem
		{
			get { return _selectedItem; }
			set
			{
				if (_selectedItem == value) 
				{
					return;
				}
				_selectedItem = value;			
				OnPropertyChanged(nameof(SelectedItem));
				CalculateTotal();
			}
		}

		public string PriceText { get; } = "Price".GetLocalized();
		public double Price
		{
			get { return Package.Price; }
			set { Package.Price = value; OnPropertyChanged(nameof(Price)); CalculateTotal(); }
		}

		public string ShippingText { get; } = "Shipping".GetLocalized();
		public double Shipping
		{
			get { return Package.Shipping; }
			set { Package.Shipping = value; OnPropertyChanged(nameof(Shipping)); CalculateTotal(); }
		}

		public string CustomsFeeText { get; } = "CustomsFee".GetLocalized();
		private string _customsFee = "00,00";
		public string CustomsFee
		{
			get { return _customsFee; }
			set { _customsFee = value; OnPropertyChanged(nameof(CustomsFee)); }
		}

		public string VATText { get; } = "VAT".GetLocalized();
		private string _vat = "00,00";
		public string VAT
		{
			get { return _vat; }
			set { _vat = value; OnPropertyChanged(nameof(VAT)); }
		}

		public string TotalText { get; } = "Total".GetLocalized();
		private string _total = "00,00";
		public string Total
		{
			get { return _total; }
			set { _total = value; OnPropertyChanged(nameof(Total)); }
		}

		public BpostImportCalculatorViewModel()
		{
			Package = new()
			{
				Price = 0,
				Shipping = 0
			};
		}

		private void CalculateTotal()
		{
			CalculateCustomsFee();
			CalculateVAT();
			Total = $"{Package.Price + Package.Shipping + double.Parse(VAT) + double.Parse(VAT)}";
		}

		private void CalculateCustomsFee()
		{
			if (SelectedItem == TypeItemSource[0])
			{
				CustomsFee = (Package.Price + Package.Shipping) switch
				{
					>= 150 => $"32,00",
					_ => $"15,00",
				};
			}
			if (SelectedItem == TypeItemSource[1])
			{
				CustomsFee = (Package.Price + Package.Shipping) switch
				{
					>= 150 => $"32,00",
					>= 45 => $"15,00",
					_ => $"00,00",
				};
			}
		}

		private void CalculateVAT()
		{
			VAT = $"{((Package.Price + Package.Shipping) + double.Parse(CustomsFee)) * 21 / 100}";
		}
	}
}

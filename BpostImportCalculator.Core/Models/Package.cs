using BpostImportCalculator.Core.Exceptions;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BpostImportCalculator.Core.Models
{
	public class Package : ObservableObject
	{
		private double _price;
		public double Price
		{
			get { return _price; }
			set
			{
				if (value < 0)
				{
					throw new PackageException("The price can't be lower then 0.");
				}
				_price = value;
			}
		}

		private double _shipping;
		public double Shipping
		{
			get { return _shipping; }
			set
			{
				if (value < 0)
				{
					throw new PackageException("The shipping can't be lower then 0.");
				}
				_shipping = value;
			}
		}
	}
}

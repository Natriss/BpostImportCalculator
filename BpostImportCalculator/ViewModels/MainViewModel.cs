using BpostImportCalculator.Helpers;

namespace BpostImportCalculator.ViewModels
{
	public class MainViewModel
	{
		private string _appTitle = "AppTitle".GetLocalized();

		public string AppTitle
		{
			get { return _appTitle; }
		}
	}
}

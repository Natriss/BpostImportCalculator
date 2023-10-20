using BpostImportCalculator.Helpers;

namespace BpostImportCalculator.ViewModels
{
	public class MainViewModel : BaseViewModel
	{
		private readonly string _appTitle = "AppTitle".GetLocalized();

		public string AppTitle
		{
			get { return _appTitle; }
		}
	}
}

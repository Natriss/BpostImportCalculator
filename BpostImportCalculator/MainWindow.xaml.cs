using BpostImportCalculator.ViewModels;
using BpostImportCalculator.Views;
using WinUIEx;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BpostImportCalculator
{
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainWindow : WindowEx
	{
		public MainViewModel ViewModel { get { return (MainViewModel)rootControl.DataContext; } }

		public MainWindow()
		{
			InitializeComponent();
			SetTitleBar(AppTitleBar);
			rootControl.DataContext = new MainViewModel();
			View.Navigate(typeof(BpostImportCalculatorPage));
		}
	}
}

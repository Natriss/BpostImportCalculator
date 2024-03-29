﻿using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BpostImportCalculator
{
	/// <summary>
	/// Provides application-specific behavior to supplement the default Application class.
	/// </summary>
	public partial class App : Application
	{
		public static FrameworkElement MainRoot { get; private set; }
		/// <summary>
		/// Initializes the singleton application object.  This is the first line of authored code
		/// executed, and as such is the logical equivalent of main() or WinMain().
		/// </summary>
		public App()
		{
			this.InitializeComponent();
		}

		/// <summary>
		/// Invoked when the application is launched.
		/// </summary>
		/// <param name="args">Details about the launch request and process.</param>
		protected override void OnLaunched(LaunchActivatedEventArgs args)
		{
			_window = new MainWindow()
			{
				ExtendsContentIntoTitleBar = true,
				SystemBackdrop = new MicaBackdrop(),
				MinHeight = 400,
				MinWidth = 500
			};
			MainRoot = _window.Content as FrameworkElement;
			_window.Activate();
		}

		private Window _window;
	}
}

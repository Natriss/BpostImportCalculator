using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinUILayer.Navigation;
using WinUILayer.Views;
using System.Runtime.InteropServices;
using WinRT;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUILayer
{
	/// <summary>
	/// Provides application-specific behavior to supplement the default Application class.
	/// </summary>
	public partial class App : Application
	{
		/// <summary>
		/// Initializes the singleton application object.  This is the first line of authored code
		/// executed, and as such is the logical equivalent of main() or WinMain().
		/// </summary>
		public App()
		{
			this.InitializeComponent();
		}

		/// <summary>
		/// Invoked when the application is launched normally by the end user.  Other entry points
		/// will be used such as when the application is launched to open a specific file.
		/// </summary>
		/// <param name="args">Details about the launch request and process.</param>
		protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
		{
			m_window = new Window();

			Frame frame = GetRootFrame();
			Type targetPageType = typeof(BpostImportCalculatorPage);
			string targetPageArguments = string.Empty;

			RootNavigationPage rootPage = StartupWindow.Content as RootNavigationPage;
			rootPage.Navigate(targetPageType, targetPageArguments);

			((NavigationViewItem)((RootNavigationPage)StartupWindow.Content).NavigationView.MenuItems[0]).IsSelected = true;

			m_window.Activate();
		}

		private Frame GetRootFrame()
		{
			Frame rootFrame;
			RootNavigationPage rootPage = StartupWindow.Content as RootNavigationPage;
			if (rootPage == null)
			{
				rootPage = new RootNavigationPage();
				rootFrame = (Frame)rootPage.FindName("rootFrame");
				if (rootFrame == null)
				{
					throw new Exception("Root frame not found");
				}

				StartupWindow.Content = rootPage;
			}
			else
			{
				rootFrame = (Frame)rootPage.FindName("rootFrame");
			}

			return rootFrame;
		}

		private static Window m_window;

		public static Window StartupWindow
		{
			get
			{
				return m_window;
			}
		}
	}
}

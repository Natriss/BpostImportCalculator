using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Threading.Tasks;

namespace BpostImportCalculator.Services
{
	public static class DialogService
	{
		public static async Task ShowMessageDialogAsync(this FrameworkElement frameworkElement, string title, string message, string closeButtonText)
		{
			ContentDialog dialog = new()
			{
				Title = title,
				Content = message,
				CloseButtonText = closeButtonText,
				XamlRoot = frameworkElement.XamlRoot
			};
			await dialog.ShowAsync();
		}
	}
}

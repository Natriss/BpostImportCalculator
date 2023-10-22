using BpostImportCalculator.Interfaces;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Threading.Tasks;

namespace BpostImportCalculator.Services
{
	public class DialogService : IDialogService
	{
		public async Task<ContentDialogResult> ShowErrorAsync(string message)
		{
			ContentDialog contentDialog = new()
			{
				Title = "Error",
				Content = message,
				CloseButtonText = "Okay",
			};

			ContentDialogResult result = await contentDialog.ShowAsync();
			return result;
		}
	}
}

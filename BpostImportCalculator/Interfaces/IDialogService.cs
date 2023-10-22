using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BpostImportCalculator.Interfaces
{
	public interface IDialogService
	{
		Task<ContentDialogResult> ShowErrorAsync(string message);
	}
}

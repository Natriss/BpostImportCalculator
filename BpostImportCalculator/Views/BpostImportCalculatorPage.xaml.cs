using BpostImportCalculator.Core.Models;
using BpostImportCalculator.ViewModels;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BpostImportCalculator.Views
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class BpostImportCalculatorPage : Page
    {
        //Package pakje = new();
        //bool isDoneLoading = false;
        public BpostImportCalculatorViewModel ViewModel { get { return (BpostImportCalculatorViewModel)this.DataContext; } }

        public BpostImportCalculatorPage()
		{
			InitializeComponent();
			DataContext = new BpostImportCalculatorViewModel();
			//isDoneLoading = true;
		}

		//private void Pakje_ValueChanged(NumberBox sender, NumberBoxValueChangedEventArgs args)
		//{
		//	try
		//	{
		//		if (isDoneLoading)
		//		{
		//			pakje.SetPrice((decimal)Pakje.Value);
		//			DouaneformaliteitenBerekenen();
		//			BTWBerekenen();
		//			TotaalBerekenen();
		//		}
		//	}
		//	catch
		//	{
		//		Pakje.Value = args.OldValue;
		//	}
		//}

		//private void Verzendkosten_ValueChanged(NumberBox sender, NumberBoxValueChangedEventArgs args)
		//{
		//	try
		//	{
		//		if (isDoneLoading)
		//		{
		//			pakje.SetShipping((decimal)Verzendkosten.Value);
		//			DouaneformaliteitenBerekenen();
		//			BTWBerekenen();
		//			TotaalBerekenen();
		//		}
		//	}
		//	catch
		//	{
		//		Verzendkosten.Value = args.OldValue;
		//	}

		//}

		//private void DouaneformaliteitenBerekenen()
		//{
		//	if (SoortZendinng.SelectedIndex == 0)
		//	{
		//		Douaneformaliteiten.Text = (pakje.Price + pakje.Shipping) switch
		//		{
		//			>= 150 => $"32,00",
		//			_ => $"15,00",
		//		};
		//	}
		//	if (SoortZendinng.SelectedIndex == 1)
		//	{
		//		Douaneformaliteiten.Text = (pakje.Price + pakje.Shipping) switch
		//		{
		//			>= 150 => $"32,00",
		//			>= 45 => $"15,00",
		//			_ => $"00,00",
		//		};
		//	}
		//}

		//private void BTWBerekenen()
		//{
		//	BTW.Text = $"{((pakje.Price + pakje.Shipping) + decimal.Parse(Douaneformaliteiten.Text)) * 21 / 100}";
		//}

		//private void TotaalBerekenen()
		//{
		//	Totaal.Text = $"{(pakje.Price + pakje.Shipping + decimal.Parse(Douaneformaliteiten.Text) + decimal.Parse(BTW.Text))}";
		//}

		//private void SoortZendinng_SelectionChanged(object sender, SelectionChangedEventArgs e)
		//{
		//	if (isDoneLoading)
		//	{
		//		DouaneformaliteitenBerekenen();
		//		BTWBerekenen();
		//		TotaalBerekenen();
		//	}
		//}
	}
}

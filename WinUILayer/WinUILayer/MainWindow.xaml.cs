using DomainLayer.Classes;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUILayer
{
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainWindow : Window
	{
		Pakje pakje = new();
		bool isDoneLoading = false;

		public MainWindow()
		{
			this.InitializeComponent();
			isDoneLoading = true;
		}

		private void Pakje_ValueChanged(NumberBox sender, NumberBoxValueChangedEventArgs args)
		{
			try
			{
				if (isDoneLoading)
				{
					pakje.ZetPrijs((decimal)Pakje.Value);
					DouaneformaliteitenBerekenen();
					BTWBerekenen();
					TotaalBerekenen();
				}
			}
			catch
			{
				Pakje.Value = args.OldValue;
			}
		}

		private void Verzendkosten_ValueChanged(NumberBox sender, NumberBoxValueChangedEventArgs args)
		{
			try
			{
				if (isDoneLoading)
				{
					pakje.ZetVerzendkosten((decimal)Verzendkosten.Value);
					DouaneformaliteitenBerekenen();
					BTWBerekenen();
					TotaalBerekenen();
				}
			}
			catch
			{
				Verzendkosten.Value = args.OldValue;
			}

		}

		private void DouaneformaliteitenBerekenen()
		{
			if (SoortZendinng.SelectedIndex == 0)
			{
				Douaneformaliteiten.Text = (pakje.Prijs + pakje.Verzendkosten) switch
				{
					>= 150 => $"32,00",
					_ => $"15,00",
				};
			}
			if (SoortZendinng.SelectedIndex == 1)
			{
				Douaneformaliteiten.Text = (pakje.Prijs + pakje.Verzendkosten) switch
				{
					>= 150 => $"32,00",
					>= 45 => $"15,00",
					_ => $"00,00",
				};
			}
		}

		private void BTWBerekenen()
		{
			BTW.Text = $"{((pakje.Prijs + pakje.Verzendkosten) + decimal.Parse(Douaneformaliteiten.Text)) * 21 / 100}";
		}

		private void TotaalBerekenen()
		{
			Totaal.Text = $"{(pakje.Prijs + pakje.Verzendkosten + decimal.Parse(Douaneformaliteiten.Text) + decimal.Parse(BTW.Text))}";
		}

		private void SoortZendinng_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (isDoneLoading)
			{
				DouaneformaliteitenBerekenen();
				BTWBerekenen();
				TotaalBerekenen();
			}
		}
	}
}

using DomainLayer.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Classes
{
	public class Pakje
	{
		#region Properties
		public decimal Prijs { get; private set; }
		public decimal Verzendkosten { get; private set; }
		#endregion

		#region Constructors
		public Pakje(decimal prijs, decimal verzendkosten)
		{
			ZetPrijs(prijs);
			ZetVerzendkosten(verzendkosten);
		}

		public Pakje()
		{
		}
		#endregion

		#region Methods
		public void ZetPrijs(decimal prijs)
		{
			if (prijs < 0)
			{
				throw new PakjeException("De prijs kan niet lager zijn dan 0.");
			}
			Prijs = prijs;
		}

		public void ZetVerzendkosten(decimal verzendKosten)
		{
			if (verzendKosten < 0)
			{
				throw new PakjeException("De verzendKosten kunnen niet lager zijn dan 0.");
			}
			Verzendkosten = verzendKosten;
		}
		#endregion
	}
}

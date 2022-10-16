namespace Nager.Country.Currencies
{
	/// <summary>
	/// Tnd Currency
	/// </summary>
	public class TndCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "د.ت.‏";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "TND";

		///<inheritdoc/>
		public string NumericCode => "788";

		///<inheritdoc/>
		public string Name => "Tunisian Dinar";
	}
}

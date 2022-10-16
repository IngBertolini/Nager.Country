namespace Nager.Country.Currencies
{
	/// <summary>
	/// Zar Currency
	/// </summary>
	public class ZarCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => string.Empty;

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "XPF";

		///<inheritdoc/>
		public string NumericCode => "953";

		///<inheritdoc/>
		public string Name => "CFP franc";
	}
}

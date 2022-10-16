namespace Nager.Country.Currencies
{
	/// <summary>
	/// Nok Currency
	/// </summary>
	public class NokCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "kr";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "NOK";

		///<inheritdoc/>
		public string NumericCode => "578";

		///<inheritdoc/>
		public string Name => "Norwegian Krone";
	}
}

namespace Nager.Country.Currencies
{
	/// <summary>
	/// Wst Currency
	/// </summary>
	public class WstCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "WS$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "WST";

		///<inheritdoc/>
		public string NumericCode => "882";

		///<inheritdoc/>
		public string Name => "Samoan tala";
	}
}

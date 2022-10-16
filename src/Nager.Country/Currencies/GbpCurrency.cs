namespace Nager.Country.Currencies
{
	/// <summary>
	/// Gbp Currency
	/// </summary>
	public class GbpCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "£";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "GBP";

		///<inheritdoc/>
		public string NumericCode => "826";

		///<inheritdoc/>
		public string Name => "British Pound";
	}
}

namespace Nager.Country.Currencies
{
	/// <summary>
	/// Krw Currency
	/// </summary>
	public class KrwCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "₩";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "KRW";

		///<inheritdoc/>
		public string NumericCode => "410";

		///<inheritdoc/>
		public string Name => "South Korean Won";
	}
}

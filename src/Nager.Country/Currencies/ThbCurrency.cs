namespace Nager.Country.Currencies
{
	/// <summary>
	/// Thb Currency
	/// </summary>
	public class ThbCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "฿";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "THB";

		///<inheritdoc/>
		public string NumericCode => "764";

		///<inheritdoc/>
		public string Name => "Thai Baht";
	}
}

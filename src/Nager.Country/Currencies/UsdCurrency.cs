namespace Nager.Country.Currencies
{
	/// <summary>
	/// Usd Currency
	/// </summary>
	public class UsdCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "USD";

		///<inheritdoc/>
		public string NumericCode => "840";

		///<inheritdoc/>
		public string Name => "US Dollar";
	}
}

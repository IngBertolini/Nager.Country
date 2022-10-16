namespace Nager.Country.Currencies
{
	/// <summary>
	/// Hkd Currency
	/// </summary>
	public class HkdCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "HKD";

		///<inheritdoc/>
		public string NumericCode => "344";

		///<inheritdoc/>
		public string Name => "Hong Kong Dollar";
	}
}

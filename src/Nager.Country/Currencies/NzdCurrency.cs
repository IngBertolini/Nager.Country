namespace Nager.Country.Currencies
{
	/// <summary>
	/// Nzd Currency
	/// </summary>
	public class NzdCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "NZD";

		///<inheritdoc/>
		public string NumericCode => "554";

		///<inheritdoc/>
		public string Name => "New Zealand Dollar";
	}
}

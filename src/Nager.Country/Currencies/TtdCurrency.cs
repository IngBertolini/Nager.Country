namespace Nager.Country.Currencies
{
	/// <summary>
	/// Ttd Currency
	/// </summary>
	public class TtdCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "TTD";

		///<inheritdoc/>
		public string NumericCode => "780";

		///<inheritdoc/>
		public string Name => "Trinidad and Tobago Dollar";
	}
}

namespace Nager.Country.Currencies
{
	/// <summary>
	/// Sgd Currency
	/// </summary>
	public class SgdCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "SGD";

		///<inheritdoc/>
		public string NumericCode => "702";

		///<inheritdoc/>
		public string Name => "Singapore Dollar";
	}
}

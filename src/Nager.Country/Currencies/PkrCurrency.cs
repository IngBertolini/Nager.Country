namespace Nager.Country.Currencies
{
	/// <summary>
	/// Pkr Currency
	/// </summary>
	public class PkrCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "Rs";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "PKR";

		///<inheritdoc/>
		public string NumericCode => "586";

		///<inheritdoc/>
		public string Name => "Pakistani Rupee";
	}
}

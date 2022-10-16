namespace Nager.Country.Currencies
{
	/// <summary>
	/// Uyu Currency
	/// </summary>
	public class UyuCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "UYU";

		///<inheritdoc/>
		public string NumericCode => "858";

		///<inheritdoc/>
		public string Name => "Uruguayan Peso";
	}
}

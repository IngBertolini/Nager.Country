namespace Nager.Country.Currencies
{
	/// <summary>
	/// Pln Currency
	/// </summary>
	public class PlnCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "zł";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "PLN";

		///<inheritdoc/>
		public string NumericCode => "985";

		///<inheritdoc/>
		public string Name => "Polish Zloty";
	}
}

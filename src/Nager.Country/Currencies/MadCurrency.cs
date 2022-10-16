namespace Nager.Country.Currencies
{
	/// <summary>
	/// Mad Currency
	/// </summary>
	public class MadCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "د.م.‏";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "MAD";

		///<inheritdoc/>
		public string NumericCode => "504";

		///<inheritdoc/>
		public string Name => "Moroccan Dirham";
	}
}

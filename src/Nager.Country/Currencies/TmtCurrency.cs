namespace Nager.Country.Currencies
{
	/// <summary>
	/// Tmt Currency
	/// </summary>
	public class TmtCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "m.";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "TMT";

		///<inheritdoc/>
		public string NumericCode => "934";

		///<inheritdoc/>
		public string Name => "Turkmenistani Manat";
	}
}

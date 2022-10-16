namespace Nager.Country.Currencies
{
	/// <summary>
	/// Xaf Currency
	/// </summary>
	public class XafCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "FCFA";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "XAF";

		///<inheritdoc/>
		public string NumericCode => "950";

		///<inheritdoc/>
		public string Name => "Central African CFA Franc";
	}
}

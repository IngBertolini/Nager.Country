namespace Nager.Country.Currencies
{
	/// <summary>
	/// Lbp Currency
	/// </summary>
	public class LbpCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "ل.ل.‏";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "LBP";

		///<inheritdoc/>
		public string NumericCode => "422";

		///<inheritdoc/>
		public string Name => "Lebanese Pound";
	}
}

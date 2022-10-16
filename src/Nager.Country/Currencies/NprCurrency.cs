namespace Nager.Country.Currencies
{
	/// <summary>
	/// Npr Currency
	/// </summary>
	public class NprCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "रु";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "NPR";

		///<inheritdoc/>
		public string NumericCode => "524";

		///<inheritdoc/>
		public string Name => "Nepalese Rupee";
	}
}

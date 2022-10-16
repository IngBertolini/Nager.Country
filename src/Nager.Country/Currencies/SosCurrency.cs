namespace Nager.Country.Currencies
{
	/// <summary>
	/// Srd Currency
	/// </summary>
	public class SrdCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "SRD";

		///<inheritdoc/>
		public string NumericCode => "968";

		///<inheritdoc/>
		public string Name => "Surinamese dollar";
	}
}

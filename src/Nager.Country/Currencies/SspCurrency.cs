namespace Nager.Country.Currencies
{
	/// <summary>
	/// Ssp Currency
	/// </summary>
	public class SspCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "SS£";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "SSP";

		///<inheritdoc/>
		public string NumericCode => "728";

		///<inheritdoc/>
		public string Name => "South Sudanese pound";
	}
}

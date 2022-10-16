namespace Nager.Country.Currencies
{
	/// <summary>
	/// Omr Currency
	/// </summary>
	public class OmrCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "ر.ع.‏";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "OMR";

		///<inheritdoc/>
		public string NumericCode => "512";

		///<inheritdoc/>
		public string Name => "Omani Rial";
	}
}

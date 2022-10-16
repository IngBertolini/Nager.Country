namespace Nager.Country.Currencies
{
	/// <summary>
	/// Bhd Currency
	/// </summary>
	public class BhdCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "د.ب.‏";

		///<inheritdoc/>
		public string Singular => "dinar";

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "BHD";

		///<inheritdoc/>
		public string NumericCode => "048";

		///<inheritdoc/>
		public string Name => "Bahraini dinar";
	}
}

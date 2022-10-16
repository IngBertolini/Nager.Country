namespace Nager.Country.Currencies
{
	/// <summary>
	/// Yer Currency
	/// </summary>
	public class YerCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "ر.ي.‏";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "YER";

		///<inheritdoc/>
		public string NumericCode => "886";

		///<inheritdoc/>
		public string Name => "Yemeni Rial";
	}
}

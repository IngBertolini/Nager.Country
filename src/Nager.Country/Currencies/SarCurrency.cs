namespace Nager.Country.Currencies
{
	/// <summary>
	/// Sar Currency
	/// </summary>
	public class SarCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "ر.س.‏";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "SAR";

		///<inheritdoc/>
		public string NumericCode => "682";

		///<inheritdoc/>
		public string Name => "Saudi Riyal";
	}
}

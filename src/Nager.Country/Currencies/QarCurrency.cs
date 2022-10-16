namespace Nager.Country.Currencies
{
	/// <summary>
	/// Qar Currency
	/// </summary>
	public class QarCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "ر.ق.‏";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "QAR";

		///<inheritdoc/>
		public string NumericCode => "634";

		///<inheritdoc/>
		public string Name => "Qatari Rial";
	}
}

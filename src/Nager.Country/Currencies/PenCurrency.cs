namespace Nager.Country.Currencies
{
	/// <summary>
	/// Pen Currency
	/// </summary>
	public class PenCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "S/";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "PEN";

		///<inheritdoc/>
		public string NumericCode => "604";

		///<inheritdoc/>
		public string Name => "Peruvian Sol";
	}
}

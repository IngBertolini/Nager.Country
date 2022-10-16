namespace Nager.Country.Currencies
{
	/// <summary>
	/// Irr Currency
	/// </summary>
	public class IrrCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "ريال";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "IRR";

		///<inheritdoc/>
		public string NumericCode => "364";

		///<inheritdoc/>
		public string Name => "Iranian Rial";
	}
}

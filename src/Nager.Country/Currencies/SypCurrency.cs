namespace Nager.Country.Currencies
{
	/// <summary>
	/// Syp Currency
	/// </summary>
	public class SypCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "ل.س.‏";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "SYP";

		///<inheritdoc/>
		public string NumericCode => "760";

		///<inheritdoc/>
		public string Name => "Syrian Pound";
	}
}

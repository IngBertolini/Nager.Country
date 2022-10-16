namespace Nager.Country.Currencies
{
	/// <summary>
	/// Kzt Currency
	/// </summary>
	public class KztCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "₸";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "KZT";

		///<inheritdoc/>
		public string NumericCode => "398";

		///<inheritdoc/>
		public string Name => "Kazakhstani Tenge";
	}
}

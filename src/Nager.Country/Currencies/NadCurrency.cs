namespace Nager.Country.Currencies
{
	/// <summary>
	/// Nad Currency
	/// </summary>
	public class NadCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "NAD";

		///<inheritdoc/>
		public string NumericCode => "516";

		///<inheritdoc/>
		public string Name => "Namibian dollar";
	}
}

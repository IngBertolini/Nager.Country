namespace Nager.Country.Currencies
{
	/// <summary>
	/// Htg Currency
	/// </summary>
	public class HtgCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "G";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "HTG";

		///<inheritdoc/>
		public string NumericCode => "332";

		///<inheritdoc/>
		public string Name => "Haitian Gourde";
	}
}

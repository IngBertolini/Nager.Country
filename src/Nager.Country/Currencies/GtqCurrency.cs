namespace Nager.Country.Currencies
{
	/// <summary>
	/// Gtq Currency
	/// </summary>
	public class GtqCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "Q";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "GTQ";

		///<inheritdoc/>
		public string NumericCode => "320";

		///<inheritdoc/>
		public string Name => "Guatemalan Quetzal";
	}
}

namespace Nager.Country.Currencies
{
	/// <summary>
	/// Shp Currency
	/// </summary>
	public class ShpCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "£";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "SHP";

		///<inheritdoc/>
		public string NumericCode => "654";

		///<inheritdoc/>
		public string Name => "Saint Helena pound";
	}
}
